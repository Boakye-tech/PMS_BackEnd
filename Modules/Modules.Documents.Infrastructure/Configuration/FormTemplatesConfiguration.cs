// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Configuration/FormTemplatesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 8:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Documents.Infrastructure.Configuration
{
    public class FormTemplatesConfiguration : IEntityTypeConfiguration<FormTemplates>
    {
        public void Configure(EntityTypeBuilder<FormTemplates> builder)
        {
            builder.HasKey(t => t.FormTemplateId);

            builder.Property(t => t.FormTemplateId)
                   .ValueGeneratedOnAdd() // important
                   .UseIdentityColumn();

            builder.HasIndex(t => t.Name)
                .IsUnique();

            builder.HasMany(t => t.Sections)
               .WithOne(f => f.FormTemplate)
               .HasForeignKey(fk => fk.FormTemplateId)
               .OnDelete(DeleteBehavior.Cascade);

            //builder.HasData(
            //    new FormTemplates(1, 3, "APPLICATION FOR PURCHASE OF A HOUSE", "Required form for initiating the house purchase process and fulfilling documentation requirements."),
            //    new FormTemplates(1, 1, "APPLICATION FOR SERVICED RESIDENTIAL PLOT", "")
            //);

        }

    }


}

