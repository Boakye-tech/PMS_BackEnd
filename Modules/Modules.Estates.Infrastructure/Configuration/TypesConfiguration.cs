// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/TypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:15 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Text.Json;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class TypesConfiguration : IEntityTypeConfiguration<Types>
    {
        public void Configure(EntityTypeBuilder<Types> builder)
        {
            // Configure the features array to be stored as JSON
            builder.Property(x => x.Features)
                .HasConversion(
                    v => JsonSerializer.Serialize(v, (JsonSerializerOptions)null!),
                    v => JsonSerializer.Deserialize<string[]>(v, (JsonSerializerOptions)null!)!)
                .HasColumnType("nvarchar(max)");

            builder.HasIndex(r => r.Code).IsUnique(true);

            builder.HasIndex(r => r.TypeName).IsUnique(true);

            // Configure the one-to-many relationship with rental category
            builder.HasOne(t => t.RentalCategory)
                   .WithMany()
                   .HasForeignKey(t => t.RentalCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Configure the one-to-many relationship with rental type
            builder.HasOne(t => t.RentalType)
                   .WithMany()
                   .HasForeignKey(t => t.RentalTypeId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Types(1, "BB50", "BB50 - 2 Bedroom House with Garage", 1, 3, new[] { "2 bedrooms", "1 livingRoom", "private kitchen", "private toilet", "private bath", "1 garage" }, "Spacious layout with attached garage and private kitchen."),
                new Types(2, "IRO8", "IRO8 - Single Room Low-Income Unit", 1, 1, new[] { "1 bedrooms", "shared toilet", "shared bath" }, "Affordable housing for low-income earners, shared facilities."),
                new Types(3, "RRT87", "RRT87 - 3 Bedroom Standard House", 1, 3, new[] { "3 bedrooms", "1 livingRoom", "kitchen", "private toilet", "private bath", "0 garage", "storeRoom" }, "Typical 3-bedroom family house with kitchen and living area."),
                new Types(4, "YYU9", "YYU9 - 3 Bedroom House with 2 Garages", 1, 4, new[] { "3 bedrooms", "1 livingRoom", "kitchen", "private toilet", "private bath", "2 garage", "storeRoom", "lobby" }, "Premium family house with dual garages and ample storage space."),
                new Types(5, "FLAT", "1-Bedroom Self-Contained Flat", 3, 13, new[] { "1 bedrooms", "1 livingRoom", "private kitchen", "private toilet", "private bath", "0 garage", "storeRoom" }, "Ideal for singles or couples. Compact but complete flat unit."),
                new Types(6, "A1", "A1 - Community Commercial Unit", 2, 9, new[] { "30 usableAreaSqm", "shared toilet", "shared bath", "PaidInternet" }, "Shared washroom, tiled floor, suitable for shop or office."),
                new Types(7, "B2", "B2 - Shell Commercial Unit", 2, 7, new[] { "45 usableAreaSqm" }, "Tenant to install internal partitions, ceiling, toilet. Power available."),
                new Types(8, "C3", "C3 - Serviced Office Suite", 2, 10, new[] { "25 usableAreaSqm", "shared toilet", "shared bath", "airConditioned", "internetReady", "furnished" }, "Includes reception, conference room, cleaning, utilities, WiFi. Ideal for professionals/startups."),
                new Types(9, "D4", "D4 - Retail Shop Unit", 2, 11, new[] { "35 usableAreaSqm", "private toilet", "private bath", "airConditioned", "internetReady", "furnished" }, "Tiled floor, private toilet, retail shelving, ceiling fan, lockable shutters.")

                );
        }
    }
}

