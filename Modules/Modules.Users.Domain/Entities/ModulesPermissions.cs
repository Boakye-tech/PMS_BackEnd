// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ModulesPermissions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 03/08/2025 7:50 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class ModulesPermissions
	{
        [Key]
        public int ModulesPermissionsId { get; set; }

        [Required]
        [StringLength(12)]
        public string? ModuleId { get; set; }

        // Navigation property for ApplicationModules
        public virtual ApplicationModules? ApplicationModules { get; private set; }

        [Required]
        [StringLength(50)]
        public string? PermissionName { get; set; }


        public ModulesPermissions(string moduleId, string permissionName)
        {
            ModuleId = moduleId;
            PermissionName = permissionName;
        }

        public static ModulesPermissions CreateUpdate(string moduleId, string permissionName)
        {
            if (string.IsNullOrWhiteSpace(moduleId) || string.IsNullOrWhiteSpace(permissionName))
            {
                throw new ArgumentException("Invalid modules permissions data.");
            }


            if (string.IsNullOrWhiteSpace(moduleId) || moduleId.Length > 12)
                throw new ArgumentException("The modules id must not be null or exceed 12 characters.");

            if (string.IsNullOrWhiteSpace(permissionName) || permissionName.Length > 50)
                throw new ArgumentException("The module permission must not be null or exceed 10 characters.");

            return new ModulesPermissions(moduleId, permissionName);
        }
    }
}

