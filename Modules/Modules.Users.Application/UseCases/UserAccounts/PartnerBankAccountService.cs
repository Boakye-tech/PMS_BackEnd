using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class PartnerBankAccountService : IPartnerBankAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        readonly IValidator<PartnerBankRegistrationRequestDto> _validator;

        public PartnerBankAccountService(UserManager<ApplicationIdentityUser> userManager,SignInManager<ApplicationIdentityUser> signInManager, IValidator<PartnerBankRegistrationRequestDto> validator)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _validator = validator;
        }


        public async Task<RegistrationResponse> UserRegistration(PartnerBankRegistrationRequestDto details)
        {
            try
            {
                ValidationResult validationResult = await _validator.ValidateAsync(details);

                if(!validationResult.IsValid)
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
                        Status = 1
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
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response  };
            }
            catch (Exception ex)
            {
                var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message };
                return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };
            }
        }

        public Task<string> SendVerificationToken(PartnerBankTokenRequestDto value)
        {
            throw new NotImplementedException();
        }

        public async Task<RegistrationResponse> ResetPassword(PartnerBankResetPasswordRequestDto resetPassword)
        {
            if(resetPassword is not null)
            {
                var userResult = await _userManager.FindByEmailAsync(resetPassword.EmailAddress);
                if(userResult is not null)
                {
                    var resetToken = await _userManager.GeneratePasswordResetTokenAsync(userResult);
                    var results = await _userManager.ResetPasswordAsync(userResult, resetToken, resetPassword.ConfirmNewPassword);

                    if (results.Succeeded)
                    {
                        var successResponse = new RegistrationSuccessResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = results.ToString(), UserId = userResult.Id, UserEmailAddress = userResult.Email! };
                        return new RegistrationResponse { IsSuccess = true, SuccessResponse = successResponse }; ;
                    }

                    if (!results.Succeeded)
                    {
                        var errorResponse = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = results.ToString() };
                        return new RegistrationResponse { IsSuccess = false, ErrorResponse = errorResponse };

                    }
                }
            }

            var err_response = new RegistrationErrorResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = StatusCodes.Status400BadRequest.ToString() };
            return new RegistrationResponse { IsSuccess = false, ErrorResponse = err_response };

        }

        public Task<string> GetBearerToken(PartnerBankLoginRequestDto userLoginDetails)
        {
            throw new NotImplementedException();
            //try
            //{
            //    var user = await _userManager.FindByEmailAsync(userLoginDetails.EmailAddress);
            //    if (user is null) { }

            //}
            //catch (Exception ex)
            //{

            //}
        }



    }
}

