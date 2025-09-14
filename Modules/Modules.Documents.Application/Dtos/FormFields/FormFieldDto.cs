// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormFields/FormFieldDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:24 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Text.Json.Serialization;

namespace Modules.Documents.Application.Dtos.FormFields
{
    public record DropdownOptionDto(int value, string text);


    public record FormFieldDto
    {
        public int FormFieldId { get; init; }

        public required string Label { get; init; }

        public required string FieldType { get; init; }

        public bool IsRequired { get; init; }

        [property: JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public List<DropdownOptionDto>? Options { get; init; }

        public int Order { get; init; }
    }
}

