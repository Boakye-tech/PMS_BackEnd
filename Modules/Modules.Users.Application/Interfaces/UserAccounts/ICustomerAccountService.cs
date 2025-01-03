﻿using System;
namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface ICustomerAccountService
    {
        Task<RegistrationResponse> UserRegistration(CustomerRegistrationRequestDto details);
        Task<ChangePasswordResponse> ChangePassword(ChangeCustomerPasswordRequestDto changePassword);

        Task<ResetPasswordResponse> ResetPasswordViaEmailAddress(ResetCustomerPasswordEmailRequestDto resetPassword);
        Task<ResetPasswordResponse> ResetPasswordViaMobilePhoneNumber(ResetCustomerPasswordPhoneRequestDto resetPassword);

        Task<CustomerLoginResponseDto> LoginWithEmailAddress(CustomerEmailLoginRequestDto emailLoginDetails);
        Task<CustomerLoginResponseDto> LoginWithMobilePhoneNumber(CustomerPhoneLoginRequestDto phoneLoginDetails);


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

