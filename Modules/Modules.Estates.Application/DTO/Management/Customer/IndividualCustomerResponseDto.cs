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
    public record IndividualCustomerResponseDto
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
        public required string? CustomerCode { get; set; }

        public int TitleId { get; set; }

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

        [StringLength(255)]
        public string? Comments { get; set; }

        public string? DebtorStatus { get; set; }

    }

    public record IndividualResidentCustomerResponseDto : IndividualCustomerResponseDto
    {
        public IndividualNonResidentCustomerResponseDto? NonResident { get; set; }
        public IndividualExpatriateCustomerResponseDto? Expatriate { get; set; }

    }

    public record IndividualNonResidentCustomerResponseDto 
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

    public record IndividualExpatriateCustomerResponseDto 
    {
        [StringLength(30)]
        public string? ResidentPermitNumber { get; set; }

        public DateTime? ResidentPermitDateIssued { get; set; }

        public DateTime? ResidentPermitExpiryDate { get; set; }
    }


}

