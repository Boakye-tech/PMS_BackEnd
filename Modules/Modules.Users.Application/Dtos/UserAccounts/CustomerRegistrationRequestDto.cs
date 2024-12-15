using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.UserAccounts
{
	public record CustomerRegistrationRequestDto(
        string CustomerCode,
        string FirstName,
        string MiddleName,
        string LastName,
        string PhoneNumber,
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

    //public class CustomerRegistrationTest
    //{
    //    [Required]
    //    [StringLength(10)]
    //    public required string CustomerCode { get; set; }

    //    [Required]
    //    [StringLength(50)]
    //    public required string FirstName { get; set; }

    //    [StringLength(50)]
    //    public string? MiddleName { get; set; }

    //    [Required]
    //    [StringLength(75)]
    //    public required string LastName { get; set; }

    //    [Phone]
    //    [Required]
    //    [StringLength(maximumLength: 12, MinimumLength = 9)]
    //    public required string PhoneNumber { get; set; }

    //    [Required]
    //    [EmailAddress]
    //    public required string EmailAddress { get; set; }

    //    [Required]
    //    [StringLength(12)]
    //    public required string LastReceiptNumber { get; set; }

    //    [StringLength(256)]
    //    public string? LastReceiptImage { get; set; }

    //    public int IdentificationTypeId { get; set; }

    //    [StringLength(50)]
    //    public string? IdentificationUniqueNumber { get; set; }

    //    [StringLength(256)]
    //    public string? IdentificationImage { get; set; }

    //    [StringLength(256)]
    //    public string? IdentificationImageOne { get; set; }

    //    [StringLength(256)]
    //    public string? SelfieImage { get; set; }

    //    [StringLength(256)]
    //    public string? PassportPicture { get; set; }

    //    [StringLength(10)]
    //    public string? Channel { get; set; }

    //    public DateTime RegistrationDate { get; set; }

    //    public int Status { get; set; }


    //    //public string? ProfilePicture { get; init; }

    //    //[Required]
    //    //[DataType(DataType.Password)]
    //    //public required string Password { get; set; }

    //    //[Required]
    //    //[DataType(DataType.Password)]
    //    //[Compare("Password", ErrorMessage = "Password and confirmation password do not match.")]
    //    //public required string ConfirmPassword { get; set; }
    //}
}

