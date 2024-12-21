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

        readonly IUnitOfWork _unitOfWork;

        public CustomerAccountService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager, IUnitOfWork unitOfWork, ILogger<CustomerAccountService> logger)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _logger = logger;
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

                //if (changePassword != null)
                //{
                //    var user = await _userManager.FindByIdAsync(changePassword.UserId);
                //    if (user != null)
                //    {
                //        var result = await _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);

                //        if (result.Succeeded)
                //        {
                //            var successResponse = new ChangePasswordSuccessResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = result.ToString() };
                //            var response = new ChangePasswordResponse { IsSuccess = true, SuccessResponse = successResponse };
                //            return response;

                //        }

                //        if (!result.Succeeded)
                //        {
                //            var errResponse = new ChangePasswordErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = result.Errors.ToString()! };
                //            var response = new ChangePasswordResponse { IsSuccess = false, ErrorResponse = errResponse };
                //            return response;
                //        }
                //    }
                //}
                //var err_Response = new ChangePasswordErrorResponse { StatusCode = StatusCodes.Status204NoContent, StatusMessage = StatusCodes.Status204NoContent.ToString()! };
                //return new ChangePasswordResponse { IsSuccess = false, ErrorResponse = err_Response };


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

                //_logger.LogError(message: ex.InnerException!.Message, ex);
                //var errResponse = new ChangePasswordErrorResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message! };
                //return new ChangePasswordResponse { IsSuccess = false, ErrorResponse = errResponse };

            }
        }

        public async Task<ResetPasswordResponse> ResetPassword(ResetCustomerPasswordRequestDto resetPassword)
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

                var appUser = await _unitOfWork.Users.Get(u => u.Email == resetPassword.EmailAddress_OR_PhoneNumber || u.PhoneNumber == resetPassword.EmailAddress_OR_PhoneNumber);
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

        public async Task<CustomerLoginResponseDto> UserLogin(CustomerLoginRequestDto userLoginDetails)
        {
            throw new NotImplementedException();

            //var appUser = await _unitOfWork.Users.Get(u => u.Email == userLoginDetails.EmailAddress_OR_PhoneNumber || u.PhoneNumber == userLoginDetails.EmailAddress_OR_PhoneNumber);
            //var user = await _userManager.FindByEmailAsync(appUser.Email!);
            //if(user is not null)
            //{
            //    var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);

            //    if (result.Succeeded)
            //    {
            //    }
            //    else
            //    {
            //    }
            //}

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
                        RegistrationDate = details.RegistrationDate,
                        Status = details.Status,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
                    };

                    var results = await _userManager.CreateAsync(new_user, details.ConfirmPassword);

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

