using System;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IStaffAccountService
    {
        Task<RegistrationResponse> UserRegistration(StaffRegistrationRequestDto details);
        Task<ResetPasswordResponse> ResetPassword(ResetStaffPasswordRequestDto resetUserPassword);
        Task<ChangePasswordResponse> ChangePassword(ChangeStaffPasswordRequestDto resetUserPassword);
        Task<StaffLoginResponseDto> UserLogin(StaffLoginRequestDto userLoginDetails);


        //Task<bool> ConfirmCustomerAccount(UserRequestParameter mobileNumber);

        //Task<bool> ConfirmStaffAccount(UserRequestParameter mobileNumber);

        //Task<bool> ApproveCustomerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisapproveCustomerAccount(UserRequestParameter mobileNumber);

        //Task<bool> EnableStaffAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisableStaffAccount(UserRequestParameter mobileNumber);
    }
}

