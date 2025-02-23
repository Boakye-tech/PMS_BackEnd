
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

        [Phone]
        string PhoneNumber,
        int ChannelId,
        //DateTime RegistrationDate,
        //int Status,
        string? ProfilePicture
        //string Password,
        //string ConfirmPassword
        );


}
