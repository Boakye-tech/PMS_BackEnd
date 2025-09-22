// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Management/AppliedPenalty.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 2:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Finance.Domain.Entities.Setup;
using Modules.Finance.Domain.Enums;

namespace Modules.Finance.Domain.Entities.Management
{
	public class AppliedPenalty
	{
        public int Id { get; set; }
        public int LeaseId { get; set; }
        public int PenaltyRuleId { get; set; }
        public int? InvoiceId { get; set; }
        public DateTime OriginalDueDate { get; set; }
        public decimal Amount { get; set; }
        public DateTime PeriodStart { get; set; }
        public DateTime PeriodEnd { get; set; }
        public DateTime AppliedDate { get; set; }
        public string Notes { get; set; } = string.Empty;
        public PenaltyStatus Status { get; set; }

        // Navigation properties
        public PenaltyRule PenaltyRule { get; set; } = null!;
        //public Lease Lease { get; set; } = null!;
        public Invoice? Invoice { get; set; }

        public AppliedPenalty()
		{
		}
	}
}

