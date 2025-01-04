using System;
namespace Modules.Estates.Domain.Entities.Registration
{
	public class CustomerMaster : BaseEntity
	{
        [Key]
		public int CustomerMasterId { get; set; }

        [Required]
        public int CustomerTypeId { get; set; }

        [Required]
        public int ResidentTypeId { get; set; }

        [Required]
        public int LocalityId { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        public int TitleId { get; set; }

        [StringLength(150)]
        public string SurName { get; set; }

        [StringLength(75)]
        public string OtherNames { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string TinNumber { get; set; }

        [StringLength(255)]
        public string Picture { get; set; }

        public int GenderId { get; set; }

        public int NationalityId { get; set; }

        [StringLength(255)]
        public string PostalAddress { get; set; }

        [StringLength(255)]
        public string ResidentialAddress { get; set; }

        [StringLength(50)]
        public string DigitalAddress { get; set; }

        [Required]
        [StringLength(12)]
        public string PrimaryMobileNumber { get; set; }

        [StringLength(12)]
        public string SecondaryMobileNumber { get; set; }

        [StringLength(12)]
        public string OfficeNumber { get; set; }

        [StringLength(12)]
        public string WhatsAppNumber { get; set; }

        [EmailAddress]
        [StringLength(255)]
        public string EmailAddress { get; set; }

        [StringLength(30)]
        public string ResidentPermitNumber { get; set; }

        public DateTime ResidentPermitDateIssued { get; set; }

        public DateTime ResidentPermitExpiryDate { get; set; }

        public int SocialMediaTypeId { get; set; }

        [StringLength(50)]
        public string SocialMediaAccount { get; set; }

        public int IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string IdentificationTypeImageOne { get; set; }

        [StringLength(255)]
        public string IdentificationTypeImageTwo { get; set; }

        [StringLength(255)]
        public string Comments { get; set; }

        [StringLength(255)]
        public string InterestExpressed { get; set; }

        public int DebtorStatus { get; set; }

        [StringLength(10)]
        public string ParentCode { get; set; }

        [StringLength(255)]
        public string? ContactPerson_FullName { get; set; }

        [StringLength(12)]
        public string? ContactPerson_PhoneNumber { get; set; }

        [StringLength(255)]
        [EmailAddress]
        public string? ContactPerson_EmailAddress { get; set; }

        [StringLength(12)]
        public string? ContactPerson_Address { get; set; }

        public int ContactPerson_IdentificationTypeId { get; set; }

        [StringLength(20)]
        public string? ContactPerson_IdentificationTypeNumber { get; set; }

        [StringLength(255)]
        public string? ContactPerson_IdentificationTypeImage { get; set; }

        public bool IsDeleted { get; set; }


        public CustomerMaster()
		{
		}
	}
}

