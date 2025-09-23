// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/BankBranchConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 9:51 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
	public class BankBranchConfiguration: IEntityTypeConfiguration<BankBranch>
    {
        public void Configure(EntityTypeBuilder<BankBranch> builder)
        {
            builder.HasKey(bb => bb.BranchId);

            builder.Property(bb => bb.BranchName)
                  .HasMaxLength(100)
                  .IsRequired();
        }
    }
}

