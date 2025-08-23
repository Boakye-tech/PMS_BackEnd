// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyLeaseDetailsReadDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/08/2025 12:31 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
    public record PropertyLeaseDetailsReadDto
    {
        public int PropertyLeaseDetailsId { get; set; }
        public string? PropertyNumber { get; set; }
        public string? CustomerCode { get; set; }
        public int LeaseTypePeriodId { get; set; }
        public string? LeaseType { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTerm { get; set; }
        public DateTime LeaseExpiryDate { get; set; }
        public int MaxRenewalCount { get; set; }
        public int CurrentRenewalCount { get; set; }
        public DateTime? LastRenewalStartDate { get; set; }
        public int RenewableTerm { get; set; }
        public DateTime? LastRenewalExpiryDate { get; set; }
        public string? LeaseStatus { get; set; }
        public string? RenewalStatus { get; set; }

        public string RemainingDays
        {
            get
            {
                if (LeaseExpiryDate.Date <= DateTime.UtcNow.Date)
                    return "Expired";

                DateTime today = DateTime.UtcNow.Date;
                DateTime end = LeaseExpiryDate.Date;

                int years = end.Year - today.Year;
                int days;

                // If the end date’s month/day hasn’t been reached yet this year, subtract one year
                if (end < today.AddYears(years))
                {
                    years--;
                }

                // Now calculate remaining days after subtracting full years
                DateTime anniversary = today.AddYears(years);
                days = (end - anniversary).Days;

                return $"{years} yrs {days} days";
            }
        }

    }
}

