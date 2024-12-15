
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


	//public record Test
	//{
 //       [Required]
 //       [StringLength(256)]
 //       public required string PartnerName { get; set; }

 //       [Required]
 //       [EmailAddress]
 //       [StringLength(100)]
 //       public required string EmailAddress { get; set; }

 //       [Phone]
 //       [Required]
 //       [StringLength(maximumLength: 12, MinimumLength = 9)]
 //       public required string PhoneNumber { get; set; }

 //       [Required]
 //       [DataType(DataType.Password)]
 //       public required string Password { get; set; }

 //       [Required]
 //       [DataType(DataType.Password)]
 //       [Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
 //       public required string ConfirmPassword { get; set; }

 //       [StringLength(256)]
 //       public required string ContactPerson_FullName { get; set; }

 //       [Required]
 //       [EmailAddress]
 //       [StringLength(100)]
 //       public required string ContactPerson_EmailAddress { get; set; }

 //       [Phone]
 //       [Required]
 //       [StringLength(maximumLength: 12, MinimumLength = 9)]
 //       public required string ContactPerson_PhoneNumber { get; set; }

 //       [StringLength(100)]
 //       public required string ContactPerson_Position { get; set; }
 //   }

    //public record PartnerBankRegistrationRequestDto();
    //public record ContactPerson();
}

