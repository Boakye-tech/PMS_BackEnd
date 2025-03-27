using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
    public record ProspectiveCustomerResponseDto
    {
        [Key]
        public int CustomerMasterId { get; set; }

        public int CustomerTypeId { get; set; }

        public string? CustomerType { get; set; }

        public int ResidentTypeId { get; set; }

        public string? ResidentType { get; set; }

        public int LocalityId { get; set; }

        public string? Locality { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        public int TitleId { get; set; }

        public string? Title { get; set; }

        [StringLength(150)]
        public string? SurName { get; set; }

        [StringLength(75)]
        public string? OtherNames { get; set; }

        [StringLength(100)]
        public string? CompanyName { get; set; }

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

        [StringLength(12)]
        public string? PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? OfficeNumber { get; set; }

        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        public int SocialMediaTypeId { get; set; }

        [StringLength(20)]
        public string? SocialMediaType { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        [StringLength(255)]
        public string? InterestExpressed { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

    }
}

