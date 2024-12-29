using System;
namespace Modules.Estates.Domain.Entities.Registration
{
	public class CustomerMaster
	{
		public int CustomerMasterId { get; set; }
        public string CustomerCode { get; set; }
        public int CustomerTypeId { get; set; }
        public int ResidentTypeId { get; set; }
        public int TitleId { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public string CompanyName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string TinNumber { get; set; }
        public string Picture { get; set; }
        public int GenderId { get; set; }
        public int NationalityId { get; set; }
        public string PostalAddress { get; set; }
        public string ResidentialAddress { get; set; }
        public string DigitalAddress { get; set; }
        public string PrimaryMobileNumber { get; set; }
        public string SecondaryMobileNumber { get; set; }
        public string OfficeNumber { get; set; }
        public string WhatsAppNumber { get; set; }
        public string EmailAddress { get; set; }
        public string ResidentPermitNumber { get; set; }
        public DateTime DateIssued { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPersonPhoneNumber { get; set; }
        public int SocialMediaTypeId { get; set; }
        public string SocialMediaAccount { get; set; }
        public int IdentificationTypeId { get; set; }
        public string IdentificationTypeNumber { get; set; }
        public string IdentificationTypeImageOne { get; set; }
        public string IdentificationTypeImageTwo { get; set; }
        public string Comments { get; set; }
        public string InterestExpressed { get; set; }
        public int DebtorStatus { get; set; }
        public string ParentCode { get; set; }
        public bool IsDeleted { get; set; }


        public CustomerMaster()
		{
		}
	}
}

