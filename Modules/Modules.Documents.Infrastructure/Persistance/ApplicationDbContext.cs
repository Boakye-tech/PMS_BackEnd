// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Persistance/ApplicationDbContext.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 1:48 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Http.Internal;
using Modules.Documents.Domain.Common;
using Modules.Documents.Domain.Entities;

namespace Modules.Documents.Infrastructure.Persistance
{
	public class ApplicationDbContext : ModuleDbContext
    {
        protected override string Schema => "doc";

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //29 Aug, 2025
        public DbSet<FormTemplates> FormTemplates { get; set; }
        public DbSet<FormFields> FormFields { get; set; }

        //30 Aug, 2025
        public DbSet<ApplicationFormSubmission> ApplicationFormSubmission { get; set; }
        public DbSet<ApplicationFormResponse> ApplicationFormResponse { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<BaseEvent>();

            //set custom schema
            modelBuilder.HasDefaultSchema("doc");

            modelBuilder.Entity<FormTemplates>()
                .HasMany(t => t.Fields)
                .WithOne(f => f.FormTemplate)
                .HasForeignKey(fk => fk.FormTemplateId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<FormTemplates>().HasData(
                new FormTemplates(1, "APPLICATION FOR PURCHASE OF A HOUSE", "Required form for initiating the house purchase process and fulfilling documentation requirements."),
                new FormTemplates(2, "APPLICATION FOR SERVICED RESIDENTIAL PLOT","")
            );


            modelBuilder.Entity<FormFields>().HasData(
                new FormFields(formFieldId: 1, label: "Passport Size Photograph", fieldType: "image", isRequired: true, options: "", order: 1, formTemplateId: 1),
                new FormFields(formFieldId: 2, label: "Full Name (Mr./Mrs./Dr/)", fieldType: "text", isRequired: true, options: "", order: 2, formTemplateId: 1),
                new FormFields(formFieldId: 3, label: "Registered Business Address", fieldType: "text", isRequired: false, options: "", order: 3, formTemplateId: 1),
                new FormFields(formFieldId: 4, label: "Postal Address", fieldType: "text", isRequired: true, options: "", order: 4, formTemplateId: 1),
                new FormFields(formFieldId: 5, label: "Telephone Number", fieldType: "text", isRequired: true, options: "", order: 5, formTemplateId: 1),
                new FormFields(formFieldId: 6, label: "Residential Address", fieldType: "text", isRequired: false, options: "", order: 6, formTemplateId: 1),
                new FormFields(formFieldId: 7, label: "Office Number", fieldType: "text", isRequired: false, options: "", order: 7, formTemplateId: 1),

                new FormFields(formFieldId: 8, label: "Email Address", fieldType: "email", isRequired: true, options: "", order: 8, formTemplateId: 1),
                new FormFields(formFieldId: 9, label: "Nationality", fieldType: "dropdown", isRequired: true, options: "", order: 9, formTemplateId: 1),
                new FormFields(formFieldId: 10, label: "Residential Status", fieldType: "dropdown", isRequired: true, options: "Resident,Non-Resident", order: 10, formTemplateId: 1),
                new FormFields(formFieldId: 11, label: "Age(DOB)", fieldType: "Date", isRequired: true, options: "", order: 11, formTemplateId: 1),
                new FormFields(formFieldId: 12, label: "How did you hear about our product", fieldType: "dropdown", isRequired: true, options: "Internet,TV,Radio,Customer", order: 12, formTemplateId: 1),


                new FormFields(formFieldId: 13, label: "Type Of House (State Number Of Rooms)", fieldType: "text", isRequired: true, options: "", order: 13, formTemplateId: 1),
                new FormFields(formFieldId: 14, label: "Detached", fieldType: "text", isRequired: true, options: "", order: 14, formTemplateId: 1),
                new FormFields(formFieldId: 15, label: "Community(Locality)", fieldType: "dropdown", isRequired: true, options: "", order: 15, formTemplateId: 1),
                new FormFields(formFieldId: 16, label: "House Number", fieldType: "text", isRequired: true, options: "", order: 16, formTemplateId: 1),
                new FormFields(formFieldId: 17, label: "Selling Price", fieldType: "number", isRequired: true, options: "", order: 17, formTemplateId: 1),
                new FormFields(formFieldId: 18, label: "Customer Code", fieldType: "text", isRequired: true, options: "", order: 18, formTemplateId: 1),
                new FormFields(formFieldId: 19, label: "Signature of applicant", fieldType: "signature", isRequired: true, options: "", order: 19, formTemplateId: 1)
            );


            modelBuilder.Entity<ApplicationFormSubmission>(entity =>
            {
                entity.HasKey(e => e.FormSubmissionId);

                entity.Property(e => e.FormSubmissionId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1000000, 1);
            });

            modelBuilder.Entity<ApplicationFormSubmission>()
                .HasMany(t => t.Responses)
                .WithOne(f => f.FormSubmission)
                .HasForeignKey(fk => fk.FormSubmissionId)
                .OnDelete(DeleteBehavior.Restrict);

        }


    }

}

