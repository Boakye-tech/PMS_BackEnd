﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Entities.Permissions
{
	public record ApplicationModulesPermissionsDto
	{

        [StringLength(50)]
        public string? RoleId { get; set; }

        [StringLength(12)]
        public string? ModuleId { get; set; }

        public IEnumerable<ModulePermissions>? ModulePermission { get; set; }

    }

    public record ModulePermissions
    {
        [StringLength(10)]
        public string? ModulePermission { get; set; }
    }


    public record ApplicationModulesPermissionsReadDto
    {

        [StringLength(50)]
        public string? RoleName { get; set; }

        [StringLength(12)]
        public string? ModuleName { get; set; }

        [StringLength(10)]
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

        public string? ModulePermission { get; set; }

    }
}

