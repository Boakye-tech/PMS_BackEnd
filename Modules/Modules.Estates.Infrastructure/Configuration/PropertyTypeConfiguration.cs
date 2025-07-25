// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/PropertyTypeConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 5:43 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
    {
        public void Configure(EntityTypeBuilder<PropertyType> builder)
        {
            builder.HasIndex(s => s.PropertyTypeName)
                .IsUnique(true);

            builder.HasData(
                new PropertyType(1,"PLT", "PLOT"),
                new PropertyType(2, "HSE", "HOUSE"),
                new PropertyType(3, "SHO", "SHOPS & OFFICES"),
                new PropertyType(4, "APA", "APARTMENT"),
                new PropertyType(5, "RHS", "RENTAL HOUSE"),
                new PropertyType(6, "LSP", "LARGE SCALE PLOT")
                );
        }
    }
}

