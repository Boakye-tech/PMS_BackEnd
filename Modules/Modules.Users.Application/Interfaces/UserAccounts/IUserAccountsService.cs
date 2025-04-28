// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Interfaces.UserAccounts
{
	public interface IUserAccountsService
    {
        Task<RegistrationResponse> CustomerUserRegistration(CustomerRegistrationRequestDto details);
        Task<RegistrationResponse> StaffUserRegistration(StaffRegistrationRequestDto details);
        Task<RegistrationResponse> PartnerUserRegistration(PartnerBankRegistrationRequestDto details);

        Task<ChangePasswordResponse> ChangePassword(ChangePasswordRequestDto changePassword);
        Task<ResetPasswordResponse> ResetPassword(ResetPasswordRequestDto resetPassword);

        Task<LoginResponseDto> LoginWithEmailAddress(LoginRequestDto emailLoginDetails);
        Task<LoginResponseDto> LoginWithMobilePhoneNumber(LoginRequestDto phoneLoginDetails);

        Task<RefreshTokenResponseDto> RefreshBearerToken(RefreshTokenRequestDto tokens);

        Task<UserInformationDto> UserDetails(string userId);


        //string SendSmsToken(UserRequestParameter mobileNumber); //OTPRequest
        //Task<bool> VerifySmsToken(VerifySmsRequest userVerifySmsToken);

        //string SendEmailToken(UserRequestParameter emailAddress); //OTPRequest
        //Task<bool> VerifyEmailToken(VerifyEmailRequest userVerifyEmailToken);


        //Task<bool> VerifyCustomerRegistration(VerifyEmailRequest userVerifyEmailToken);

        //Task<bool> ApproveCustomerAccount(UserRequestParameter mobileNumber);
        //Task<bool> DisapproveCustomerAccount(UserRequestParameter mobileNumber);

        //Task<bool> ActivateCustomerAccount(UserRequestParameter mobileNumber);

        Task<UpdateAccountDetailsResponseDto> UpdateAccountDetails(UpdateUserDto values);
        Task<UpdateTokenDetailsResponseDto> UpdateMobileToken(UpdateMobileTokenDto values);

    }
}

