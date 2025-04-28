// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerDetails
	{
        [Key]
        public int CustomerMasterId { get; set; }

        [Required]
        public string? CustomerType { get; set; }

        [Required]
        public string? ResidentType { get; set; }

        [Required]
        public string? Locality { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(200)]
        public string? CustomerName { get; set; }

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
        [StringLength(255)]
        public string? EmailAddress { get; set; }

        public string? SocialMediaType { get; set; }

        [StringLength(50)]
        public string? SocialMediaAccount { get; set; }




        public CustomerDetails()
		{
		}

        public CustomerDetails(int customerMasterId, string customerType, string residentType, string locality, string customerCode, string customerName, string picture, string gender, string nationality, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber,
            string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string socialMediaType, string socialMediaAccount)
        {

        }

        public static CustomerDetails AddCustomerDetails(int customerMasterId, string customerType, string residentType, string locality, string customerCode, string customerName, string picture, string gender, string nationality, string postalAddress, string residentialAddress, string digitalAddress, string primaryMobileNumber,
            string secondaryMobileNumber, string officeNumber, string whatsAppNumber, string emailAddress, string socialMediaType, string socialMediaAccount)
        {
            if (string.IsNullOrWhiteSpace(customerType) || string.IsNullOrWhiteSpace(residentType) || string.IsNullOrWhiteSpace(locality) || string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(primaryMobileNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Invalid customer details data.");
            }


            if (string.IsNullOrWhiteSpace(customerType))
            {
                throw new ArgumentException("Customer type must not be null or empty.");
            }

            if ( string.IsNullOrWhiteSpace(residentType))
            {
                throw new ArgumentException("Resident type must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(locality))
            {
                throw new ArgumentException("Locality must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerCode))
            {
                throw new ArgumentException("Customer code must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentException("Customer name must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(primaryMobileNumber))
            {
                throw new ArgumentException("Mobile number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(emailAddress))
            {
                throw new ArgumentException("Customer email address must not be null or empty.");
            }

            return new CustomerDetails
            {
                CustomerMasterId = customerMasterId,
                CustomerType = customerType,
                ResidentType = residentType,
                Locality = locality,
                CustomerCode = customerCode,
                CustomerName = customerName,
                Picture = picture,
                Gender = gender,
                Nationality = nationality,
                PostalAddress = postalAddress,
                ResidentialAddress = residentialAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                SocialMediaType = socialMediaType,
                SocialMediaAccount = socialMediaAccount
            };
        }


	}
}

