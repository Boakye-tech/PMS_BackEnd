using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class CustomerAccountService : ICustomerAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly ILogger<CustomerAccountService> _logger;
        private readonly ITokenService _tokenService;
        readonly IUnitOfWork _unitOfWork;

        public CustomerAccountService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager, IUnitOfWork unitOfWork, ILogger<CustomerAccountService> logger,
                                      ITokenService tokenService)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _logger = logger;
            _tokenService = tokenService;
        }

        public async Task<ChangePasswordResponse> ChangePassword(ChangeCustomerPasswordRequestDto changePassword)
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

        public async Task<ResetPasswordResponse> ResetPasswordViaEmailAddress(ResetCustomerPasswordEmailRequestDto resetPassword)
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

                var appUser = await _unitOfWork.Users.Get(u => u.Email == resetPassword.EmailAddress);
                var user = await _userManager.FindByIdAsync(appUser.Id);
                //var user = await _userManager.FindByEmailAsync(resetPassword.EmailAddress_OR_PhoneNumber);

                if (user is null)
                {
                    _logger.LogWarning($"Staff with email address or  {resetPassword.EmailAddress} not found.", resetPassword.EmailAddress);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Staff with email address {resetPassword.EmailAddress} not found."
                        }
                    };
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.NewPassword);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully reset for staff with email address {resetPassword.EmailAddress}.", resetPassword.EmailAddress);
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


                _logger.LogWarning($"Password reset failed for staff with email address {resetPassword.EmailAddress}. Errors: {result.Errors}", resetPassword.EmailAddress, string.Join(", ", result.Errors.Select(e => e.Description)));
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
                _logger.LogError(ex, $"An error occurred while resetting the password for staff with email address {resetPassword.EmailAddress}.", resetPassword.EmailAddress);
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

        public async Task<ResetPasswordResponse> ResetPasswordViaMobilePhoneNumber(ResetCustomerPasswordPhoneRequestDto resetPassword)
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

                var appUser = await _unitOfWork.Users.Get(u => u.PhoneNumber == resetPassword.MobilePhoneNumber);
                var user = await _userManager.FindByIdAsync(appUser.Id);
                //var user = await _userManager.FindByEmailAsync(resetPassword.EmailAddress_OR_PhoneNumber);

                if (user is null)
                {
                    _logger.LogWarning($"Customer with mobile phone number {resetPassword.MobilePhoneNumber} not found.", resetPassword.MobilePhoneNumber);
                    return new ResetPasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ResetPasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with mobile phone number {resetPassword.MobilePhoneNumber} not found."
                        }
                    };
                }

                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var result = await _userManager.ResetPasswordAsync(user, token, resetPassword.NewPassword);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully reset for staff with mobile phone number {resetPassword.MobilePhoneNumber}.", resetPassword.MobilePhoneNumber);
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


                _logger.LogWarning($"Password reset failed for staff with mobile phone number {resetPassword.MobilePhoneNumber}. Errors: {result.Errors}", resetPassword.MobilePhoneNumber, string.Join(", ", result.Errors.Select(e => e.Description)));
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
                _logger.LogError(ex, $"An error occurred while resetting the password for customer with mobile phone number {resetPassword.MobilePhoneNumber}.", resetPassword.MobilePhoneNumber);
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

        public async Task<CustomerLoginResponseDto> LoginWithEmailAddress(CustomerEmailLoginRequestDto userLoginDetails)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(userLoginDetails.EmailAddress!);

                if (user is null)
                {
                    _logger.LogWarning($"Customer with email address {userLoginDetails.EmailAddress} not found.", userLoginDetails.EmailAddress);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new CustomerLoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with {userLoginDetails.EmailAddress} not found."
                        }
                    };
                }

                var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Customer with email address {userLoginDetails.EmailAddress} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.EmailAddress);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = true,
                        successResponseDto = new CustomerLoginSucessResponseDto
                        {
                            UserId = user.Id,
                            FullName = string.Concat(user.FirstName, string.Empty, user.MiddleName, string.Empty, user.LastName),
                            EmailAddress = user.Email!,
                            MobilePhoneNumber = user.PhoneNumber!,
                            BearerToken = await _tokenService.GetJwToken(user, 8),
                        }
                    };
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"Staff with email address {userLoginDetails.EmailAddress} log in attempt {result.ToString()}", userLoginDetails.EmailAddress);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new CustomerLoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Staff login {result.ToString()}"
                        }
                    };
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while staff with email address {userLoginDetails.EmailAddress} tried to log in.", userLoginDetails.EmailAddress);
                return new CustomerLoginResponseDto
                {
                    LoginStatus = false,
                    errorResponseDto = new CustomerLoginErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.InnerException!.Message}"
                    }
                };
            }

        }

        public async Task<CustomerLoginResponseDto> LoginWithMobilePhoneNumber(CustomerPhoneLoginRequestDto userLoginDetails)
        {
            try
            {
                var phoneUser = await _unitOfWork.Users.Get(u => u.PhoneNumber == userLoginDetails.MobilePhoneNumber);
                if (phoneUser is null)
                {
                    _logger.LogWarning($"Customer with mobile phone number {userLoginDetails.MobilePhoneNumber} not found.", userLoginDetails.MobilePhoneNumber);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new CustomerLoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Customer with {userLoginDetails.MobilePhoneNumber} not found."
                        }
                    };
                }

                var user = await _userManager.FindByEmailAsync(phoneUser.Email!);
                var result = await _signInManager.PasswordSignInAsync(user!, userLoginDetails.Password!, true, false);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Customer with mobile phone number {userLoginDetails.MobilePhoneNumber} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.MobilePhoneNumber);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = true,
                        successResponseDto = new CustomerLoginSucessResponseDto
                        {
                            UserId = user!.Id,
                            FullName = string.Concat(user.FirstName, string.Empty, user.MiddleName, string.Empty, user.LastName),
                            EmailAddress = user.Email!,
                            MobilePhoneNumber = user.PhoneNumber!,
                            BearerToken = await _tokenService.GetJwToken(user, 8),
                        }
                    };
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"Customer with mobile phone number {userLoginDetails.MobilePhoneNumber} log in attempt {result.ToString()}", userLoginDetails.MobilePhoneNumber);
                    return new CustomerLoginResponseDto
                    {
                        LoginStatus = false,
                        errorResponseDto = new CustomerLoginErrorResponseDto
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Staff login {result.ToString()}"
                        }
                    };
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while customer with mobile phone number {userLoginDetails.MobilePhoneNumber} tried to log in.", userLoginDetails.MobilePhoneNumber);
                return new CustomerLoginResponseDto
                {
                    LoginStatus = false,
                    errorResponseDto = new CustomerLoginErrorResponseDto
                    {
                        StatusCode = StatusCodes.Status500InternalServerError,
                        StatusMessage = $"An unexpected error occurred. Please try again later. - {ex.Message}"
                    }
                };
            }

        }

        public async Task<RegistrationResponse> UserRegistration(CustomerRegistrationRequestDto details)
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
                        var errResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = results.Errors.ToString()! };
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
    }
}

