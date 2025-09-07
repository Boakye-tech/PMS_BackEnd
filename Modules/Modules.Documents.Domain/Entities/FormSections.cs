// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/FormSection.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/09/2025 6:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Documents.Domain.Entities;
using System.Linq;
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

// Domain/Entities/FormSection.cs
namespace Modules.Documents.Domain.Entities
{
    public class FormSections : AuditableEntity
    {
        [Key]
        public int FormSectionId { get; set; }

        [Required]
        [StringLength(200)]
        public string? Name { get; private set; }

        public int Order { get; private set; }

        public int FormTemplateId { get; private set; }

        // Navigation properties
        public FormTemplates FormTemplate { get; private set; }

        public ICollection<FormFields> Fields { get; private set; } = new List<FormFields>();

        // Private constructor for EF Core
        private FormSections() { }

        public FormSections(string? name, int order, int formTemplateId) //int formSectionId, 
        {
            //FormSectionId = formSectionId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Order = order;
            FormTemplateId = formTemplateId;
        }

        // Domain methods
        public void UpdateDetails(string name, int order)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Order = order;
        }

        //public void AddField(string label, string fieldType, bool isRequired, string? options, int order)
        //{
        //    var field = new FormFields(0,label, fieldType, isRequired, options, order, FormTemplateId);
        //    _fields.Add(field);
        //}



        //public void AddField(string label, string fieldType, bool isRequired, string? options, int order) //int formFieldId, 
        //{

        //    var field = new FormFields(label, fieldType, isRequired, options, order, FormSectionId); //formFieldId, FormTemplateId

        //    // hook relationships
        //    field.LinkToSection(this);
        //    field.LinkToTemplate(FormTemplateId);

        //    field.GetType()
        //        .GetProperty(nameof(FormFields.FormSectionId))!
        //        .SetValue(field, FormSectionId);

        //    Fields.Add(field);
        //}

        public FormFields AddField(string label, string fieldType, bool isRequired, string? options, int order) //int formFieldId, 
        {

            var field = new FormFields(label, fieldType, isRequired, options, order, FormSectionId); //formFieldId, FormTemplateId

            // hook relationships
            //field.LinkToSection(this);
            //field.LinkToTemplate(FormTemplateId);

            field.SetTemplateAndSection(FormTemplateId, FormSectionId);
            Fields.Add(field);
            return field;
        }

        public void RemoveField(int fieldId)
        {
            var field = Fields.FirstOrDefault(f => f.FormFieldId == fieldId);
            if (field != null)
            {
                Fields.Remove(field);
            }
        }

        public void ReorderFields(List<int> fieldIdsInOrder)
        {
            // Validate all field IDs belong to this template
            var validFieldIds = Fields.Select(f => f.FormFieldId).ToList();
            if (fieldIdsInOrder.Any(id => !validFieldIds.Contains(id)))
            {
                throw new InvalidOperationException("Invalid field ID provided for reordering");
            }

            // Update order based on the provided list
            for (int i = 0; i < fieldIdsInOrder.Count; i++)
            {
                var field = Fields.First(f => f.FormFieldId == fieldIdsInOrder[i]);
                field.UpdateOrder(i + 1);
            }
        }

        public void UpdateOrder(int order)
        {
            Order = order;
        }

        public FormFields? GetFieldById(int fieldId)
        {
            return Fields.FirstOrDefault(f => f.FormFieldId == fieldId);
        }

        public void UpdateField(int fieldId, string label, string fieldType, bool isRequired, string? options, int order)
        {
            var field = GetFieldById(fieldId);
            if (field == null)
            {
                throw new InvalidOperationException($"Field with ID {fieldId} not found in template {fieldId}.");
            }

            field.UpdateDetails(label, fieldType, isRequired, options);
            field.UpdateOrder(order);
        }


    }
}


