// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Application/Dtos/Entities/Permissions/ModulesPermissionsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 03/08/2025 8:23 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Entities.Permissions
{
	public record ModulesPermissionsDto
	{
        [StringLength(12)]
        public required string ModuleId { get; set; }

        [StringLength(50)]
        public required List<string> PermissionName { get; set; }

    }
}

