// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.CustomerDetails
{
    public record CustomerDetailsReadDto
    {
        public string? CustomerType { get; set; }

        public string? ResidentType { get; set; }

        public string? Locality { get; set; }

        public string? CustomerCode { get; set; }

        public string? CustomerName { get; set; }

        public string? Picture { get; set; }

        public string? Gender { get; set; }

        public string? Nationality { get; set; }

        public string? PostalAddress { get; set; }

        public string? ResidentialAddress { get; set; }

        public string? DigitalAddress { get; set; }

        public string? PrimaryMobileNumber { get; set; }

        public string? SecondaryMobileNumber { get; set; }

        public string? OfficeNumber { get; set; }

        public string? WhatsAppNumber { get; set; }

        [EmailAddress]
        public string? EmailAddress { get; set; }

        public string? SocialMediaType { get; set; }

        public string? SocialMediaAccount { get; set; }
    }
}

