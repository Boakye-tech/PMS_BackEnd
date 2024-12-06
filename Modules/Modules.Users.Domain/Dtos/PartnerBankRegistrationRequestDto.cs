
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Dtos
{
	public record PartnerBankRegistrationRequestDto();


	public record Test
	{
        [Required]
        [StringLength(256)]
        public required string PartnerName { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public required string EmailAddress { get; set; }

        [Phone]
        [Required]
        [StringLength(maximumLength: 12, MinimumLength = 9)]
        public required string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
        public required string ConfirmPassword { get; set; }
    }
}

