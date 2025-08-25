// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Infrastructure/Configuration/ItemsCategoryConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 02/07/2025 9:33 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Facilities.Infrastructure.Configuration
{
	public class ItemsCategoryConfiguration : IEntityTypeConfiguration<ItemsCategory>
	{

        public void Configure(EntityTypeBuilder<ItemsCategory> builder)
        {
            builder.HasIndex(ic => ic.ItemCategoryName)
               .IsUnique();


            // Configure the one-to-many relationship with items
            builder.HasMany(i => i.Items)
                   .WithOne(ic => ic.ItemCategory)
                   .HasForeignKey(ic => ic.ItemCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);


            //builder.HasData(
            //    new ItemsCategory(1, "WASHROOM CONSUMABLES"),
            //    new ItemsCategory(2, "CLEANING SUPPLIES"),
            //    new ItemsCategory(3, "CLEANING TOOLS")
            //);
        }
    }
}

