using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
    public record IndividualCustomerResponseDto
    {
        [Key]
        public int CustomerMasterId { get; set; }

        public string? CustomerType { get; set; }

        public string? ResidentType { get; set; }

        public string? Locality { get; set; }

        [StringLength(10)]
        public required string? CustomerCode { get; set; }

        public string? Title { get; set; }

        [StringLength(150)]
        public required string SurName { get; set; }

        [StringLength(75)]
        public required string OtherNames { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string? TinNumber { get; set; }

        [StringLength(255)]
        public string? Picture { get; set; }

        public string? Gender { get; set; }

        public string? Nationality { get; set; }

        [StringLength(255)]
        public string? PostalAddress { get; set; }

        [StringLength(255)]
        public string? ResidentialAddress { get; set; }

        [StringLength(50)]
        public string? DigitalAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string? PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? OfficeNumber { get; set; }

        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }

        [EmailAddress]
        public required string EmailAddress { get; set; }

        public string? SocialMediaPlatform { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        public string? IdentificationType { get; set; }

        [StringLength(20)]
        public string? IdentificationTypeNumber { get; set; }

        public string[]? IdentificationImages { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        public string? DebtorStatus { get; set; }

    }

    public record IndividualResidentCustomerResponseDto : IndividualCustomerResponseDto
    {
        public IndividualNonResidentCustomerResponseDto? NonResident { get; set; }
        public IndividualExpatriateCustomerResponseDto? Expatriate { get; set; }

    }

    public record IndividualNonResidentCustomerResponseDto //: IndividualCustomerResponseDto
    {
        [StringLength(255)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(12)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string? ContactPerson_EmailAddress { get; set; }

        [StringLength(255)]
        public string? ContactPerson_Address { get; set; }

        public string? ContactPerson_IdentificationType { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        //[StringLength(255)]
        //public string? ContactPerson_IdentificationTypeImage { get; set; }
        public string[]? ContactPerson_IdentificationImages { get; set; }
    }

    public record IndividualExpatriateCustomerResponseDto //: IndividualCustomerResponseDto
    {
        [StringLength(30)]
        public string? ResidentPermitNumber { get; set; }

        public DateTime? ResidentPermitDateIssued { get; set; }

        public DateTime? ResidentPermitExpiryDate { get; set; }
    }


}

