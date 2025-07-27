// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/PropertyLeaseDetailsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:17 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
	public class PropertyLeaseDetailsDto
	{
        public string PropertyNumber { get; set; }
        public string CustomerCode { get; set; }
        public int LeaseTypePeriodId { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTermMonths { get; set; }
        public int RenewableTermMonths { get; set; }
        public int MaxRenewalCount { get; set; }
        public int CurrentRenewalCount { get; set; }
        public DateTime LastRenewalStartDate { get; set; }
        public int LeaseStatusId { get; set; }
        public int RenewalStatusId { get; set; }
        public int PaymentFrequencyId { get; set; }

        public PropertyLeaseDetailsDto()
		{
		}
	}


    public class PropertyLeaseDetailsReadDto
    {
        public string PropertyNumber { get; set; }
        public string CustomerCode { get; set; }
        public string LeaseTypePeriod { get; set; }
        public DateTime LeaseStartDate { get; set; }
        public int LeaseTermMonths { get; set; }
        public int RenewableTermMonths { get; set; }
        public int MaxRenewalCount { get; set; }
        public int CurrentRenewalCount { get; set; }
        public DateTime LastRenewalStartDate { get; set; }
        public string LeaseStatus { get; set; }
        public string RenewalStatus { get; set; }
        public string PaymentFrequency { get; set; }

    }
}

