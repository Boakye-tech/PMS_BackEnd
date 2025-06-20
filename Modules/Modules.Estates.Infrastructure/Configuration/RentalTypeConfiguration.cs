// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/RentalTypeConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 12:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class RentalTypeConfiguration : IEntityTypeConfiguration<RentalType>
	{
        public void Configure(EntityTypeBuilder<RentalType> builder)
        {
            //builder.HasIndex(r => r.RentalTypes).IsUnique(true);

            builder.HasData(
                new RentalType(1, 1, "LOW INCOME UNIT"), //SHORT-TERM RENTAL
                new RentalType(1, 2, "SELF-CONTAINED"),//LONG-TERM RENTAL
                new RentalType(1, 3, "STANDARD"), //
                new RentalType(1, 4, "EXECUTIVE"), //FITTED
                new RentalType(1, 5, "RENT-TO-OWN"), //FULLY-FURNISHED
                new RentalType(1, 6, "AFFORDABLE UNIT"),//SERVICED

                new RentalType(2, 7, "SHELL & CORE"),
                new RentalType(2, 8, "WARM SHELL"),
                new RentalType(2, 9, "FITTED"),
                new RentalType(2, 10, "FULLY-FURNISHED"),
                new RentalType(2, 11, "SERVICED"),

                new RentalType(3, 12, "SHORT-TERM RENTAL"), 
                new RentalType(3, 13, "LONG-TERM RENTAL"),
                new RentalType(3, 14, "FITTED"), 
                new RentalType(3, 15, "FULLY-FURNISHED"), 
                new RentalType(3, 16, "SERVICED"),

                new RentalType(4, 17, "PREFAB BLOCK"),

                new RentalType(5, 18, "RENT-TO-OWN"),
                new RentalType(5, 19, "SHORT-TERM RENTAL"),
                new RentalType(5, 20, "LONG-TERM RENTAL"),
                new RentalType(5, 21, "FULLY-FURNISHED")

                

                );
        }
    }
}

