// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/ApplicationModulesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/08/2025 10:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Users.Infrastructure.Configuration
{
	public class ApplicationModulesConfiguration : IEntityTypeConfiguration<ApplicationModules>
	{
        public void Configure(EntityTypeBuilder<ApplicationModules> builder)
        {
            builder.HasIndex(am => am.ModuleName);

            builder.HasData(
                new ApplicationModules("0983f651-ea9", "Cashier"),
                new ApplicationModules("1e5b4b1c-b5d", "Complaints"),
                new ApplicationModules("23e7ffbf-762", "Billing"),
                new ApplicationModules("421070d5-37b", "Users"),
                new ApplicationModules("53a24ec6-b42", "Property"),
                new ApplicationModules("9a421337-c47", "Facilities"),
                new ApplicationModules("a4a39f7a-bd6", "Legal"),
                new ApplicationModules("e63107bf-457", "Customers"),
                new ApplicationModules("e6f9be9e-a28", "Notification")
                );
        }
    }
}



