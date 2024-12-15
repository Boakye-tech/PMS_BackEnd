using System;
namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface ICustomerAccountService
    {
        Task<RegistrationResponse> UserRegistration(CustomerRegistrationRequestDto details);
        //Task<bool> ResetPassword(ResetUserPasswordRequest resetUserPassword);
        //Task<bool> ForgtoPassword(ResetUserPasswordRequest resetUserPassword);
        //Task<UserLoginResponse> UserLogin(UserLoginRequest userLoginDetails);


        //string SendSmsToken(UserRequestParameter mobileNumber); //OTPRequest
        //Task<bool> VerifySmsToken(VerifySmsRequest userVerifySmsToken);

        //string SendEmailToken(UserRequestParameter emailAddress); //OTPRequest
        //Task<bool> VerifyEmailToken(VerifyEmailRequest userVerifyEmailToken);


        //Task<bool> VerifyCustomerRegistration(VerifyEmailRequest userVerifyEmailToken);





        //Task<bool> ApproveCustomerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisapproveCustomerAccount(UserRequestParameter mobileNumber);

        //Task<bool> ActivateCustomerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DeactivateCustomerAccount(UserRequestParameter mobileNumber);
    }
}

