// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/SitesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 11:48 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class SitesConfiguration : IEntityTypeConfiguration<Sites>
	{
        public void Configure(EntityTypeBuilder<Sites> builder)
        {
            builder.HasIndex(s => new { s.LocalityId, s.SiteName })
                .IsUnique(true);

            builder.HasData(
                new Sites(1, 1, "SITE 3"),
                new Sites(1, 2, "SITE 5"),
                new Sites(1, 3, "SITE 7"),
                new Sites(2, 4, "SITE 3"),
                new Sites(2, 5, "TOWERS")
                );
        }
    }
}

