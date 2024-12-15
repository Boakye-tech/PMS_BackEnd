using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Application.UseCases.UserAccounts
{
	public class StaffAccouuntService: IStaffAccouuntService
    {
        private readonly UserManager<ApplicationIdentityUser> _userManager;
        private readonly SignInManager<ApplicationIdentityUser> _signInManager;


        public StaffAccouuntService(UserManager<ApplicationIdentityUser> userManager, SignInManager<ApplicationIdentityUser> signInManager)
		{
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task<RegistrationResponse> UserRegistration(StaffRegistrationRequestDto details)
        {
            //throw new NotImplementedException();
            try
            {
                if (details != null)
                {
                    var new_user = new ApplicationIdentityUser
                    {
                        IdentificationUniqueNumber = details.StaffIdentificationNumber,
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

