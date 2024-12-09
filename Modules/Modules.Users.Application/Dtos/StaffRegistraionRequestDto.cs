
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Dtos
{
	public record StaffRegistraionRequestDto(string name);

	public record StaffTest
	{

        [Required]
        [StringLength(10)]
        public required string StaffIdentificationNumber { get; init; }

        [Required]
        public required int DepartmentId { get; init; }
        

        [Required]
        [StringLength(50)]
        public required string FirstName { get; init; }

        [StringLength(50)]
        public string? MiddleName { get; init; }

        [Required]
        [StringLength(75)]
        public required string LastName { get; init; }

        [Required]
        [EmailAddress]
        public required string EmailAddress { get; init; }

        [Required]
        [Compare("EmailAddress", ErrorMessage = "Email Address and UserName must be the same")]
        public required string UserName { get; init; }

        [Phone]
        [Required]
        [StringLength(maximumLength: 12, MinimumLength = 9)]
        public required string PhoneNumber { get; init; }

        public string? ProfilePicture { get; init; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; init; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public required string ConfirmPassword { get; init; }
    }
}

