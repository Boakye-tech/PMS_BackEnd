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

namespace Modules.Estates.Application.DTO.Management
{
	public record CustomerMasterDto
	{
        [Key]
        public int CustomerMasterId { get; set; }
        public int CustomerTypeId { get; set; }
        public int ResidentTypeId { get; set; }
        public int LocalityId { get; set; }
        [StringLength(10)]
        [Required]
        public string? CustomerCode { get; set; }
        public int TitleId { get; set; }
        [StringLength(150)]
        public string? LastName { get; set; }
        [StringLength(50)]
        public string? MiddleName { get; set; }
        [StringLength(75)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? CompanyName { get; set; }
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
        [StringLength(12)]
        [Required]
        public string? PrimaryMobileNumber { get; set; }
        [StringLength(12)]
        public string? SecondaryMobileNumber { get; set; }
        [StringLength(12)]
        public string? OfficeNumber { get; set; }
        [StringLength(12)]
        public string? WhatsAppNumber { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [StringLength(20)]
        public string? ResidentPermitNumber { get; set; }
        public DateTime DateIssued { get; set; }
        [StringLength(255)]
        public string? ContactPerson { get; set; }
        [StringLength(12)]
        public string? ContactPersonPhoneNumber { get; set; }
        public int SocialMediaTypeId { get; set; }
        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }
        public int IdentificationTypeId { get; set; }
        [StringLength(20)]
        public string? IdentificationTypeNumber { get; set; }
        [StringLength(255)]
        public string? IdentificationTypeImageOne { get; set; }
        [StringLength(255)]
        public string? IdentificationTypeImageTwo { get; set; }
        [StringLength(255)]
        public string? Comments { get; set; }
        [StringLength(255)]
        public string? InterestExpressed { get; set; }
        public int DebtorStatus { get; set; }
        [StringLength(10)]
        public string? ParentCode { get; set; }
        public bool IsDeleted { get; set; }
    }

    public record CustomerMasterCreateDto
    {
    }

    public record CustomerMasterUpdateDto { }

    public record CustomerMasterDeleteDto { }

}

