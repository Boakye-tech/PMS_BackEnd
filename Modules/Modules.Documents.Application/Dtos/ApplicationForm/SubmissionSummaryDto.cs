// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/SubmissionSummaryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:03 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record SubmissionSummaryDto
    {
        public int TotalSubmissions { get; init; }
        public int DraftSubmissions { get; init; }
        public int SubmittedSubmissions { get; init; }
        public int ApprovedSubmissions { get; init; }
        public int RejectedSubmissions { get; init; }
    }
}

