// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Interfaces/IFormSubmissionService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 4:56 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.ApplicationForm;
using Modules.Documents.Domain.Enums;

namespace Modules.Documents.Application.Interfaces
{
	public interface IFormSubmissionService
    {
        Task<SubmissionSummaryDto> GetSubmissionSummaryAsync();
        Task<FormSubmissionDto> GetSubmissionByIdAsync(int id);
        Task<List<FormSubmissionDto>> GetSubmissionsByTemplateAsync(int templateId);

        Task<ReturnResponsesDto> CreateSubmissionAsync(CreateFormSubmissionDto createDto);
        Task<ReturnResponsesDto> UpdateSubmissionAsync(int id, UpdateFormSubmissionDto updateDto);
        Task<ReturnResponsesDto> SubmitSubmissionAsync(int id);
        Task<ReturnResponsesDto> UpdateSubmissionStatusAsync(UpdateFormSubmissionStatusDto values);
        Task DeleteSubmissionAsync(int id);
        
    }
}

