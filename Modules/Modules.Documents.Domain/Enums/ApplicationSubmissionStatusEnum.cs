// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Enums/ApplicationSubmissionStatusEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 2:25 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Domain.Enums
{
    public enum ApplicationSubmissionStatusEnum
    {
        Draft = 0,
        Applied = 1,       // Customer submitted
        ProposalSent = 2,  // TDC responded with proposal
        Accepted = 3,      // Customer accepted
        OfferIssued = 4,   // Offer & right of entry sent
        Completed = 5,     // Payments done, finalized
        Submitted = 6,
        Rejected = 7
    }
}

