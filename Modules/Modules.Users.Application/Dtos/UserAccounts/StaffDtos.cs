
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

    public record ResetStaffPasswordRequestDto : ResetPasswordRequest
    {
        [EmailAddress]
        public required string EmailAddress { get; set; }
    }
    public record ChangeStaffPasswordRequestDto() : ChangePasswordRequest;
    public record StaffLoginRequestDto : LoginRequest
    {
        [EmailAddress]
        public required string EmailAddress { get; set; }
    }


    public record StaffLoginResponseDto
    {
        public bool LoginStatus { get; set; }
        public StaffLoginSuccessResponseDto? staffLoginSuccessResponseDto { get; set; }
        public StaffLoginErrorResponseDto? staffLoginErrorResponseDto { get; set; }
    }

    public record StaffLoginSuccessResponseDto : LoginResponse
    {
        public required string DepartmentName { get; set; }
        public required string UnitName { get; set; }
        public required string ProfilePictureFileName { get; set; }
    }

    public record StaffLoginErrorResponseDto() : BaseResponse;

}
