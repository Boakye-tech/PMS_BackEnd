// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ApartmentCategoryConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:31 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Infrastructure.Configuration;

public class ApartmentCategoryConfiguration : IEntityTypeConfiguration<ApartmentCategory>
{
	public void Configure(EntityTypeBuilder<ApartmentCategory> builder)
	{
		builder.HasIndex(a => a.ApartmentCategoryName)
			   .IsUnique();

		// Configure the one-to-many relationship with ApartmentTypes
		builder.HasMany(a => a.ApartmentTypes)
			   .WithOne(at => at.ApartmentCategory)
			   .HasForeignKey(at => at.ApartmentCategoryId)
			   .OnDelete(DeleteBehavior.Restrict);

		builder.HasData(
			new ApartmentCategory(1, "AFFORDABLE"),
			new ApartmentCategory(2, "LUXURY"),
			new ApartmentCategory(3, "MIDRANGE")
		);
	}
}

