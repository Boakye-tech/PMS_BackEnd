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
        public static FormTemplateDto ToDto(this FormTemplates entity)
        {
            return new FormTemplateDto
            {
                Id = entity.FormTemplateId,
                Name = entity.Name,
                Description = entity.Description,
                DateCreated = DateTime.UtcNow,
                Sections = entity.Sections.Select(f => f.ToDto()).ToList()
            };
        }

        public static FormSectionDto ToDto(this FormSections entity)
        {
            return new FormSectionDto
            {
                Id = entity.FormTemplateId,
                Name = entity.Name,
                Fields = entity.Fields.Select(f => f.ToDto()).ToList()
            };
        }

        public static FormFieldDto ToDto(this FormFields entity)
        {
            return new FormFieldDto
            {
                Id = entity.FormFieldId,
                Label = entity.Label,
                FieldType = entity.FieldType,
                IsRequired = entity.IsRequired,
                Options = entity.Options,
                Order = entity.Order
            };
        }
    }

}

