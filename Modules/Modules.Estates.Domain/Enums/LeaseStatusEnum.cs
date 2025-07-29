// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/LeaseStatusEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/07/2025 9:55 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.Enums
{
    public enum LeaseStatusEnum
    {
        Draft = 1,              // Lease created but not yet submitted
        Submitted = 2,          // Submitted for review
        Approved = 3,           // Approved and active
        Active = 4,             // Currently in effect
        Terminated = 5,         // Lease ended early by cancellation
        Expired = 6,            // Lease naturally expired after end date
        Suspended = 7,          // Temporarily on hold (e.g., due to disputes or legal action)
        PendingRenewal = 8,     // Lease expired pending renewal
        FinalExpired = 9        // Lease renewals have been exhausted
    }

}

