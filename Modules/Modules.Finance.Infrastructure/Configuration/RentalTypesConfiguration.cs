// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/RentalTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:39 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
	public class RentalTypesConfiguration : IEntityTypeConfiguration<RentalTypes>
    {
		
        public void Configure(EntityTypeBuilder<RentalTypes> builder)
        {
            builder.HasIndex("RentalType").IsUnique(true);


            builder.HasData
                (
                new RentalTypes(rentalTypesId:1, rentalType:"GROUND RENT"),
                new RentalTypes(rentalTypesId:2, rentalType:"HOUSE RENT"),
                new RentalTypes(rentalTypesId:3, rentalType:"SHOP/OFFICE RENT")
                );
        }
    }
}

