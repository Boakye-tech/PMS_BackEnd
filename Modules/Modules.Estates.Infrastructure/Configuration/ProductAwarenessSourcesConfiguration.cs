// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ProductAwarenessSourcesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 21/09/2025 12:43 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class ProductAwarenessSourcesConfiguration : IEntityTypeConfiguration<ProductAwarenessSources>
    {
        public void Configure(EntityTypeBuilder<ProductAwarenessSources> builder)
        {
            builder.HasIndex(p => p.ProductAwarenessSource).IsUnique(true);

            builder.HasData(
            new ProductAwarenessSources(1, "TELEVISION"),
            new ProductAwarenessSources(2, "RADIO"),
            new ProductAwarenessSources(3, "NEWSPAPERS"),
            new ProductAwarenessSources(4, "INTERNET"),
            new ProductAwarenessSources(5, "ONLINE ADS"),
            new ProductAwarenessSources(6, "WORD OF MOUTH"),
            new ProductAwarenessSources(7, "SOCIAL MEDIA"),
            new ProductAwarenessSources(8, "TDC OFFICIAL WEBSITE"),
            new ProductAwarenessSources(9, "TDC STAFF"),
            new ProductAwarenessSources(10, "TDC CUSTOMER")

            );

        }
    }
}
