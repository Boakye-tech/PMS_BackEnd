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
using Microsoft.EntityFrameworkCore;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class ApartmentFeaturesConfiguration : IEntityTypeConfiguration<ApartmentFeatures>
    {
		
        public void Configure(EntityTypeBuilder<ApartmentFeatures> builder)
        {
            //builder.HasIndex(af => new { af.FeaturesId, af.FloorArea })
            //    .IsUnique(true);


            builder
            .HasOne(af => af.Features)
            .WithMany(f => f.ApartmentFeatures)
            .HasForeignKey(af => af.FeaturesId);

            builder.HasData(
                new ApartmentFeatures(1, 1, 1, 1, 8.714m),
                new ApartmentFeatures(1, 2, 1, 2, 9.404m),
                new ApartmentFeatures(1, 3, 1, 3, 5.108m),
                new ApartmentFeatures(1, 4, 1, 4, 4.200m),

                new ApartmentFeatures(1, 5, 2, 1, 9.548m),
                new ApartmentFeatures(1, 6, 2, 2, 15.390m),
                new ApartmentFeatures(1, 7, 2, 3, 7.260m),
                new ApartmentFeatures(1, 8, 2, 5, 2.125m),
                new ApartmentFeatures(1, 9, 2, 6, 1.760m),
                new ApartmentFeatures(1, 10, 2, 4, 5.04m),

                new ApartmentFeatures(1, 11, 3, 1, 18.480m),
                new ApartmentFeatures(1, 12, 3, 2, 18.480m),
                new ApartmentFeatures(1, 13, 3, 3, 7.840m),
                new ApartmentFeatures(1, 14, 3, 5, 2.520m),
                new ApartmentFeatures(1, 15, 3, 6, 5.474m),
                new ApartmentFeatures(1, 16, 3, 4, 7.840m),

                new ApartmentFeatures(1, 17, 4, 1, 13.316m),
                new ApartmentFeatures(1, 18, 4, 2, 13475m),
                new ApartmentFeatures(1, 19, 4, 3, 9.875m),
                new ApartmentFeatures(1, 20, 4, 7, 5.900m),
                new ApartmentFeatures(1, 21, 4, 8, 2.750m),
                new ApartmentFeatures(1, 22, 4, 4, 6.793m),
                new ApartmentFeatures(1, 23, 4, 10, 12.748m),
                new ApartmentFeatures(1, 24, 4, 12, 1.968m),
                new ApartmentFeatures(1, 25, 4, 13, 4.329m),
                new ApartmentFeatures(1, 26, 4, 14, 3.650m),


                new ApartmentFeatures(2, 27, 5, 27, 0),
                new ApartmentFeatures(2, 28, 5, 28, 0),
                new ApartmentFeatures(2, 29, 5, 15, 0),
                new ApartmentFeatures(2, 30, 5, 16, 0),
                new ApartmentFeatures(2, 31, 5, 17, 0),
                new ApartmentFeatures(2, 32, 5, 18, 0),
                new ApartmentFeatures(2, 33, 5, 19, 0),
                new ApartmentFeatures(2, 34, 5, 7, 0),
                new ApartmentFeatures(2, 35, 5, 20, 0),
                new ApartmentFeatures(2, 36, 5, 21, 0),
                new ApartmentFeatures(2, 37, 5, 22, 0),
                new ApartmentFeatures(2, 38, 5, 11, 0),
                new ApartmentFeatures(2, 39, 5, 23, 0),
                new ApartmentFeatures(2, 40, 5, 24, 0),
                new ApartmentFeatures(2, 41, 5, 22, 0),
                new ApartmentFeatures(2, 42, 5, 9, 0),
                new ApartmentFeatures(2, 43, 5, 25, 0),
                new ApartmentFeatures(2, 44, 5, 26, 0),


                new ApartmentFeatures(2, 45, 6, 27, 0),
                new ApartmentFeatures(2, 46, 6, 28, 0),
                new ApartmentFeatures(2, 47, 6, 15, 0),
                new ApartmentFeatures(2, 48, 6, 16, 0),
                new ApartmentFeatures(2, 49, 6, 17, 0),
                new ApartmentFeatures(2, 50, 6, 18, 0),
                new ApartmentFeatures(2, 51, 6, 19, 0),
                new ApartmentFeatures(2, 52, 6, 7, 0),
                new ApartmentFeatures(2, 53, 6, 20, 0),
                new ApartmentFeatures(2, 54, 6, 21, 0),
                new ApartmentFeatures(2, 55, 6, 22, 0),
                new ApartmentFeatures(2, 56, 6, 11, 0),
                new ApartmentFeatures(2, 57, 6, 23, 0),
                new ApartmentFeatures(2, 58, 6, 24, 0),
                new ApartmentFeatures(2, 59, 6, 22, 0),
                new ApartmentFeatures(2, 60, 6, 9, 0),
                new ApartmentFeatures(2, 61, 6, 10, 0), 
                new ApartmentFeatures(2, 62, 6, 25, 0),
                new ApartmentFeatures(2, 63, 6, 26, 0)

            );
        }
    }
}

