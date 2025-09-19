// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/DebtorTypesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 3:29 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
	public class DebtorTypesConfiguration : IEntityTypeConfiguration<DebtorTypes>
    {

        public void Configure(EntityTypeBuilder<DebtorTypes> builder)
        {
            builder.HasData
                (
                new DebtorTypes(1, 1, 2, "HOUSES WITHOUT ACREAGE"),
                new DebtorTypes(1, 2, 3, "RESIDENTIAL PLOTS WITH ACREAGE"),
                new DebtorTypes(1, 3, 4, "COMMERCIAL PLOTS"),
                new DebtorTypes(1, 4, 5, "INDUSTRIAL LANDS"),
                new DebtorTypes(1, 5, 9, "INDUSTRIAL/OVERSEAS"),
                new DebtorTypes(1, 6, 6, "INSTITUTIONAL LANDS"),
                new DebtorTypes(1, 7, 7, "AGRICULTURAL LANDS"),
                new DebtorTypes(1, 8, 8, "SPECIAL"),
                new DebtorTypes(2, 9, 9, "HOUSE RENT"),
                new DebtorTypes(3, 10, 10, "SHOP/OFFICE RENT")
                );
        }
    }
}

