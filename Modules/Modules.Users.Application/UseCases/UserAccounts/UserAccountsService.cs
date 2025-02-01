using System;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Modules.Users.Application.Enums;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class UserAccountsService : IUserAccountsService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly ILogger<UserAccountsService> _logger;
        private readonly ITokenStoreRepository _tokenService;
        readonly IUnitOfWork _unitOfWork;

        readonly IValidator<PartnerBankRegistrationRequestDto> _partnerValidator;

        public UserAccountsService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager, IUnitOfWork unitOfWork, ILogger<UserAccountsService> logger,
                                      ITokenStoreRepository tokenRepo, IValidator<PartnerBankRegistrationRequestDto> partnerValidator)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _tokenService = tokenRepo;
            _partnerValidator = partnerValidator;
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


                var result = await _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);

                if (result.Succeeded)
                {
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


                _logger.LogWarning($"Password change failed for customer with user ID {changePassword.UserId}. Errors: {result.Errors}", changePassword.UserId, string.Join(", ", result.Errors.Select(e => e.Description)));
                return new ChangePasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ChangePasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        StatusMessage = $"Password change failed. - {result.Errors}"
                    }
                };

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

        public async Task<ResetPasswordResponse> ResetPasswordViaEmailAddress(ResetPasswordRequestDto resetPassword)
        {
            //throw new NotImplementedException();
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

                var appUser = await _unitOfWork.Users.Get(u => u.Email == resetPassword.Phone_OR_Email);
                var user = await _userManager.FindByIdAsync(appUser.Id);
                //var user = await _userManager.FindByEmailAsync(resetPassword.EmailAddress_OR_PhoneNumber);

                if (user is null)
                {
                    _logger.LogWarning($"Customer with email address {resetPassword.Phone_OR_Email} not found.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with email address {resetPassword.Phone_OR_Email} not found."
                        }
                    };
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.NewPassword);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully reset for customer with email address {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = true,
                        SuccessResponse = new ResetPasswordSuccessResponse
                        {
                            StatusCode = StatusCodes.Status200OK,
                            StatusMessage = $"Password reset {result.ToString()}"
                        }
                    };

                }


                _logger.LogWarning($"Password reset failed for staff with email address {resetPassword.Phone_OR_Email}. Errors: {result.Errors}", resetPassword.Phone_OR_Email, string.Join(", ", result.Errors.Select(e => e.Description)));
                return new ResetPasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ResetPasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        StatusMessage = $"Password reset failed. - {result.Errors}"
                    }
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while resetting the password for staff with email address {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
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

        public async Task<ResetPasswordResponse> ResetPasswordViaMobilePhoneNumber(ResetPasswordRequestDto resetPassword)
        {
            //throw new NotImplementedException();
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

                var appUser = await _unitOfWork.Users.Get(u => u.PhoneNumber == resetPassword.Phone_OR_Email);
                var user = await _userManager.FindByIdAsync(appUser.Id);
                //var user = await _userManager.FindByEmailAsync(resetPassword.EmailAddress_OR_PhoneNumber);

                if (user is null)
                {
                    _logger.LogWarning($"Customer with mobile phone number {resetPassword.Phone_OR_Email} not found.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with mobile phone number {resetPassword.Phone_OR_Email} not found."
                        }
                    };
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.NewPassword);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully reset for staff with mobile phone number {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = true,
                        SuccessResponse = new ResetPasswordSuccessResponse
                        {
                            StatusCode = StatusCodes.Status200OK,
                            StatusMessage = $"Password reset {result.ToString()}"
                        }
                    };

                }


                _logger.LogWarning($"Password reset failed for staff with mobile phone number {resetPassword.Phone_OR_Email}. Errors: {result.Errors}", resetPassword.Phone_OR_Email, string.Join(", ", result.Errors.Select(e => e.Description)));
                return new ResetPasswordResponse
                {
                    IsSuccess = false,
                    ErrorResponse = new ResetPasswordErrorResponse
                    {
                        StatusCode = StatusCodes.Status400BadRequest,
                        StatusMessage = $"Password reset failed. - {result.Errors}"
                    }
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while resetting the password for customer with mobile phone number {resetPassword.Phone_OR_Email}.", resetPassword.Phone_OR_Email);
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
                    _logger.LogWarning($"Customer with email address {userLoginDetails.Phone_OR_Email} not found.", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User with {userLoginDetails.Phone_OR_Email} not found."
                        }
                    };
                }

                var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"User with email address {userLoginDetails.Phone_OR_Email} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.Phone_OR_Email);

                    user.RefreshToken = _tokenService.GetJwRefreshToken().Token;
                    user.RefreshTokenExpires = _tokenService.GetJwRefreshToken().Expires;

                    _unitOfWork.Users.Update(user);
                    await _unitOfWork.Complete();


                    return new LoginResponseDto
                    {
                        LoginStatus = true,
                        successResponseDto = new LoginSucessResponseDto
                        {
                            UserId = user.Id,
                            IsFirstTime = user.IsFirstTime,
                            BearerToken = _tokenService.GetJwToken(user, 3).Token!,
                            RefreshToken = _tokenService.GetJwRefreshToken().Token!,
                            ExpiresAt = _tokenService.GetJwRefreshToken().Expires 
                        }
                    };
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"User with email address {userLoginDetails.Phone_OR_Email} log in attempt {result.ToString()}", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new LoginErrorResponseDto
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
                _logger.LogError(ex, $"An error occurred while user with email address {userLoginDetails.Phone_OR_Email} tried to log in.", userLoginDetails.Phone_OR_Email);
                return new LoginResponseDto
                {
                    LoginStatus = false,
                    errorResponseDto = new LoginErrorResponseDto
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
                if (phoneUser is null)
                {
                    _logger.LogWarning($"User with mobile phone number {userLoginDetails.Phone_OR_Email} not found.", userLoginDetails.Phone_OR_Email);
                    return new LoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new LoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"User with {userLoginDetails.Phone_OR_Email} not found."
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
                        successResponseDto = new LoginSucessResponseDto
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
                        errorResponseDto = new LoginErrorResponseDto
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
                    errorResponseDto = new LoginErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.Message}"
                    }
                };
            }

        }

        public async Task<RefreshTokenResponseDto> RefreshBearerToken(RefreshTokenRequestDto tokens)
        {
            //throw new NotImplementedException();
            if (tokens is null)
            {
            }

            string oldAccessToken = tokens!.BearerToken;
            string oldRefreshToken = tokens.RefreshToken;

            var principal = _tokenService.GetClaimsPrincipalFromExpiredBearerToken(oldAccessToken);
            var userId = principal.Identity!.Name;

            var user = await _unitOfWork.Users.Get(u => u.Id == userId);

            if (user is null || user.RefreshToken != tokens.RefreshToken || user.RefreshTokenExpires <= DateTime.UtcNow)
            {
            }

            string? newBearerToken = _tokenService.GetJwToken(user!, 3).Token;
            string newRefreshToken = _tokenService.GetJwRefreshToken().Token!;
            DateTime refreshTokenExpiresAt = _tokenService.GetJwRefreshToken().Expires;

            user!.RefreshToken = newRefreshToken;
            user.RefreshTokenExpires = refreshTokenExpiresAt;

            return new RefreshTokenResponseDto
            {
                UserId = user.Id,
                BearerToken = newBearerToken,
                RefreshToken = newRefreshToken,
                ExpiresAt = refreshTokenExpiresAt
            };
        }

        public async Task<RegistrationResponse> CustomerUserRegistration(CustomerRegistrationRequestDto details)
        {
            //throw new NotImplementedException();
            try
            {
                if (details != null)
                {
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
                        Channel = details.Channel,
                        RegistrationDate = DateTime.UtcNow,
                        Status = 0,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                        IsFirstTime = true,
                        UserType = (int)UserAccountType.Customer
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
                        _logger.LogError($"{details.Channel} - Customer Registration Error: {string.Join("; ", results.Errors.Select(err => err.Description))}");
                        var errResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
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
                        Status = 1,
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
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
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
                    var new_user = new ApplicationIdentityUser
                    {
                        IdentificationNumber = details.StaffIdentificationNumber,
                        DepartmentId = details.DepartmentId,
                        UnitId = details.UnitId,
                        FirstName = details.FirstName,
                        MiddleName = details.MiddleName,
                        LastName = details.LastName,
                        Email = details.EmailAddress,
                        UserName = details.EmailAddress,
                        PhoneNumber = details.PhoneNumber,
                        Channel = details.Channel,
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
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = string.Join("; ", results.Errors.Select(err => err.Description)) };
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

        public Task<bool> UserDetails(string userId)
        {
            throw new NotImplementedException();
        }
    }
}

