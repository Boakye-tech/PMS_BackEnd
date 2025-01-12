using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos
{
    public record CustomerDetailsDto
    {
        public required string CustomerType { get; set; }

        public required string ResidentType { get; set; }

        public required string Locality { get; set; }

        public required string CustomerCode { get; set; }

        public string? Title { get; set; }

        [StringLength(150)]
        public string? SurName { get; set; }

        [StringLength(75)]
        public string? OtherNames { get; set; }

        [StringLength(100)]
        public string? CompanyName { get; set; }

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

        [StringLength(12)]
        public required string PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string? OfficeNumber { get; set; }

        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }

        [EmailAddress]
        [StringLength(255)]
        public required string EmailAddress { get; set; }

        public string? SocialMediaType { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }
    }
}

