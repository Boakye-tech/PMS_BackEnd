
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record PartnerBankRegistrationRequestDto(
        string PartnerName,
        string EmailAddress,
        string PhoneNumber,
        string Password,
        string ConfirmPassword,
        string ContactPerson_FullName,
        string ContactPerson_EmailAddress,
        string ContactPerson_PhoneNumber,
        string ContactPerson_Position
        );


    public record PartnerBankResetPasswordRequestDto(string EmailAddress, int Token, string NewPassword, string ConfirmNewPassword);

    public record PartnerBankLoginRequestDto() : LoginRequest;

    public record PartnerBankTokenRequestDto(string EmailAddress);
}

