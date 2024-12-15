using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class CustomerAccountService : ICustomerAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;


        public CustomerAccountService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager)
		{
            _userManager = userManager;
            _signInManager = signInManager;
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

                        var response = new RegistrationResponse { StatusCode = StatusCodes.Status201Created, StatusMessage = results.ToString(), UserId = new_user.Id, UserEmailAddress = new_user.Email! };
                        return response;

                    }

                    if (!results.Succeeded)
                    {
                        var response = new RegistrationResponse { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = results.ToString(), UserId = string.Empty };
                        return response;
                    }
                }

                return new RegistrationResponse { StatusCode = StatusCodes.Status204NoContent, StatusMessage = StatusCodes.Status204NoContent.ToString(), UserId = string.Empty };
            }
            catch (Exception ex)
            {
                return new RegistrationResponse { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.InnerException!.Message, UserId = string.Empty };
            }
        }
    }
}

