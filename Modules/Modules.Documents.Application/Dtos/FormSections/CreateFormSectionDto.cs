// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormSections/CreateFormSectionDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/09/2025 7:58 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.FormSections
{
    public record CreateFormSectionDto
    {
        [Required(ErrorMessage = "Section Name is required")]
        [StringLength(200, ErrorMessage = "Section Name cannot exceed 200 characters")]
        public required string Name { get; init; }

        public int Order { get; init; }

        public List<CreateFormFieldDto> Fields { get; init; } = new();
    }
}

