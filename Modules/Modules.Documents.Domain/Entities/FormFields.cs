// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/FormFields.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/08/2025 11:32 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Documents.Domain.Entities
{
	public class FormFields : AuditableEntity
	{
        [Key]
        public int FormFieldId { get; set; }

        [Required]
        [StringLength(150)]
        public string Label { get; private set; }

        [Required]
        [StringLength(20)]
        public string FieldType { get; private set; }

        public bool IsRequired { get; private set; }
        public string? Options { get; private set; }

        [Required]
        public int Order { get; private set; }

        // Foreign keys
        [Required]
        public int FormSectionId { get; private set; }

        [Required]
        public int FormTemplateId { get; private set; }

        // Navigation properties
        //public FormSections FormSection { get; private set; } = null!;
        //public FormTemplates FormTemplate { get; private set; } = null!;

        public virtual FormSections FormSection { get; set; }
        public virtual FormTemplates FormTemplate { get; set; } 


        // Private constructor for EF Core
        private FormFields() { }

        public FormFields(int formFieldId, string label, string fieldType, bool isRequired, string? options, int order,int formSectionId , int formTemplateId)
        {
            FormFieldId = formFieldId;
            Label = label ?? throw new ArgumentNullException(nameof(label));
            FieldType = fieldType ?? throw new ArgumentNullException(nameof(fieldType));
            IsRequired = isRequired;
            Options = options;
            Order = order;
            FormSectionId = formSectionId;
            FormTemplateId = formTemplateId;
        }

        // Domain methods
        public void UpdateDetails(string label, string fieldType, bool isRequired, string? options)
        {
            Label = label ?? throw new ArgumentNullException(nameof(label));
            FieldType = fieldType ?? throw new ArgumentNullException(nameof(fieldType));
            IsRequired = isRequired;
            Options = options;
        }

        public void UpdateOrder(int order)
        {
            Order = order;
        }


        //public FormFields? GetFieldById(int fieldId)
        //{
        //    return _fields.FirstOrDefault(f => f.Id == fieldId);
        //}

        //public void UpdateField(int fieldId, string label, string fieldType, bool isRequired, string? options, int order)
        //{
        //    var field = GetFieldById(fieldId);
        //    if (field == null)
        //    {
        //        throw new InvalidOperationException($"Field with ID {fieldId} not found in template {fieldId}.");
        //    }

        //    field.UpdateDetails(label, fieldType, isRequired, options);
        //    field.UpdateOrder(order);
        //}




    }
}

