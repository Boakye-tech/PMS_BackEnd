using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerDetails
	{
        [Key]
        public int CustomerMasterId { get; set; }

        [Required]
        public string CustomerType { get; set; }

        [Required]
        public string ResidentType { get; set; }

        [Required]
        public string Locality { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        public string Title { get; set; }

        [StringLength(150)]
        public string SurName { get; set; }

        [StringLength(75)]
        public string OtherNames { get; set; }

        [StringLength(100)]
        public string CompanyName { get; set; }

        [StringLength(255)]
        public string Picture { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

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

        public string SocialMediaType { get; set; }

        [StringLength(50)]
        public string SocialMediaAccount { get; set; }




        public CustomerDetails()
		{
		}
	}
}

