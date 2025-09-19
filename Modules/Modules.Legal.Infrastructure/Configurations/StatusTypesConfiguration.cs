// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/StatusTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 6:21 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Legal.Infrastructure.Configurations
{
    public class StatusTypesConfiguration : IEntityTypeConfiguration<StatusTypes>
    {
        public void Configure(EntityTypeBuilder<StatusTypes> builder)
        {
            builder.HasIndex(st => st.StatusType).IsUnique(true);

            builder.HasData(
                new StatusTypes(1, "Not Started"),
                new StatusTypes(2, "In Progress"),
                new StatusTypes(3, "On Appeal"),
                new StatusTypes(4, "Re-Open"),
                new StatusTypes(5, "Closed")
                );
        }
    }
}

