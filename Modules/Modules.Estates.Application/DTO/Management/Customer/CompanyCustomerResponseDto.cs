﻿// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
    public record CompanyCustomerResponseDto
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

        [StringLength(100)]
        public string? CompanyName { get; set; }

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

        public int NationalityId { get; set; }

        public string? Nationality { get; set; }

        [StringLength(20)]
        public string? TinNumber { get; set; }

        [StringLength(255)]
        public string? Picture { get; set; }

        public int SocialMediaTypeId { get; set; }

        public string? SocialMediaType { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }

        public string[]? IdentificationImages { get; set; }

        public string? DebtorStatus { get; set; }

        [StringLength(255)]
        public string? Comments { get; set; }

        public CompanyContactPersonResponseDto? ContactPerson { get; set; }

    }

    public record CompanyContactPersonResponseDto
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

        public string? ContactPerson_IdentificationType { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        public string[]? ContactPerson_IdentificationImages { get; set; }
    }
}

