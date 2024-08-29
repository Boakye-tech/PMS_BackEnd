// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/ValueObjects/FieldType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 12:12 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Domain.ValueObjects
{
    public record FieldType
    {
        public static readonly FieldType Text = new("Text");
        public static readonly FieldType Number = new("Number");
        public static readonly FieldType Email = new("Email");
        public static readonly FieldType Tel = new("Tel");
        public static readonly FieldType Date = new("Date");
        public static readonly FieldType Dropdown = new("Dropdown");
        public static readonly FieldType Checkbox = new("Checkbox");
        public static readonly FieldType Signature = new("Signature");

        public string Value { get; }

        private FieldType(string value) => Value = value;

        public static FieldType FromString(string value)
        {
            return value?.ToLower() switch
            {
                "text" => Text,
                "number" => Number,
                "email" => Email,
                "tel" => Tel,
                "date" => Date,
                "dropdown" => Dropdown,
                "checkbox" => Checkbox,
                "signature" => Signature,
                _ => throw new ArgumentException($"Invalid field type: {value}")
            };
        }

        public override string ToString() => Value;
    }
}

