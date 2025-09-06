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
using static System.Collections.Specialized.BitVector32;

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

        //Navigation property for Form Sections
        public ICollection<FormSections> Sections { get; private set; } = new List<FormSections>();

        // Private constructor for EF Core
        private FormTemplates() { }

        public FormTemplates(int id, int landUseId, int landUseTypeId, string name, string? description)
        {
            FormTemplateId = id;
            LandUseId = landUseId;
            LandUseTypeId = landUseTypeId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
            //Sections = new List<FormSections>();
        }

        // Domain methods
        public void UpdateTemplateDetails(int landUseId, int landUseTypeId, string name, string? description)
        {
            LandUseId = landUseId;
            LandUseTypeId = landUseTypeId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Description = description;
        }

        public void AddSection(int formSectionId, string name,int order)
        {
            var section = new FormSections(formSectionId, name, order, FormTemplateId);
            Sections.Add(section);
        }

        public void RemoveSection(int sectionId)
        {
            var section = Sections.FirstOrDefault(f => f.FormSectionId == sectionId);
            if (section != null)
            {
                Sections.Remove(section);
            }
        }

        public void ReorderSections(List<int> sectionIdsInOrder)
        {
            // Validate all section IDs belong to this template
            var validFieldIds = Sections.Select(f => f.FormSectionId).ToList();
            if (sectionIdsInOrder.Any(id => !validFieldIds.Contains(id)))
            {
                throw new InvalidOperationException("Invalid section ID provided for reordering");
            }

            // Update order based on the provided list
            for (int i = 0; i < sectionIdsInOrder.Count; i++)
            {
                var section = Sections.First(f => f.FormSectionId == sectionIdsInOrder[i]);
                section.UpdateOrder(i + 1);
            }
        }


        public FormSections? GetSectionById(int sectionId)
        {
            return Sections.FirstOrDefault(s => s.FormSectionId == sectionId);
        }

        public IEnumerable<FormFields> GetAllFields()
        {
            return Sections.SelectMany(s => s.Fields);
        }

        public FormFields? GetFieldById(int fieldId)
        {
            return Sections
                .SelectMany(s => s.Fields)
                .FirstOrDefault(f => f.FormSectionId == fieldId);
        }

    }

}

