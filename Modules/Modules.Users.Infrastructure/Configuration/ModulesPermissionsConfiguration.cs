// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Infrastructure/Configuration/ModulesPermissionsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/08/2025 10:32 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Users.Infrastructure.Configuration
{
	public class ModulesPermissionsConfiguration : IEntityTypeConfiguration<ModulesPermissions>
	{

        public void Configure(EntityTypeBuilder<ModulesPermissions> builder)
        {
            builder.HasIndex(mp => new { mp.ModuleId, mp.PermissionName });

            builder.HasData(
                //Finance Module
                new ModulesPermissions(1,"0983f651-ea9","CREATE"),
                new ModulesPermissions(2,"0983f651-ea9","READ"),
                new ModulesPermissions(3,"0983f651-ea9", "UPDATE"),
                new ModulesPermissions(4,"0983f651-ea9", "DELETE"),

                //Complaints
                new ModulesPermissions(5,"1e5b4b1c-b5d", "CREATE"),
                new ModulesPermissions(6,"1e5b4b1c-b5d", "READ"),
                new ModulesPermissions(7,"1e5b4b1c-b5d", "UPDATE"),
                new ModulesPermissions(8,"1e5b4b1c-b5d", "DELETE"),

                new ModulesPermissions(9,"1e5b4b1c-b5d", "ACKNOWLEDGE"),
                new ModulesPermissions(10,"1e5b4b1c-b5d", "DISPATCH"),
                new ModulesPermissions(11,"1e5b4b1c-b5d", "REVIEW"),
                new ModulesPermissions(12,"1e5b4b1c-b5d", "ASSIGN"),
                new ModulesPermissions(13,"1e5b4b1c-b5d", "RESOLVE"),
                new ModulesPermissions(14,"1e5b4b1c-b5d", "REOPEN"),
                new ModulesPermissions(15,"1e5b4b1c-b5d", "CLOSE"),
                new ModulesPermissions(16,"1e5b4b1c-b5d", "CANCEL"),
                new ModulesPermissions(17,"1e5b4b1c-b5d", "INPROGRESS"),

                //Billing
                new ModulesPermissions(18,"23e7ffbf-762", "CREATE"),
                new ModulesPermissions(19,"23e7ffbf-762", "READ"),
                new ModulesPermissions(20,"23e7ffbf-762", "UPDATE"),
                new ModulesPermissions(21,"23e7ffbf-762", "DELETE"),

                //Users module
                new ModulesPermissions(22,"421070d5-37b", "CREATE"),
                new ModulesPermissions(23,"421070d5-37b", "READ"),
                new ModulesPermissions(24,"421070d5-37b", "UPDATE"),
                new ModulesPermissions(25,"421070d5-37b", "DELETE"),

                new ModulesPermissions(26,"421070d5-37b", "VERIFY"),
                new ModulesPermissions(27,"421070d5-37b", "REJECT"),
                new ModulesPermissions(28,"421070d5-37b", "APPROVE"),
                new ModulesPermissions(29,"421070d5-37b", "DISAPPROVE"),
                new ModulesPermissions(30,"421070d5-37b", "ACTIVATE"),
                new ModulesPermissions(31,"421070d5-37b", "DEACTIVATE"),
                new ModulesPermissions(32,"421070d5-37b", "ASSIGNUSER"),
                new ModulesPermissions(33,"421070d5-37b", "ASSIGNPERMISSION"),
                

                //Property module (development & estates)
                new ModulesPermissions(34,"53a24ec6-b42", "CREATE"),
                new ModulesPermissions(35,"53a24ec6-b42", "READ"),
                new ModulesPermissions(36,"53a24ec6-b42", "UPDATE"),
                new ModulesPermissions(37,"53a24ec6-b42", "DELETE"),

                new ModulesPermissions(38,"53a24ec6-b42", "STOPDEBIT"),
                new ModulesPermissions(39,"53a24ec6-b42", "STARTDEBIT"),
                new ModulesPermissions(40,"53a24ec6-b42", "ASSIGN"),
                new ModulesPermissions(41,"53a24ec6-b42", "NEWLEASE"),
                new ModulesPermissions(42,"53a24ec6-b42", "RENEWLEASE"),

                //Facilities
                new ModulesPermissions(43,"9a421337-c47", "CREATE"),
                new ModulesPermissions(44,"9a421337-c47", "READ"),
                new ModulesPermissions(45,"9a421337-c47", "UPDATE"),
                new ModulesPermissions(46,"9a421337-c47", "DELETE"),

                //Legal
                new ModulesPermissions(47,"a4a39f7a-bd6", "CREATE"),
                new ModulesPermissions(48,"a4a39f7a-bd6", "READ"),
                new ModulesPermissions(49,"a4a39f7a-bd6", "UPDATE"),
                new ModulesPermissions(50,"a4a39f7a-bd6", "DELETE"),

                //Customers
                new ModulesPermissions(51,"e63107bf-457", "CREATE"),
                new ModulesPermissions(52,"e63107bf-457", "READ"),
                new ModulesPermissions(53,"e63107bf-457", "UPDATE"),
                new ModulesPermissions(54,"e63107bf-457", "DELETE"),

                new ModulesPermissions(55,"e63107bf-457", "STOPDEBIT"),
                new ModulesPermissions(56,"e63107bf-457", "STARTDEBIT"),
                new ModulesPermissions(57,"e63107bf-457", "SUBMITCOMPLAINT"),
                new ModulesPermissions(58,"e63107bf-457", "ACKNOWLEDGECOMPLAINT"),
                new ModulesPermissions(59,"e63107bf-457", "DISPATCHCOMPLAINT"),
                new ModulesPermissions(60,"e63107bf-457", "REVIEWCOMPLAINT"),
                new ModulesPermissions(61,"e63107bf-457", "ASSIGNCOMPLAINT"),
                new ModulesPermissions(62,"e63107bf-457", "RESOLVECOMPLAINT"),
                new ModulesPermissions(63,"e63107bf-457", "REOPENCOMPLAINT"),
                new ModulesPermissions(64,"e63107bf-457", "CLOSECOMPLAINT"),
                new ModulesPermissions(65,"e63107bf-457", "CANCELCOMPLAINT"),
                new ModulesPermissions(66,"e63107bf-457", "INPROGRESSCOMPLAINT"),

                //Notification
                new ModulesPermissions(67,"e6f9be9e-a28", "CREATE"),
                new ModulesPermissions(68,"e6f9be9e-a28", "READ"),
                new ModulesPermissions(69,"e6f9be9e-a28", "UPDATE"),
                new ModulesPermissions(70,"e6f9be9e-a28", "DELETE")
                );
        }
    }
}

