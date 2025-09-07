// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormTemplates/UpdateFormTemplateDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:23 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Documents.Application.Dtos.FormTemplates
{
    public record UpdateFormTemplateDto
    {
        public int FormTemplateId { get; set; }
        public int LandUseId { get; set; }
        public string? LandUseTypeId { get; set; }
        public required string Name { get; init; }
        public string? Description { get; init; }
        //public List<FormFieldDto> Fields { get; init; } = new();
        public List<FormSectionDto> Sections { get; init; } = new();
        public string? modifiedBy { get; init; }

    }
}

