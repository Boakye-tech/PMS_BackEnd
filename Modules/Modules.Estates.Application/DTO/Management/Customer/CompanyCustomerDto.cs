using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record CompanyCustomerDto
	{
        [Key]
        public int CustomerMasterId { get; set; }

        public int CustomerTypeId { get; set; }

        public int ResidentTypeId { get; set; }

        public int LocalityId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }
       
        [StringLength(150)]
        public string? CompanyName { get; set; }

        public int NationalityId { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        [StringLength(255)]
        public string? CompanyAddress { get; set; } //map to residential address field

        [StringLength(50)]
        public string? DigitalAddress { get; set; }

        [StringLength(12)]
        public string? PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? OfficeNumber { get; set; }

        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }

        [StringLength(20)]
        public string? BusinessRegistrationNumber { get; set; }

        [StringLength(20)]
        public string? TinNumber { get; set; }

        [StringLength(255)]
        public string? Picture { get; set; }

        public int SocialMediaTypeId { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        //public int DebtorStatus { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        public string[]? IdentificationImages { get; set; }

        public CompanyContactPerson? ContactPerson { get; set; }
    }

    public record CreateCompanyCustomerDto: CompanyCustomerDto
    {
        [StringLength(50)]
        public string? CreatedBy { get; set; }
    }

    public record UpdateCompanyCustomerDto: CompanyCustomerDto
    {
        [StringLength(50)]
        public string? ModifiedBy { get; set; }
    }


    public record CompanyContactPerson
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

        public int ContactPerson_IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        public string[]? ContactPerson_IdentificationImages { get; set; }
    }
    
}

