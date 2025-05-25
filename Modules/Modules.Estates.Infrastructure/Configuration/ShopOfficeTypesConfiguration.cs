// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ShopOfficeTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 12:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Text.Json;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class ShopOfficeTypesConfiguration : IEntityTypeConfiguration<ShopOfficeTypes>
    {
        public void Configure(EntityTypeBuilder<ShopOfficeTypes> builder)
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
                new ShopOfficeTypes(1, "A1", "A1 - Community Commercial Unit", 2, 9, new[] { "30 usableAreaSqm", "shared toilet", "shared bath", "PaidInternet" }, "Shared washroom, tiled floor, suitable for shop or office."),
                new ShopOfficeTypes(2, "B2", "B2 - Shell Commercial Unit", 2, 7, new[] { "45 usableAreaSqm" }, "Tenant to install internal partitions, ceiling, toilet. Power available."),
                new ShopOfficeTypes(3, "C3", "C3 - Serviced Office Suite", 2, 10, new[] { "25 usableAreaSqm", "shared toilet", "shared bath", "airConditioned", "internetReady", "furnished" }, "Includes reception, conference room, cleaning, utilities, WiFi. Ideal for professionals/startups."),
                new ShopOfficeTypes(4, "D4", "D4 - Retail Shop Unit", 2, 11, new[] { "35 usableAreaSqm", "private toilet", "private bath", "airConditioned", "internetReady", "furnished" }, "Tiled floor, private toilet, retail shelving, ceiling fan, lockable shutters.")
                );

        }
    }
}

