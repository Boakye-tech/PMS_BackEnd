// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormTemplates/CreateFormTemplateDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:19 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.FormTemplates
{
    public record CreateFormTemplateDto
    {
        public int LandUseId { get; set; }
        public List<int>? LandUseTypeId { get; set; }

        public required string Name { get; init; }
        public string? Description { get; init; }
        public List<CreateFormFieldDto> Fields { get; init; } = new();
        public required string CreatedBy { get; init; }
    }
}

