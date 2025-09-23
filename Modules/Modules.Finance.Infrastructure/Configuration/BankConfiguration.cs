// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/BankConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 9:48 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
	public class BankConfiguration : IEntityTypeConfiguration<Bank>
    {
        public void Configure(EntityTypeBuilder<Bank> builder)
        {
            builder.HasKey(b => b.BankId);

            builder.Property(b => b.BankId)
                  .HasMaxLength(10)
                  .IsRequired();

            builder.Property(b => b.BankName)
                  .HasMaxLength(50)
                  .IsRequired();

            // One-to-many: Bank to BankBranch
            builder.HasMany(b => b.BankBranch)
                .WithOne(bb => bb.Bank)
                .HasForeignKey(bb => bb.BankId)
                .OnDelete(DeleteBehavior.Restrict); 
        }
    }
}

