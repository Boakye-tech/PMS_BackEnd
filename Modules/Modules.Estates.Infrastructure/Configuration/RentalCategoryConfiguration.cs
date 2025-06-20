// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/RentalCategoryConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 23/05/2025 12:01 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class RentalCategoryConfiguration : IEntityTypeConfiguration<RentalCategory>
	{

        public void Configure(EntityTypeBuilder<RentalCategory> builder)
        {
            builder.HasIndex(r => r.RentalCategories).IsUnique(true);


            // Configure the one-to-many relationship with RentalTypes
            builder.HasMany(a => a.RentalTypes)
                   .WithOne(at => at.RentalCategory)
                   .HasForeignKey(at => at.RentalCategoryId)
                   .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                new RentalCategory(1, "HOUSE"),
                new RentalCategory(2, "SHOP/OFFICE"),
                new RentalCategory(3, "FLAT"),
                new RentalCategory(4, "PREFAB"),
                new RentalCategory(5, "APARTMENTS")
                );
        }

    }


}
