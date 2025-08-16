// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Entities.Permissions
{

    public record ApplicationModulesPermissionsDto
    {

        [StringLength(50)]
        public string? RoleId { get; set; }

        public List<ModulePermissionsDto>? ModulePermission { get; set; }

        [StringLength(50)]
        public string? CreatedBy { get; set; }
    }

    public record ModulePermissionsDto
    {

        [StringLength(12)]
        public string? ModuleId { get; set; }

        public List<string>? Permissions { get; set; }

    }



    public record ApplicationModulesPermissionsReadDto
    {

        [StringLength(50)]
        public string? RoleName { get; set; }

        [StringLength(12)]
        public string? ModuleName { get; set; }
         
        [StringLength(50)]
        public IEnumerable<string>? ModulePermission { get; set; }
    }


    public record RoleModulesPermissionsDto
    {
        public int ModulePermissionId { get; set; }

        [StringLength(50)]
        public string? RoleId { get; set; }

        [StringLength(50)]
        public string? RoleName { get; set; }

        [StringLength(12)]
        public string? ModuleId { get; set; }

        [StringLength(50)]
        public string? ModuleName { get; set; }

        [StringLength(50)]
        public string? ModulePermission { get; set; }

    }

    public record ModulesByRolesPermissionsDto
    {

        [StringLength(50)]
        public string? RoleId { get; set; }

        [StringLength(50)]
        public string? RoleName { get; set; }

        public List<RoleModulePermissions>? ModulesPermission { get; set; }
    }

    public record RoleModulePermissions
    {

        [StringLength(12)]
        public string? ModuleId { get; set; }

        [StringLength(50)]
        public string? ModuleName { get; set; }

        public Dictionary<string, bool>? PermissionName { get; set; }
    }



    public record ApplicationModulesPermissionsUpdateDto
    {
        [StringLength(50)]
        public string? RoleId { get; set; }

        public List<ModulePermissionsDto>? ModulePermission { get; set; }

        [StringLength(50)]
        public string? ModifiedBy { get; set; }

    }

}

