using System;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IPartnerBankAccountService
	{
        Task<RegistrationResponse> UserRegistration(PartnerBankRegistrationRequestDto details);
        //Task<bool> ResetPassword(ResetUserPasswordRequest resetUserPassword);
        //Task<string> UserBearerToken(UserLoginRequest userLoginDetails);


        ////Task<bool> ApprovePartnerAccount(UserRequestParameter mobileNumber);
        ////Task<bool> DisapprovePartnerAccount(UserRequestParameter mobileNumber);

        //Task<bool> ActivatePartnerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DeactivatePartnerAccount(UserRequestParameter mobileNumber);

    }
}

