// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/UpdateCadastralAndSitePlanDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 21/08/2025 2:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Property
{
	public record UpdateCadastralAndSitePlanDto
	{
        public string? PropertyNumber { get; set; }

        [StringLength(30)]
        public string? SitePlanNumber { get; private set; }

        [StringLength(30)]
        public string? CadastralPlanNumber { get; private set; }

        public PropertyCoordinates? Coordinates { get; private set; }
    }
}

