// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/CaseTypeConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 6:12 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Legal.Infrastructure.Configurations
{
	public class CaseTypeConfiguration : IEntityTypeConfiguration<CaseType>
    {
        public void Configure(EntityTypeBuilder<CaseType> builder)
        {
            builder.HasIndex(ct => ct.CaseTypes).IsUnique(true);

            builder.HasData(
                new CaseType(1, "TENANCY ISSUES"),
                new CaseType(2, "TERMINATION ISSUES"),
                new CaseType(3, "DEBT RECOVERY"),
                new CaseType(4, "BREACH OF CONTRACT")
                );
        }
    }
}

