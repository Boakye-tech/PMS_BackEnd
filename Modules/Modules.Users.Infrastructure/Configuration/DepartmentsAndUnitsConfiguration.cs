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
                new Department(401,"Finance"),
                new Department(402,"Estates")
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
                new DepartmentUnit(401,211,"Revenue"),
                new DepartmentUnit(401,212,"Cash&Bank"),

                new DepartmentUnit(402,213,"Facilities"),
                new DepartmentUnit(402,214, "Records"),
                new DepartmentUnit(402,215, "Plots"),
                new DepartmentUnit(402,216, "Houses"),
                new DepartmentUnit(402,217, "Shops")

                );
        }
    }
}

