// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/UpdateFormSubmissionStatusDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record UpdateFormSubmissionStatusDto
    {
        public required int FormSubmissionId { get; init; }

        public required string Status { get; init; }

        public required string WorkflowState { get; init; }

        public string? Notes { get; init; }
    }
}

