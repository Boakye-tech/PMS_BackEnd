// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Configuration/FormFieldsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:59 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Documents.Infrastructure.Configuration
{
    public class FormFieldsConfiguration : IEntityTypeConfiguration<FormFields>
    {
        public void Configure(EntityTypeBuilder<FormFields> builder)
        {

            builder.HasKey(f => f.FormFieldId);

            builder.Property(f => f.FormFieldId)
                .ValueGeneratedOnAdd() // important
                .UseIdentityColumn();


            builder.HasIndex(f => new { f.Label, f.FormSectionId, f.FormTemplateId })
                .IsUnique(true);

            builder.HasOne(f => f.FormTemplate)
                .WithMany()                 // no collection on template
                .HasForeignKey(f => f.FormTemplateId)
                .OnDelete(DeleteBehavior.Cascade);


            //builder.HasIndex(f => new { f.Label, f. })
            //    .IsUnique(true);

            // builder.HasData(
            //    new FormFields(formFieldId: 1, label: "Passport Size Photograph", fieldType: "image", isRequired: true, options: "", order: 1, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 2, label: "Full Name (Mr./Mrs./Dr/)", fieldType: "text", isRequired: true, options: "", order: 2, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 3, label: "Registered Business Address", fieldType: "text", isRequired: false, options: "", order: 3, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 4, label: "Postal Address", fieldType: "text", isRequired: true, options: "", order: 4, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 5, label: "Telephone Number", fieldType: "text", isRequired: true, options: "", order: 5, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 6, label: "Residential Address", fieldType: "text", isRequired: false, options: "", order: 6, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 7, label: "Office Number", fieldType: "text", isRequired: false, options: "", order: 7, formSectionId: 1, formTemplateId: 1),

            //    new FormFields(formFieldId: 8, label: "Email Address", fieldType: "email", isRequired: true, options: "", order: 8, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 9, label: "Nationality", fieldType: "dropdown", isRequired: true, options: "", order: 9, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 10, label: "Residential Status", fieldType: "dropdown", isRequired: true, options: "Resident,Non-Resident", order: 10, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 11, label: "Age(DOB)", fieldType: "Date", isRequired: true, options: "", order: 11, formSectionId: 1, formTemplateId: 1),
            //    new FormFields(formFieldId: 12, label: "How did you hear about our product", fieldType: "dropdown", isRequired: true, options: "Internet,TV,Radio,Customer", order: 12, formSectionId: 1, formTemplateId: 1),


            //    new FormFields(formFieldId: 13, label: "Type Of House (State Number Of Rooms)", fieldType: "text", isRequired: true, options: "", order: 13, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 14, label: "Detached", fieldType: "text", isRequired: true, options: "", order: 14, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 15, label: "Community(Locality)", fieldType: "dropdown", isRequired: true, options: "", order: 15, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 16, label: "House Number", fieldType: "text", isRequired: true, options: "", order: 16, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 17, label: "Selling Price", fieldType: "number", isRequired: true, options: "", order: 17, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 18, label: "Customer Code", fieldType: "text", isRequired: true, options: "", order: 18, formSectionId: 2, formTemplateId: 1),
            //    new FormFields(formFieldId: 19, label: "Signature of applicant", fieldType: "signature", isRequired: true, options: "", order: 19, formSectionId: 2, formTemplateId: 1)
            //);

        }
    }
}

