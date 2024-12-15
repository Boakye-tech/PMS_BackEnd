using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class PartnerBankAccountService : IPartnerBankAccountService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;

        public PartnerBankAccountService(UserManager<ApplicationIdentityUser> userManager,SignInManager<ApplicationIdentityUser> signInManager)
		{
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<RegistrationResponse> UserRegistration(PartnerBankRegistrationRequestDto details)
        {
            //throw new NotImplementedException();
            try
            {
                if(details != null)
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

