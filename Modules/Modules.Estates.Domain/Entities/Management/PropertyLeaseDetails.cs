// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Management/PropertyLeaseDetails.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 3:53 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Domain.Entities.Management
{
	public class PropertyLeaseDetails : AuditableEntity
	{
        public int PropertyLeaseDetailsId { get; set; }
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

        public PropertyLeaseDetails()
		{
		}
	}
}

 