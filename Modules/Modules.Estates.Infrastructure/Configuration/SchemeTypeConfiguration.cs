// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/SchemeTypeConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:13 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class SchemeTypeConfiguration : IEntityTypeConfiguration<SchemeType>
    {
		
        public void Configure(EntityTypeBuilder<SchemeType> builder)
        {
            builder.HasIndex(s => s.SchemeTypeName)
              .IsUnique(true);

            builder.HasData(
                new SchemeType(1, "TDC HOUSE OWNERHISP SCHEME"),
                new SchemeType(2, "KPONE AFFORDABLE HOUSE OWNERHISP SCHEME"),
                new SchemeType(3, "RENTAL HOUSE OWNERHISP SCHEME")

                );
        }
    }
}

