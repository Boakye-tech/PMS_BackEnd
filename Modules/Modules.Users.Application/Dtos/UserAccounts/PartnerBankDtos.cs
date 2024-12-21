
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record PartnerBankRegistrationRequestDto(
        string PartnerName,
        [EmailAddress]
        string EmailAddress,
        [Phone]
        string PhoneNumber,
        string Password,
        string ConfirmPassword,
        string ContactPerson_FullName,
        string ContactPerson_EmailAddress,
        string ContactPerson_PhoneNumber,
        string ContactPerson_Position
        );


    public record PartnerBankResetPasswordRequestDto : ResetPasswordRequest;

    public record PartnerBankLoginRequestDto : LoginRequest;

    public record PartnerBankTokenRequestDto
    {
        [EmailAddress]
        public string? EmailAddress { get; set; }
    };
}

 