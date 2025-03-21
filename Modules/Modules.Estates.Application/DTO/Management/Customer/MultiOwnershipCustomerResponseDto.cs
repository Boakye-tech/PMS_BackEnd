using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record MultiOwnershipCustomerResponseDto : IndividualCustomerResponseDto
    {
        public string? MaritalStatus { get; set; }
        public DateTime? DateOfMarriage { get; set; }

        public IndividualNonResidentCustomerResponseDto? NonResident { get; set; }
        public IndividualExpatriateCustomerResponseDto? Expatriate { get; set; }

        //public IEnumerable<DependantCustomerResponseDto>? Dependant { get; set; }

    }

    public record DependantCustomerResponseDto : MultiCustomerResponseDto
    {
        public IndividualNonResidentCustomerResponseDto? NonResident { get; set; }
        public IndividualExpatriateCustomerResponseDto? Expatriate { get; set; }
    }


    public record MultiCustomerResponseDto
    {
        public int CustomerMasterId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        public int TitleId { get; set; }

        public required string Title { get; set; }

        [StringLength(150)]
        public required string SurName { get; set; }

        [StringLength(75)]
        public required string OtherNames { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string? TinNumber { get; set; }

        [StringLength(255)]
        public string? Picture { get; set; }

        public int GenderId { get; set; }

        public string? Gender { get; set; }

        public int NationalityId { get; set; }

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

        public int SocialMediaTypeId { get; set; }

        public string? SocialMediaPlatform { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        public int IdentificationTypeId { get; set; }

        public string? IdentificationType { get; set; }

        [StringLength(20)]
        public string? IdentificationTypeNumber { get; set; }

        public string[]? IdentificationImages { get; set; }

    }

}

