// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Configuration/StatusHistoryConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 31/08/2025 7:47 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Documents.Domain.ValueObjects;

namespace Modules.Documents.Infrastructure.Configuration
{
    public class StatusHistoryConfiguration : IEntityTypeConfiguration<StatusHistory>
    {
        public void Configure(EntityTypeBuilder<StatusHistory> builder)
        {
            builder.Property(sh => sh.Status)
                .HasConversion(
                    v => v.Value,
                    v => ApplicationStatus.FromString(v))
                .HasMaxLength(50);

            builder.Property(sh => sh.WorkflowState)
                .HasConversion(
                    v => v.Value,
                    v => WorkflowState.FromString(v))
                .HasMaxLength(50);
        }
    }
}

