// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/UpdateFormSubmissionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:02 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record UpdateFormSubmissionDto
    {
        public required int FormSubmissionId { get; init; }

        public required string ApplicantName { get; init; }

        public required string ApplicantEmail { get; init; }

        public required string PropertyNumber { get; init; }

        public List<FormResponseItemDto> Responses { get; init; } = new();
    }

}

