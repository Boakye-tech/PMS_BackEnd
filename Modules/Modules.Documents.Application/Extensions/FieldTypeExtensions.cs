// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/Extensions/FieldTypeExtensions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 10:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Application.Extensions
{
    public static class FieldTypeExtensions
    {
        public static FieldTypeResponse ToResponse(this FieldType fieldType)
        {
            return new FieldTypeResponse(fieldType.Value, GetDisplayName(fieldType)); 
        }

        private static string GetDisplayName(FieldType fieldType)
        {
            return fieldType.Value switch
            {
                "Text" => "Text Input",
                "Number" => "Number Input",
                "Email" => "Email Address",
                "Date" => "Date Picker",
                "Dropdown" => "Dropdown List",
                "Checkbox" => "Checkbox",
                "Signature" => "Signature Pad",
                _ => fieldType.Value
            };
        }
    }
}

