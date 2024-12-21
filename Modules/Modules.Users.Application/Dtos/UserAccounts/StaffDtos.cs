
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record StaffRegistrationRequestDto(
        string StaffIdentificationNumber,
        int DepartmentId,
        int UnitId,
        string FirstName,
        string MiddleName,
        string LastName,
        [EmailAddress]
        string EmailAddress,
        [EmailAddress]
        string UserName,
        string PhoneNumber,
        string Channel,
        DateTime RegistrationDate,
        int Status,
        string? ProfilePicture,
        string Password,
        string ConfirmPassword
        );

    public record ResetStaffPasswordRequestDto() : ResetPasswordRequest;
    public record ChangeStaffPasswordRequestDto() : ChangePasswordRequest;
    public record StaffLoginRequestDto() : LoginRequest;
    

    public record StaffLoginResponseDto(string DepartmentName, string UnitName, string ProfilePictureFileName) : LoginResponse;
}

