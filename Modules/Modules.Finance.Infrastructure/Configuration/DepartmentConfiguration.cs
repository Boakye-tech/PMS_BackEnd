// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/DepartmentConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 8:07 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
	public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            // Configure the one-to-one relationship with invoice types
            builder.HasOne(s => s.InvoiceTypes)
                   .WithOne(d => d.Department)
                   .HasForeignKey<InvoiceTypes>(d => d.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Configure the one-to-many relationship with department units
            builder.HasMany(du => du.DepartmentUnits)
                   .WithOne(d => d.Department)
                   .HasForeignKey(du => du.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

