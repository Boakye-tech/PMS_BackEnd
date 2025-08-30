// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/ApplicationForm/CreateFormSubmissionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 5:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.ApplicationForm
{
    public record CreateFormSubmissionDto
    {
        [Required(ErrorMessage = "Form template ID is required")]
        public int FormTemplateId { get; init; }

        [Required(ErrorMessage = "Applicant name is required")]
        [StringLength(200, ErrorMessage = "Applicant name cannot exceed 200 characters")]
        public required string ApplicantName { get; init; }

        [Required(ErrorMessage = "Applicant email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        public required string ApplicantEmail { get; init; }

        [Required(ErrorMessage = "Property number is required")]
        [StringLength(50, ErrorMessage = "Property number cannot exceed 50 characters")]
        public required string PropertyNumber { get; init; }

        public List<FormResponseItemDto> Responses { get; init; } = new();
    }
}

