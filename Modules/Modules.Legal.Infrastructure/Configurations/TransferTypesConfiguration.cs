// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/TransferTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 6:20 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Legal.Infrastructure.Configurations
{
    public class TransferTypesConfiguration : IEntityTypeConfiguration<TransferTypes>
    {
        public void Configure(EntityTypeBuilder<TransferTypes> builder)
        {
            builder.HasIndex(tt => tt.TransferType).IsUnique(true);

            builder.HasData(
                new TransferTypes(1, "Full Transfer"),
                new TransferTypes(2, "Partial Transfer"),
                new TransferTypes(3, "Semi Transfer")
                );
        }
    }
}

