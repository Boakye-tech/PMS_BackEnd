using System;

namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IPartnerBankAccountService
	{
        Task<RegistrationResponse> UserRegistration(PartnerBankRegistrationRequestDto details);
        Task<string> SendVerificationToken(PartnerBankTokenRequestDto value);
        Task<RegistrationResponse> ResetPassword(PartnerBankResetPasswordRequestDto resetUserPassword);
        Task<string> GetBearerToken(PartnerBankLoginRequestDto userLoginDetails);


        ////Task<bool> ApprovePartnerAccount(UserRequestParameter mobileNumber);
        ////Task<bool> DisapprovePartnerAccount(UserRequestParameter mobileNumber);

        //Task<bool> ActivatePartnerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DeactivatePartnerAccount(UserRequestParameter mobileNumber);

    }
}

