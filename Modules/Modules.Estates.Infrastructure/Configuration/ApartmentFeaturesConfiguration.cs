// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/ApartmentFeaturesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/06/2025 10:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class ApartmentFeaturesConfiguration : IEntityTypeConfiguration<ApartmentFeatures>
    {
		
        public void Configure(EntityTypeBuilder<ApartmentFeatures> builder)
        {
            builder.HasIndex(af => new { af.FeaturesId, af.FloorArea })
                .IsUnique(true);

            // Configure the one-to-many relationship with features
            builder.HasMany(f => f.Features)
                   .WithOne(af => af.ApartmentFeatures)
                   .HasForeignKey(af => af.FeaturesId)
                   .OnDelete(DeleteBehavior.Restrict);


            builder.HasData(
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 1, 1, 601, 8.714m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 2, 1, 602, 9.404m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 3, 1, 603, 5.108m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 4, 1, 604, 4.200m),

                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 5, 2, 601, 9.548m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 6, 2, 602, 15.390m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 7, 2, 603, 7.260m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 8, 2, 605, 2.125m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 9, 2, 606, 1.760m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 10, 2, 604, 5.04m),

                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 11, 3, 601, 18.480m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 12, 3, 602, 18.480m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 13, 3, 603, 7.840m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 14, 3, 605, 2.520m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 15, 3, 606, 5.474m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 16, 3, 604, 7.840m),

                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 17, 4, 601, 13.316m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 18, 4, 602, 13475m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 19, 4, 603, 9.875m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 20, 4, 607, 5.900m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 21, 4, 608, 2.750m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 22, 4, 604, 6.793m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 23, 4, 610, 12.748m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 24, 4, 612, 1.968m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 25, 4, 613, 4.329m),
                new ApartmentFeatures(ApartmentCategoryEnum.AFFORDABLE, 26, 4, 614, 3.650m),


                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 27, 5, 627, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 28, 5, 628, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 29, 5, 615, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 30, 5, 616, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 31, 5, 617, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 32, 5, 618, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 33, 5, 619, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 34, 5, 607, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 35, 5, 620, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 36, 5, 621, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 37, 5, 622, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 38, 5, 611, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 39, 5, 623, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 40, 5, 624, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 41, 5, 622, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 42, 5, 609, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 43, 5, 625, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 44, 5, 626, 0),


                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 45, 6, 627, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 46, 6, 628, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 47, 6, 615, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 48, 6, 616, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 49, 6, 617, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 50, 6, 618, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 51, 6, 619, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 52, 6, 607, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 53, 6, 620, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 54, 6, 621, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 55, 6, 622, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 56, 6, 611, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 57, 6, 623, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 58, 6, 624, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 59, 6, 622, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 60, 6, 609, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 61, 6, 610, 0), 
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 62, 6, 625, 0),
                new ApartmentFeatures(ApartmentCategoryEnum.LUXURY, 63, 6, 626, 0)

            );
        }
    }
}

