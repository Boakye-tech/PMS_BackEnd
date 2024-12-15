using System;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IStaffAccouuntService
    {
        Task<RegistrationResponse> UserRegistration(StaffRegistrationRequestDto details);
        //Task<bool> ResetPassword(ResetUserPasswordRequest resetUserPassword);


        //Task<bool> ConfirmCustomerAccount(UserRequestParameter mobileNumber);
        
        //Task<bool> ConfirmStaffAccount(UserRequestParameter mobileNumber);

        //Task<bool> ApproveCustomerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisapproveCustomerAccount(UserRequestParameter mobileNumber);

        //Task<bool> EnableStaffAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisableStaffAccount(UserRequestParameter mobileNumber);
    }
}

