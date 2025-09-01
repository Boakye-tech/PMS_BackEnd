// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/FormSubmissionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 4:59 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Dtos.FormTemplates;
using Modules.Documents.Domain.Entities;
using Modules.Documents.Domain.Enums;

namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record FormSubmissionDto
    {
        public int FormSubmissionId { get; init; }
        public int FormTemplateId { get; init; }
        public required string ApplicantName { get; init; }
        public required string ApplicantEmail { get; init; }
        public required string PropertyNumber { get; init; }
        public required string Status { get; init; }
        public required string WorkflowState { get; init; }
        public DateTime SubmittedDate { get; init; }
        public DateTime CreatedDate { get; init; }
        public DateTime LastStatusChangeDate { get; init; }
        public string? StatusNotes { get; init; }
        public List<FormResponseDto> Responses { get; init; } = new();
        public List<StatusHistoryDto> StatusHistory { get; init; } = new ();
        public FormTemplateDto? Template { get; init; }
    }
}

