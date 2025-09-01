// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Configuration/FormSubmissionConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:47 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Infrastructure.Configuration
{
    public class FormSubmissionConfiguration : IEntityTypeConfiguration<ApplicationFormSubmission>
    {
        public void Configure(EntityTypeBuilder<ApplicationFormSubmission> builder)
        {
            builder.Property(s => s.Status)
                .HasConversion(
                    v => v.Value,
                    v => ApplicationStatus.FromString(v))
                .HasMaxLength(50);

            builder.Property(s => s.WorkflowState)
                .HasConversion(
                    v => v.Value,
                    v => WorkflowState.FromString(v))
            .HasMaxLength(50);

            builder.HasKey(e => e.FormSubmissionId);

            builder.Property(e => e.FormSubmissionId)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn(1000000, 1);

            builder.HasMany(t => t.Responses)
                .WithOne(f => f.FormSubmission)
                .HasForeignKey(fk => fk.FormSubmissionId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

