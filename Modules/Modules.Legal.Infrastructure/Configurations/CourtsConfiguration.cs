// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/CourtsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 6:17 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Legal.Infrastructure.Configurations
{
    public class CourtsConfiguration : IEntityTypeConfiguration<Courts>
    {
        public void Configure(EntityTypeBuilder<Courts> builder)
        {
            builder.HasIndex(c => c.CourtType).IsUnique(true);

            builder.HasData(
                new Courts(1, "SUPREME COURT"),
                new Courts(2, "COURT OF APPEAL"),
                new Courts(3, "HIGH COURT"),
                new Courts(4, "CIRCUIT COURT"),
                new Courts(5, "DISTRICT COURT")
                );
        }
    }
}

