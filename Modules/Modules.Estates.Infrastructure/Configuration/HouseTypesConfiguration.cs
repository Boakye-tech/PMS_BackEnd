// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/HouseTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 12:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Text.Json;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class HouseTypesConfiguration : IEntityTypeConfiguration<HouseTypes>
	{

        public void Configure(EntityTypeBuilder<HouseTypes> builder)
        {
            // Configure the features array to be stored as JSON
            builder.Property(x => x.Features)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
                    v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!)!)
                .HasColumnType("nvarchar(max)");

            builder.HasIndex(r => r.Code).IsUnique(true);

            builder.HasIndex(r => r.TypeName).IsUnique(true);


            builder.HasData(
                new HouseTypes(1, "BB50", "BB50 - 2 Bedroom House with Garage",1,3, new[] { "2 bedrooms", "1 livingRoom", "private kitchen", "private toilet", "private bath", "1 garage" }, "Spacious layout with attached garage and private kitchen."),
                new HouseTypes(2, "IRO8", "IRO8 - Single Room Low-Income Unit",1,1, new[] { "1 bedrooms", "shared toilet", "shared bath" }, "Affordable housing for low-income earners, shared facilities."),
                new HouseTypes(3, "RRT87", "RRT87 - 3 Bedroom Standard House",1,3, new[] { "3 bedrooms", "1 livingRoom", "kitchen", "private toilet", "private bath", "0 garage", "storeRoom" }, "Typical 3-bedroom family house with kitchen and living area."),
                new HouseTypes(4, "YYU9", "YYU9 - 3 Bedroom House with 2 Garages", 1, 4, new[] { "3 bedrooms", "1 livingRoom", "kitchen", "private toilet", "private bath", "2 garage", "storeRoom", "lobby" }, "Premium family house with dual garages and ample storage space."),
                new HouseTypes(5, "FLAT", "1-Bedroom Self-Contained Flat", 3, 13, new[] { "1 bedrooms", "1 livingRoom", "private kitchen", "private toilet", "private bath", "0 garage", "storeRoom" }, "Ideal for singles or couples. Compact but complete flat unit.")
                );
        }
    }
}

