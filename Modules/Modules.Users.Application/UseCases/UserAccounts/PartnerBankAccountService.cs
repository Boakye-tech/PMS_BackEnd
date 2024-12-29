using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http.HttpResults;
using Modules.Users.Application.Interfaces;
using Microsoft.Extensions.Logging;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class PartnerBankAccountService : IPartnerBankAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;
        readonly IValidator<PartnerBankRegistrationRequestDto> _validator;
        private readonly ILogger<PartnerBankAccountService> _logger;
        private readonly ITokenService _tokenService;


        public PartnerBankAccountService(UserManager<ApplicationIdentityUser> userManager,SignInManager<ApplicationIdentityUser> signInManager, IValidator<PartnerBankRegistrationRequestDto> validator,
                                         ILogger<PartnerBankAccountService> logger, ITokenService tokenService)
		{
            _userManager = userManager;
            _signInManager = signInManager;
            _validator = validator;
            _logger = logger;
            _tokenService = tokenService;
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
                var userResult = await _userManager.FindByEmailAsync(resetPassword.EmailAddress!);
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

        public async Task<string> GetBearerToken(PartnerBankLoginRequestDto userLoginDetails)
        {
            try
            {
                var user = await _userManager.FindByEmailAsync(userLoginDetails.EmailAddress!);

                if (user is null)
                {
                    _logger.LogWarning($"Staff with email address {userLoginDetails.EmailAddress} not found.", userLoginDetails.EmailAddress);
                    return new string($"{StatusCodes.Status404NotFound} - partner with {userLoginDetails.EmailAddress} not found.");
                }

                var result = await _signInManager.PasswordSignInAsync(user, userLoginDetails.Password!, true, false);

                if (result.Succeeded)
                {
                    _logger.LogInformation($"Staff with email address {userLoginDetails.EmailAddress} logged in successfully {DateTime.UtcNow.ToString()}", userLoginDetails.EmailAddress);
                    return new string(await _tokenService.GetJwToken(user, 24));
                }

                if (!result.Succeeded)
                {
                    _logger.LogWarning($"Staff with email address {userLoginDetails.EmailAddress} log in attempt {result.ToString()}", userLoginDetails.EmailAddress);
                    return new string($"{StatusCodes.Status404NotFound} - Staff login {result.ToString()}.");
                }

                return null!;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"An error occurred while staff with email address {userLoginDetails.EmailAddress} tried to log in.", userLoginDetails.EmailAddress);
                return new string($"{StatusCodes.Status500InternalServerError} - {ex.Message}.");

            }
        }



    }
}

