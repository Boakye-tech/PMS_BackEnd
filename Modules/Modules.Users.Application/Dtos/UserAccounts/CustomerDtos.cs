using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record CustomerRegistrationRequestDto(
        string CustomerCode,
        string FirstName,
        string MiddleName,
        string LastName,
        string PhoneNumber,
        [EmailAddress]
        string EmailAddress,
        string LastReceiptNumber,
        string LastReceiptImage,
        int IdentificationTypeId,
        string IdentificationUniqueNumber,
        string IdentificationImage,
        string IdentificationImageOne,
        string SelfieImage,
        string PassportPicture,
        string Channel,
        DateTime RegistrationDate,
        int Status,
        string Password,
        string ConfirmPassword
        );

    public record CustomerLoginResponseDto() : LoginResponse;
    public record ChangeCustomerPasswordRequestDto() : ChangePasswordRequest;

    public record ResetCustomerPasswordEmailRequestDto : ResetPasswordRequest;
    public record ResetCustomerPasswordPhoneRequestDto( string MobilePhoneNumber, int Token, string NewPassword, string ConfirmNewPassword);


    public record CustomerEmailLoginRequestDto : LoginRequest;
    public record CustomerPhoneLoginRequestDto(string MobilePhoneNumber, string Password);



    /*
    public record ResetCustomerPasswordRequestDto : ResetPasswordRequest
    {
        [JsonIgnore]
        public new string EmailAddress => base.EmailAddress!;

        [JsonPropertyName("EmailAddress_OR_PhoneNumber")]
        public string EmailAddress_OR_PhoneNumber
        {
            get => base.EmailAddress!;
            set => base.EmailAddress = value;
        }
    }
    
    public record CustomerLoginRequestDto : LoginRequest
    {
        [JsonIgnore]
        public new string EmailAddress => base.EmailAddress!;

        //[JsonPropertyName("EmailAddress_OR_PhoneNumber")]
        //public override required string EmailAddress { get; set; }

        [JsonPropertyName("EmailAddress_OR_PhoneNumber")]
        public string EmailAddress_OR_PhoneNumber
        {
            get => base.EmailAddress!;
            set => base.EmailAddress = value;
        }
    }
    */

}

