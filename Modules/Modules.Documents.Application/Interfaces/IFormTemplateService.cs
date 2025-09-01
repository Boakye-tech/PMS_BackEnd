// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Interfaces/IFormTemplateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Dtos;
using Modules.Documents.Application.Dtos.FormTemplates;

namespace Modules.Documents.Application.Interfaces
{
    public interface IFormTemplateService
    {
        //Task<FormTemplateDto> GetFormTemplateByIdAsync(int id);
        Task<List<FormTemplateDto>> GetAllFormTemplatesAsync();

        List<FormTemplateDto> GetAllFormTemplatesAsync(int id, int landUseId, int landUseTypeId, string? name);


        //Task<FormTemplateDto> CreateFormTemplateAsync(CreateFormTemplateDto createDto);
        Task<ReturnResponsesDto> CreateFormTemplateAsync(CreateFormTemplateDto createDto);
        Task<ReturnResponsesDto> UpdateFormTemplateAsync(int id, UpdateFormTemplateDto updateDto);
        Task<ReturnResponsesDto> DeleteFormTemplateAsync(int id);
        Task<bool> IsFormTemplateNameUniqueAsync(string name, int? excludeId = null);
    }
}

