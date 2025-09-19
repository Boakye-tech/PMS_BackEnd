// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/ConsentTypeConfiguration.cs
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
    public class ConsentTypeConfiguration : IEntityTypeConfiguration<ConsentType>
    {
        public void Configure(EntityTypeBuilder<ConsentType> builder)
        {
            builder.HasIndex(ct => ct.ConsentTypes).IsUnique(true);

            builder.HasData(
                new ConsentType(1, "Consent to Assign"),
                new ConsentType(2, "Consent to Mortgage"),
                new ConsentType(3, "Consent to Sub-Lease"),
                new ConsentType(4, "Consent to Gift"),
                new ConsentType(5, "Consent to Vest")
                );
        }
    }
}

