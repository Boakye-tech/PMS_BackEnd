// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Entities/FormTemplates.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/08/2025 11:32 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Modules.Documents.Domain.Entities
{
	public class FormTemplates : AuditableEntity
    {
        [Key]
        public int FormTemplateId { get; set; }

        public int LandUseId { get; set; }
        public int LandUseTypeId { get; set; }


        [Required]
        [StringLength(200)]
        public string Name { get; private set; }

        public string? Description { get; private set; }
        

        //Navigation property for Form Fields
        public ICollection<FormFields> Fields { get; set; } = new List<FormFields>();

        // Private constructor for EF Core
        private FormTemplates() { }

        public FormTemplates(int id, string name, string? description)
        {
            FormTemplateId = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            //FormsFields = new List<FormFields>();
        }

        // Domain methods
        public void UpdateDetails(string name, string? description)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
        }

        public void AddField(int formFieldId, string label, string fieldType, bool isRequired, string? options, int order)
        {
            var field = new FormFields(formFieldId, label, fieldType, isRequired, options, order, FormTemplateId);
            Fields.Add(field);
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
    }

}

