// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Users.Infrastructure.Configuration
{
	public class DepartmentsConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasIndex(d => d.DepartmentName)
                   .IsUnique();

            // Configure the one-to-many relationship with Department Unit
            builder.HasMany(d => d.DepartmentUnits)
                   .WithOne(dt => dt.Department)
                   .HasForeignKey(dt => dt.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Department(401, "FIN", "FINANCE"),
                new Department(402, "EST", "ESTATES"),
                new Department(403, "LEG", "LEGAL")
                );
        }
    }


    public class DepartmentsUnitsConfiguration : IEntityTypeConfiguration<DepartmentUnit>
    {
        public void Configure(EntityTypeBuilder<DepartmentUnit> builder)
        {
            builder.HasIndex(u => u.UnitName)
                   .IsUnique();

            builder.HasData(
                new DepartmentUnit(401,210,"M.I.S"),
                new DepartmentUnit(401,211,"REVENUE"),
                new DepartmentUnit(401,212,"CASH&BANK"),

                new DepartmentUnit(402,213,"FACILITIES"),
                new DepartmentUnit(402,214, "RECORDS"),
                new DepartmentUnit(402,215, "SEERVICED PLOTS"),
                new DepartmentUnit(402,216, "HOUSES"),
                new DepartmentUnit(402,217, "SHOPS")

                );
        }
    }
}

