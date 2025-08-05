// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/ApplicationModulesPermissions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class ApplicationModulesPermissions
    {
        [Key]
        public int ModulePermissionId { get; set; }

        [StringLength(50)]
		public string? RoleId { get; set; }

        [StringLength(12)]
        public string? ModuleId { get; set; }

        [StringLength(50)]
        public string? ModulePermission { get; set; }


        public ApplicationModulesPermissions(string roleId, string moduleId, string modulePermission)
        {
            RoleId = roleId;
            ModuleId = moduleId;
            ModulePermission = modulePermission;
        }

        public static ApplicationModulesPermissions CreateUpdate(string roleId, string moduleId, string modulePermission)
        {
            if (string.IsNullOrWhiteSpace(roleId) || string.IsNullOrWhiteSpace(moduleId) || string.IsNullOrWhiteSpace(modulePermission))
            {
                throw new ArgumentException("Invalid modules permissions data.");
            }

            if (string.IsNullOrWhiteSpace(roleId) || roleId.Length > 50)
                throw new ArgumentException("The role id must not be null or exceed 50 characters.");

            if (string.IsNullOrWhiteSpace(moduleId) || moduleId.Length > 12)
                throw new ArgumentException("The modules id must not be null or exceed 12 characters.");

            if (string.IsNullOrWhiteSpace(modulePermission) || modulePermission.Length > 50)
                throw new ArgumentException("The module permission must not be null or exceed 50 characters.");

            return new ApplicationModulesPermissions(roleId, moduleId, modulePermission);
        }
    }
}

