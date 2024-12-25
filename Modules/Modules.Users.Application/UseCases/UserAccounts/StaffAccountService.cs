using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class StaffAccountService: IStaffAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        private readonly ILogger<StaffAccountService> _logger;


        public StaffAccountService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager, ILogger<StaffAccountService> logger)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }

        public async Task<ChangePasswordResponse> ChangePassword(ChangeStaffPasswordRequestDto changePassword)
        {
            //throw new NotImplementedException();
            if (changePassword is null)
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
                if (user is null)
                {
                    _logger.LogWarning($"Staff with User ID {changePassword.UserId} not found.", changePassword.UserId);
                    return new ChangePasswordResponse
                    {
                        IsSuccess = false,
                        ErrorResponse = new ChangePasswordErrorResponse
                        {
                            StatusCode = StatusCodes.Status404NotFound,
                            StatusMessage = $"Staff User ID {changePassword.UserId} not found."
                        }
                    };
                }


                var result = await _userManager.ChangePasswordAsync(user, changePassword.OldPassword, changePassword.NewPassword);
                if (result.Succeeded)
                {
                    _logger.LogInformation($"Password successfully changed for staff with user ID {changePassword.UserId}.", changePassword.UserId);
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


                _logger.LogWarning($"Password change failed for staff with user ID {changePassword.UserId}. Errors: {result.Errors}", changePassword.UserId, string.Join(", ", result.Errors.Select(e => e.Description)));
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
                _logger.LogError(ex, $"An error occurred while changing the password for staff with user ID {changePassword.UserId}.", changePassword?.UserId);
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

        public async Task<ResetPasswordResponse> ResetPassword(ResetStaffPasswordRequestDto resetPassword)
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

                var user = await _userManager.FindByEmailAsync(resetPassword.EmailAddress!);
                if (user is null)
                {
                    _logger.LogWarning($"Staff with email address {resetPassword.EmailAddress} not found.", resetPassword.EmailAddress);
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

        public async Task<StaffLoginResponseDto> UserLogin(StaffLoginRequestDto userLoginDetails)
        {
            throw new NotImplementedException();
            //try
            //{
            //    var user = await _userManager.FindByEmailAsync(userLoginDetails.EmailAddress!);
            //    if(user is not null)
            //    {
            //        var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);

            //        if (result.Succeeded) { } else { }
            //    }

            //}
            //catch (Exception ex)
            //{

            //}
        }

        public async Task<RegistrationResponse> UserRegistration(StaffRegistrationRequestDto details)
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
                        RegistrationDate = details.RegistrationDate,
                        Status = details.Status,
                        ProfilePicture = details.ProfilePicture,
                        EmailConfirmed = false,
                        PhoneNumberConfirmed = false,
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
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = results.ToString() };
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





    }
}

