// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Dtos/FormFields/CreateFormFieldDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 2:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Application.Dtos.FormFields
{
    public record CreateFormFieldDto
    {
        public required string Label { get; init; }
        public required string FieldType { get; init; }
        public bool IsRequired { get; init; }
        public string? Options { get; init; }
        public int Order { get; init; }
    }
}

