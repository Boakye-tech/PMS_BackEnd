// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class UserAccountsService : IUserAccountsService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly ILogger<UserAccountsService> _logger;
        private readonly ITokenStoreRepository _tokenService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMenuService _menuService;
        private readonly IValidator<PartnerBankRegistrationRequestDto> _partnerValidator;

        private readonly IPasswordValidator<ApplicationIdentityUser> _passwordValidator;

        public UserAccountsService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager, IUnitOfWork unitOfWork, ILogger<UserAccountsService> logger,
                                      ITokenStoreRepository tokenRepo, IValidator<PartnerBankRegistrationRequestDto> partnerValidator, IMenuService menuService, IPasswordValidator<ApplicationIdentityUser> passwordValidator)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _tokenService = tokenRepo;
            _partnerValidator = partnerValidator;
            _menuService = menuService;
            _passwordValidator = passwordValidator;
        }

        public async Task<ChangePasswordResponse> ChangePassword(ChangePasswordRequestDto changePassword)
        {
            if(changePassword is null)
            {
                _logger.LogWarning("Change password request is null.");
                return new ChangePasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ChangePasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        StatusMessage = "Invalid request data."
                    }
                };
            }

            try
            {

                var user = await _userManager.FindByIdAsync(changePassword.UserId);
                if(user is null)
                {
                    _logger.LogWarning($"Customer with user ID {changePassword.UserId} not found.", changePassword.UserId);
                    return new ChangePasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ChangePasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with user ID {changePassword.UserId} not found."
                        }
                    };
                }

                var validationResult = await _passwordValidator.ValidateAsync(_userManager, user, changePassword.NewPassword);
                if (!validationResult.Succeeded)
                {
                    return new ChangePasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ChangePasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"Password change failed. - {string.Join(", ", validationResult.Errors.Select(e => e.Description))}"
                        }
                    };
                }
                    

                var result = await _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);

                if (result.Succeeded)
                {
                    //set IsFirstTime to false upon successful change of password
                    user.IsFirstTime = false;
                    await _userManager.UpdateAsync(user);

                    _logger.LogInformation($"Password successfully changed for customer with user ID {changePassword.UserId}.", changePassword.UserId);
                    return new ChangePasswordResponse
                    {
                        IsSuccess = true,
                        SuccessResponse = new ChangePasswordSuccessResponse
                        {
                            StatusCode = StatusCodes.Status200OK,
                            StatusMessage = $"Password change {result.ToString()}"
                        }
                    };

                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"Password change failed for customer with user ID {changePassword.UserId}. Errors: {string.Join(", ", result.Errors.Select(e => e.Description))}", changePassword.UserId, string.Join(", ", result.Errors.Select(e => e.Description)));
                    return new ChangePasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ChangePasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"Password change failed. - {string.Join(", ", result.Errors.Select(e => e.Description))}"
                        }
                    };
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while changing the password for customer with user ID {changePassword.UserId}.", changePassword?.UserId);
                return new ChangePasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ChangePasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.InnerException!.Message}"
                    }
                };

            }
        }

        public async Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequestDto resetPassword)
        {
            if (resetPassword is null)
            {
                _logger.LogWarning("Reset password request is null.");
                return new ResetPasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ResetPasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        StatusMessage = "Invalid request data."
                    }
                };
            }

            try
            {
                //remember to check for the validity of the token
                var otpresult = _unitOfWork.TokenStore.CheckVerifiedToken(resetPassword.Phone_OR_Email, resetPassword.Token);
                if (otpresult != "Verified")
                {
                    _logger.LogWarning($"OTP Token {resetPassword.Token} is invalid.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"OTP Token '{resetPassword.Token}' is invalid."
                        }
                    };
                }

                //remember to check for the expiry validity of the token
                var otp_result = _unitOfWork.TokenStore.VerifyTokenExpiry(resetPassword.Phone_OR_Email, resetPassword.Token);
                if (otp_result != "Expired")
                {
                    _logger.LogWarning($"User with email address {resetPassword.Phone_OR_Email}  and OTP Token {resetPassword.Token} not verified.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"User with email address '{resetPassword.Phone_OR_Email.ToLower()}' and OTP Token '{resetPassword.Token}' not verified."
                        }
                    };

                }

                var appUser = await _unitOfWork.Users.Get(u =>  u.Email == resetPassword.Phone_OR_Email || u.PhoneNumber == resetPassword.Phone_OR_Email);
                var user = await _userManager.FindByIdAsync(appUser!.Id);

                if (user is null)
                {
                    _logger.LogWarning($"User with email address or phone number {resetPassword.Phone_OR_Email} not found.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User with email address or phone number '{resetPassword.Phone_OR_Email}' not found."
                        }
                    };
                }


                var validationResult = await _passwordValidator.ValidateAsync(_userManager, user, resetPassword.NewPassword);
                if (!validationResult.Succeeded)
                {
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"Password reset failed. - {string.Join(", ", validationResult.Errors.Select(e => e.Description))}"
                        }
                    };
                }

                //check otp token validity
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.NewPassword);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully reset for user with email address or phone number {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = true,
                        SuccessResponse = new ResetPasswordSuccessResponse
                        {
                            StatusCode = StatusCodes.Status200OK,
                            StatusMessage = $"Password reset {result.ToString().ToLower()}"
                        }
                    };

                }
                if (!result.Succeeded)
                {
                    _logger.LogWarning($"Password reset failed for user with email address or phone number {resetPassword.Phone_OR_Email}. Errors: {string.Join(", ", result.Errors.Select(e => e.Description))}", resetPassword.Phone_OR_Email, string.Join(", ", result.Errors.Select(e => e.Description)));
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"Password reset failed. - {string.Join(", ", result.Errors.Select(e => e.Description))}"
                        }
                    };
                }

                return null!;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while resetting the password for user with email address or phone number {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
                return new ResetPasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ResetPasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.InnerException!.Message}"
                    }
                };
            }
        }

        public async Task<LoginResponseDto> LoginWithEmailAddress(LoginRequestDto userLoginDetails)
        {
            try
            {

                var user = await _userManager.FindByEmailAsync(userLoginDetails.Phone_OR_Email!);
                if (user is null)
                {
                    _logger.LogWarning($"User account with email address {userLoginDetails.Phone_OR_Email} not found.", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User with email address '{userLoginDetails.Phone_OR_Email}' not found."
                        }
                    };
                }


                var userRoles = _userManager.GetRolesAsync(user!).Result.FirstOrDefault();
                if(userRoles is null)
                {
                    _logger.LogWarning($"User Role not set for user account with email address '{userLoginDetails.Phone_OR_Email}'", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User Role not set for user account with '{userLoginDetails.Phone_OR_Email}'"
                        }
                    };

                }


                var validationResult = await _passwordValidator.ValidateAsync(_userManager, user, userLoginDetails.Password);
                if (!validationResult.Succeeded)
                {
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status400BadRequest,
                            StatusMessage = $"User Login failed. - {string.Join(", ", validationResult.Errors.Select(e => e.Description))}"
                        }
                    };
                }

                var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"User account with email address {userLoginDetails.Phone_OR_Email} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.Phone_OR_Email);

                    var _refreshToken = _tokenService.GetJwRefreshToken().Token;
                    var _refreshTokenExpires = _tokenService.GetJwRefreshToken().Expires;


                    user.RefreshToken = _refreshToken;
                    user.RefreshTokenExpires = _refreshTokenExpires;

                    _unitOfWork.Users.Update(user);
                    await _unitOfWork.Complete();


                    return new LoginResponseDto
                    {
                        LoginStatus = true,
                        successResponse = new LoginSucessResponseDto
                        {
                            UserId = user.Id,
                            IsFirstTime = user.IsFirstTime,
                            BearerToken = _tokenService.GetJwToken(user, 8).Token!,
                            RefreshToken = _refreshToken!,//_tokenService.GetJwRefreshToken().Token!,
                            ExpiresAt = _refreshTokenExpires //_tokenService.GetJwRefreshToken().Expires 
                        }
                    };
                }

                if (result.IsLockedOut)
                {
                    _logger.LogWarning($"User account with email address {userLoginDetails.Phone_OR_Email} is locked. Try again later", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = "User Account is locked. Try again later."
                        }
                    };
                }

                if (result.IsNotAllowed)
                {
                    var emailConfirmed = await _userManager.IsEmailConfirmedAsync(user);
                    var phoneConfirmed = await _userManager.IsPhoneNumberConfirmedAsync(user);

                    _logger.LogWarning($"User with email address {userLoginDetails.Phone_OR_Email} is not allowed to sign in. EmailConfirmed: {emailConfirmed}, PhoneConfirmed: {phoneConfirmed}", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = "User Account is not allowed to sign in. Please contact your administrator."
                        }
                    };
                }

                if (result.RequiresTwoFactor)
                {
                    _logger.LogWarning($"Two-factor authentication required for user with email address {userLoginDetails.Phone_OR_Email}", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = "Two-factor authentication required."
                        }
                    };
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"User with email address {userLoginDetails.Phone_OR_Email} log in attempt failed", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = "User login attempt failed. Kindly check your credentials or please contact your administrator."
                        }
                    };
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while user with email address {userLoginDetails.Phone_OR_Email} tried to log in.", userLoginDetails.Phone_OR_Email);
                return new LoginResponseDto
                {
                    LoginStatus = false,
                    errorResponse = new LoginErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.InnerException!.Message}"
                    }
                };
            }

        }

        public async Task<LoginResponseDto> LoginWithMobilePhoneNumber(LoginRequestDto userLoginDetails)
        {
            try
            {
                var phoneUser = await _unitOfWork.Users.Get(u => u.PhoneNumber == userLoginDetails.Phone_OR_Email);

                var userRoles = _userManager.GetRolesAsync(phoneUser!).Result.FirstOrDefault();

                if (userRoles is null)
                {
                    _logger.LogWarning($"User Role not set for user account with mobile phone number '{userLoginDetails.Phone_OR_Email}'", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User Role not set for user account with mobile phone number '{userLoginDetails.Phone_OR_Email}'"
                        }
                    };

                }

                if (phoneUser is null)
                {
                    _logger.LogWarning($"User with mobile phone number {userLoginDetails.Phone_OR_Email} not found.", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User account with '{userLoginDetails.Phone_OR_Email}' not found."
                        }
                    };
                }

                var user = await _userManager.FindByEmailAsync(phoneUser.Email!);
                var result = await _signInManager.PasswordSignInAsync(user!, userLoginDetails.Password!, true, false);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"User with mobile phone number {userLoginDetails.Phone_OR_Email} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = true,
                        successResponse = new LoginSucessResponseDto
                        {
                            UserId = user!.Id,
                            IsFirstTime = user.IsFirstTime,
                            BearerToken = _tokenService.GetJwToken(user, 3).Token!,
                            RefreshToken = _tokenService.GetJwRefreshToken().Token!,
                            ExpiresAt = _tokenService.GetJwToken(user, 3).ExpiresAt!
                        }
                    };
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"User with mobile phone number {userLoginDetails.Phone_OR_Email} log in attempt {result.ToString()}", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponse = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User login {result.ToString()}"
                        }
                    };
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while customer with mobile phone number {userLoginDetails.Phone_OR_Email} tried to log in.", userLoginDetails.Phone_OR_Email);
                return new LoginResponseDto
                {
                    LoginStatus = false,
                    errorResponse = new LoginErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.Message}"
                    }
                };
            }

        }

        public async Task<RefreshTokenResponseDto> RefreshBearerToken(RefreshTokenRequestDto tokens)
        {
            if (tokens is null)
            {
                return new RefreshTokenResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new RefreshTokenErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status400BadRequest ,
                        StatusMessage = "Bearer and refresh tokens cannot be null or empty"
                    }
                    
                };
            }

            string oldAccessToken = tokens!.BearerToken;

            var principal = _tokenService.GetClaimsPrincipalFromExpiredBearerToken(oldAccessToken);
            var userId = principal.Claims.FirstOrDefault()!.Value;

            var user = await _userManager.FindByIdAsync(userId);

            if (user is null)
            {
                return new RefreshTokenResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new RefreshTokenErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = "User id not found."
                    }
                };
            }

            if (user.RefreshToken != tokens.RefreshToken )
            {
                return new RefreshTokenResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new RefreshTokenErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = "Refresh token provided does not exist or is invalid."
                    }
                };
            }

            if (user.RefreshTokenExpires <= DateTime.UtcNow)
            {
                return new RefreshTokenResponseDto
                {
                    IsSuccess = false,
                    ErrorResponse = new RefreshTokenErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status404NotFound,
                        StatusMessage = "Refresh token has expired."
                    }
                };
            }

            string? newBearerToken =  _tokenService.GetJwToken(user!, 3).Token;
            string newRefreshToken = _tokenService.GetJwRefreshToken().Token!;
            DateTime refreshTokenExpiresAt = _tokenService.GetJwRefreshToken().Expires;

            user!.RefreshToken = newRefreshToken;
            user.RefreshTokenExpires = refreshTokenExpiresAt;

            return new RefreshTokenResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new RefreshTokenSuccessResponseDto
                {
                    UserId = user.Id,
                    BearerToken = newBearerToken,
                    RefreshToken = newRefreshToken,
                    ExpiresAt = refreshTokenExpiresAt
                }
            };
        }

        public async Task<RegistrationResponse> CustomerUserRegistration(CustomerRegistrationRequestDto details)
        {
            try
            {
                if (details != null)
                {
                    var channels = await _unitOfWork.Channels.Get(details.ChannelId);

                    if (channels is null)
                    {
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status404NotFound, StatusMessage = "Channel not found." };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }

                    var new_user = new ApplicationIdentityUser
                    {
                        IdentificationNumber = details.CustomerCode,
                        FirstName = details.FirstName,
                        MiddleName = details.MiddleName,
                        LastName = details.LastName,
                        Email = details.EmailAddress,
                        UserName = details.EmailAddress,
                        PhoneNumber = details.PhoneNumber,
                        LastReceiptNumber = details.LastReceiptNumber,
                        LastReceiptImage = details.LastReceiptImage,
                        IdentificationTypeId = details.IdentificationTypeId,
                        IdentificationUniqueNumber = details.IdentificationUniqueNumber,
                        IdentificationImage = details.IdentificationImage,
                        IdentificationImageOne = details.IdentificationImageOne,
                        SelfieImage = details.SelfieImage,
                        PassportPicture = details.PassportPicture,
                        ChannelId = details.ChannelId,
                        RegistrationDate = DateTime.UtcNow,
                        Status = (int)RegistrationStatus.Pending,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        IsFirstTime = true,
                        UserType = (int)UserAccountType.Customer,
                        FirebaseId = details.FirebaseId
                    };

                    var results = await _userManager.CreateAsync(new_user); //, details.ConfirmPassword

                    if (results.Succeeded)
                    {
                        await _signInManager.SignInAsync(new_user, isPersistent: false);

                        var successResponse = new RegistrationSuccessResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = results.ToString(), UserId = new_user.Id, UserEmailAddress = new_user.Email! };
                        var response = new RegistrationResponse { IsSuccess = true, SuccessResponse = successResponse };

                        return response;

                    }

                    if (!results.Succeeded)
                    {
                        _logger.LogError($"Customer Registration Error: {string.Join("; ", results.Errors.Select(err => err.Description))}");
                        var errResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status409Conflict, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errResponse };
                        //return response;
                    }
                }

                var err_Response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status204NoContent, StatusMessage = StatusCodes.Status204NoContent.ToString()! };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_Response };

            }
            catch (Exception ex)
            {
                var errResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message! };
                return new RegistrationResponse { IsSuccess = false , ErrorResponse = errResponse };
            }
        }

        public async Task<RegistrationResponse> PartnerUserRegistration(PartnerBankRegistrationRequestDto details)
        {
            try
            {
                ValidationResult validationResult = await _partnerValidator.ValidateAsync(details);

                if (validationResult.IsValid)
                {
                    var new_user = new ApplicationIdentityUser
                    {
                        PartnerName = details.PartnerName,
                        UserName = details.EmailAddress,
                        Email = details.EmailAddress,
                        PhoneNumber = details.PhoneNumber,
                        ContactPerson_FullName = details.ContactPerson_FullName,
                        ContactPerson_Email = details.ContactPerson_EmailAddress,
                        ContactPerson_PhoneNumber = details.ContactPerson_PhoneNumber,
                        ContactPerson_Position = details.ContactPerson_Position,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        Status = (int)RegistrationStatus.Pending,
                        UserType = (int)UserAccountType.Partners
                    };

                    var results = await _userManager.CreateAsync(new_user, details.ConfirmPassword);

                    if (results.Succeeded)
                    {
                        await _signInManager.SignInAsync(new_user, isPersistent: false);

                        var successResponse = new RegistrationSuccessResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = results.ToString(), UserId = new_user.Id, UserEmailAddress = new_user.Email! };
                        return new RegistrationResponse { IsSuccess = true, SuccessResponse = successResponse }; ;

                    }

                    if (!results.Succeeded)
                    {
                        _logger.LogError($"Partner Bank Registration Error: {string.Join("; ", results.Errors.Select(err => err.Description))}");
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status409Conflict, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }
                }

                var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = validationResult.ToString() };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };
            }
            catch (Exception ex)
            {
                var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };
            }
        }

        public async Task<RegistrationResponse> StaffUserRegistration(StaffRegistrationRequestDto details)
        {
            try
            {
                if (details != null)
                {
                    var staffId = await _unitOfWork.Users.Get(i => i.IdentificationNumber == details.StaffIdentificationNumber);
                    if(staffId is not null)
                    {
                        _logger.LogError($"Staff Registration Error - Staff Identification Number: {details.StaffIdentificationNumber} already exist");
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status409Conflict, StatusMessage = $"Registration Error - Staff Identification Number: {details.StaffIdentificationNumber} already exist." };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }

                    var unit = await _unitOfWork.DepartmentUnit.Get(du => du.DepartmentId == details.DepartmentId && du.UnitId == details.UnitId);
                    if(unit is null)
                    {
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status404NotFound, StatusMessage = "Department and unit not found." };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }

                    var channels = await _unitOfWork.Channels.Get(details.ChannelId);
                    if (channels is null)
                    {
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status404NotFound, StatusMessage = "Channel not found." };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }

                    var new_user = new ApplicationIdentityUser
                    {
                        IdentificationNumber = details.StaffIdentificationNumber,
                        DepartmentId = details.DepartmentId,
                        UnitId = details.UnitId,
                        FirstName = details.FirstName.Trim(),
                        MiddleName = details.MiddleName.Trim(),
                        LastName = details.LastName.Trim(),
                        Email = details.EmailAddress,
                        UserName = details.EmailAddress,
                        PhoneNumber = details.PhoneNumber,
                        ChannelId = details.ChannelId,
                        RegistrationDate = DateTime.UtcNow,
                        Status = (int) RegistrationStatus.Pending,
                        ProfilePicture = details.ProfilePicture,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        UserType = (int)UserAccountType.Staff
                    };

                    var results = await _userManager.CreateAsync(new_user); //, details.ConfirmPassword

                    if (results.Succeeded)
                    {
                        await _signInManager.SignInAsync(new_user, isPersistent: false);

                        var successResponse = new RegistrationSuccessResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = results.ToString(), UserId = new_user.Id, UserEmailAddress = new_user.Email! };
                        return new RegistrationResponse { IsSuccess = true, SuccessResponse = successResponse }; ;
                    }

                    if (!results.Succeeded)
                    {
                        _logger.LogError($"Staff Registration Error: {string.Join("; ", results.Errors.Select(err => err.Description))}");
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status409Conflict, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };
                    }
                }

                var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = StatusCodes.Status400BadRequest.ToString() };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };
            }
            catch (Exception ex)
            {
                var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };
            }
        }

        public async Task<UserInformationDto> UserDetails(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if(user!.UserType == (int)UserAccountType.Customer)
            {
                var channelName = (await _unitOfWork.Channels.Get(user.ChannelId))?.ChannelName ?? "Unknown";
                var userType = UserAccountTypeEnumDescription.UserType(user.UserType).ToString();
                var registrationStatus = RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString();
                var identificationType = (await _unitOfWork.IdentificationType.Get(user.IdentificationTypeId))?.IdentificationTypes ?? "Unknown";

                return new CustomerUserInformationDto(user, identificationType, channelName, userType, registrationStatus);
            }

            if (user!.UserType == (int)UserAccountType.Staff)
            {

                var department = (await _unitOfWork.Department.Get(user.DepartmentId))?.DepartmentName ?? "Unknown";
                var unit = (await _unitOfWork.DepartmentUnit.Get(user.UnitId))?.UnitName ?? "Unknown";
                var channelName = (await _unitOfWork.Channels.Get(user.ChannelId))?.ChannelName ?? "Unknown";
                var userType = UserAccountTypeEnumDescription.UserType(user.UserType).ToString();
                var registrationStatus = RegistrationStatusEnumDescription.RegistrationStatusEnum(user.Status).ToString();

                var userRoles = await _userManager.GetRolesAsync(user);
                if(userRoles.Count == 0)
                {
                    var permissions = new PermissionsAccessModulesReadDto(string.Empty, new List<PermissionAccessMenusWithActionsReadDto>());
                    return new StaffUserInformationDto(user, department, unit, channelName, userType, registrationStatus, userRoles, permissions!);

                }
                else
                {
                    var permissions = await _menuService.GetUserRolePermissions(user.Id);
                    return new StaffUserInformationDto(user, department, unit, channelName, userType, registrationStatus, userRoles, permissions);

                }

                // GetRolesPermissions(roleId);

            }

            return null!;
        }

        public async Task<UpdateAccountDetailsResponseDto> UpdateAccountDetails(UpdateUserDto values)
        {
            if(values is null)
            {
                return new UpdateAccountDetailsResponseDto { error = new GenericResponseDto("The update request cannot be null or empty"), success = null! };
            }

            var user = await _userManager.FindByIdAsync(values.UserId);
            if(user is null)
            {
                return new UpdateAccountDetailsResponseDto { error = new GenericResponseDto("User id not found"), success = null! };
            }

            if(string.IsNullOrWhiteSpace(values.UserId) && string.IsNullOrWhiteSpace(values.PhoneNumber) && string.IsNullOrWhiteSpace(values.ProfilePicture) && string.IsNullOrWhiteSpace(values.MiddleName))
            {
                return new UpdateAccountDetailsResponseDto { error = new GenericResponseDto("At least two values must be supplied."), success = null! };
            }

            if(!string.IsNullOrWhiteSpace(values.PhoneNumber))
            {
                user.PhoneNumber = values.PhoneNumber;
            }

            if (!string.IsNullOrWhiteSpace(values.ProfilePicture))
            {
                user.ProfilePicture = values.ProfilePicture;
            }

            if (!string.IsNullOrWhiteSpace(values.MiddleName))
            {
                user.MiddleName = values.MiddleName;
            }

            await _userManager.UpdateAsync(user);

            return new UpdateAccountDetailsResponseDto { error = null, success = await UserDetails(values.UserId)};
        }

        public async Task<UpdateTokenDetailsResponseDto> UpdateMobileToken(UpdateMobileTokenDto values)
        {

            if (values is null)
            {
                return new UpdateTokenDetailsResponseDto { error = new GenericResponseDto("The update request cannot be null or empty"), success = null! };
            }

            if (string.IsNullOrWhiteSpace(values.UserId) || string.IsNullOrWhiteSpace(values.FirebaseToken) )
            {
                return new UpdateTokenDetailsResponseDto { error = new GenericResponseDto("Both values must be supplied."), success = null! };
            }

            var user = await _userManager.FindByIdAsync(values.UserId);
            if (user is null)
            {
                return new UpdateTokenDetailsResponseDto { error = new GenericResponseDto("User id not found"), success = null! };
            }

            user.FirebaseId = values.FirebaseToken;

            await _userManager.UpdateAsync(user);

            return new UpdateTokenDetailsResponseDto { error = null, success = new GenericResponseDto("Firebase token updated successfully.") };
        }


    }
}

