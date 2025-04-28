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
	public record ApplicationModulesDto
	{
        [StringLength(12)]
        public string? ModuleId { get; set; }

        [StringLength(20)]
        public string? ModuleName { get; set; }
    }


    public record ApplicationModulesCreateDto
    {
        [StringLength(20)]
        public string? ModuleName { get; set; }
    }
}

