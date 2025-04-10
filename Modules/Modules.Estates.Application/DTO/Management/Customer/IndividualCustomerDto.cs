using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record IndividualCustomerDto
	{
        [Key]
        public int CustomerMasterId { get; set; }

        public required int CustomerTypeId { get; set; }

        public required int ResidentTypeId { get; set; }

        public required int LocalityId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        public required int TitleId { get; set; }

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

        public int NationalityId { get; set; }

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

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        public int IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? IdentificationTypeNumber { get; set; }

        public string[]? IdentificationImages { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        //public int DebtorStatus { get; set; }

    }

    public record IndividualResidentCustomerDto : IndividualCustomerDto
    {
        public string? CreatedBy { get; set; }

        public IndividualNonResidentCustomerDto? NonResident { get; set; }
        public IndividualExpatriateCustomerDto? Expatriate { get; set; }
    }


    public record UpdateIndividualResidentCustomerDto : IndividualCustomerDto
    {
        public string? ModifiedBy { get; set; }

        public IndividualNonResidentCustomerDto? NonResident { get; set; }
        public IndividualExpatriateCustomerDto? Expatriate { get; set; }
    }

    public record IndividualNonResidentCustomerDto
    {
        [StringLength(255)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(12)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(255)]
        //[EmailAddress]
        public string? ContactPerson_EmailAddress { get; set; }

        [StringLength(12)]
        public string? ContactPerson_Address { get; set; }

        public int ContactPerson_IdentificationTypeId { get; set; }

        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        public string[]? ContactPerson_IdentificationImages { get; set; }
    }


    public record IndividualExpatriateCustomerDto
    {
        [StringLength(30)]
        public string? ResidentPermitNumber { get; set; }

        public DateTime? ResidentPermitDateIssued { get; set; }

        public DateTime? ResidentPermitExpiryDate { get; set; }
    }

}

