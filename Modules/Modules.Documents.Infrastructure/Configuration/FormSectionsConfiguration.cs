// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Configuration/FormSectionsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/09/2025 8:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Documents.Infrastructure.Configuration
{
	public class FormSectionsConfiguration : IEntityTypeConfiguration<FormSections>
    {

        public void Configure(EntityTypeBuilder<FormSections> builder)
        {
            //throw new NotImplementedException();

            builder.HasMany(s => s.Fields)
                .WithOne(f => f.FormSection)
                .HasForeignKey(f => f.FormSectionId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new FormSections(1, "A. PARTICULARS OF APPLICANT", 1, 1),
                new FormSections(2, "B. PARTICULARS OF PROPERTY REQUIRED", 2, 1)
            );


        }
    }
}

