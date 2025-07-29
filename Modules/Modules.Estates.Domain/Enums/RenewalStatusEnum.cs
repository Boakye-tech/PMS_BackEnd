// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/RenewalStatusEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/07/2025 9:56 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.Enums
{
    public enum RenewalStatusEnum
    {
        NotApplicable = 0,      // Renewal not required or applicable
        NotDue = 1,             // Lease is still active, renewal not yet due
        Due = 2,                // Renewal is due soon or past due date
        Requested = 3,          // Renewal has been requested by debtor 
        Pending = 4,            // Renewal request pending approved
        Approved = 5,           // Renewal request approved
        Rejected = 6,           // Renewal request rejected
        Renewed = 7             // Renewal completed, new lease issued
    }

}
