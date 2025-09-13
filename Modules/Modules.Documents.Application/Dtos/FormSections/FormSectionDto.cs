// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormSections/FormSectionDto.cs
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
    public record FormSectionDto
    {
        public int FormSectionId { get; init; }
        public required string Name { get; init; }
        public int Order { get; init; }
        public List<FormFieldDto> Fields { get; init; } = new();
    }

}

