// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Extensions/FormTemplateMapper.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/08/2025 12:36 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Application.Dtos.FormTemplates;
using Modules.Documents.Domain.Entities;

namespace Modules.Documents.Application.Extensions
{
    public static class FormTemplateMapper
    {
        public static async Task<FormTemplateDto> ToDtoAsync(this FormTemplates entity, IDropdownDataSourceService dataSourceService)
        {
            return new FormTemplateDto
            {
                FormTemplateId = entity.FormTemplateId,
                Name = entity.Name,
                Description = entity.Description,
                CreatedBy = entity.CreatedBy,
                DateCreated = entity.DateCreated,
                Sections = await Task.WhenAll(entity.Sections.OrderBy(f => f.Order).Select(f => f.ToDtoAsync(dataSourceService))).ContinueWith(t => t.Result.ToList())
            };
        }

        public static async Task<FormSectionDto> ToDtoAsync(this FormSections entity, IDropdownDataSourceService dataSourceService)
        {
            return new FormSectionDto
            {
                FormSectionId = entity.FormSectionId,
                Name = entity.Name!,
                Order = entity.Order,
                Fields = await Task.WhenAll(entity.Fields.OrderBy(f => f.Order).Select(f => f.ToDtoAsync(dataSourceService))).ContinueWith(t => t.Result.ToList())
            };
        }

        public static async Task<FormFieldDto> ToDtoAsync(this FormFields entity, IDropdownDataSourceService dataSourceService)
        {
            if (entity.FieldType.Equals("dropdown", StringComparison.OrdinalIgnoreCase) && !string.IsNullOrWhiteSpace(entity.Options))
            {
                //var optionsList = string.IsNullOrWhiteSpace(entity.Options) ? new List<DropdownOptionDto>() : entity.Options.Split(',')
                //    .Select((opt, index) => new DropdownOptionDto(optionsFieldId: index + 1, optionsFieldName: opt.Trim())).ToList();

                var optionsList = await dataSourceService.GetOptionsAsync(entity.Options);

                return new FormFieldDto
                {
                    FormFieldId = entity.FormFieldId,
                    Label = entity.Label,
                    FieldType = entity.FieldType,
                    IsRequired = entity.IsRequired,
                    Options = optionsList,
                    Order = entity.Order
                };
            }

            return new FormFieldDto
            {
                FormFieldId = entity.FormFieldId,
                Label = entity.Label,
                FieldType = entity.FieldType,
                IsRequired = entity.IsRequired,
                Options = null,// entity.Options,
                Order = entity.Order
            };
        }
    }

}

