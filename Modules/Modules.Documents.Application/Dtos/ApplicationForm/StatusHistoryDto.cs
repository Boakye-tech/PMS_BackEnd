// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/StatusHistoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:24 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record StatusHistoryDto
    {
        public int Id { get; init; }
        public required string Status { get; init; }
        public required string WorkflowState { get; init; }
        public string? Notes { get; init; }
        public DateTime ChangeDate { get; init; }
        public int FormSubmissionId { get; init; }
    }
}

