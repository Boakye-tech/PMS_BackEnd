
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record UpdateUserDto(
        string UserId,
        string? MiddleName,
        [Phone]
        string? PhoneNumber,
        string? ProfilePicture
        
        );


}
