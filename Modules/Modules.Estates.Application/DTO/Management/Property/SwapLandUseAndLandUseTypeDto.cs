// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/SwapLandUseAndLandUseTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:12 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
	public class SwapLandUseAndLandUseTypeDto
	{

        public string PropertyNumber { get; set; }
        public int CurrentLandUseId { get; set; }
        public int CurrentLandUseTypeId { get; set; }
        public int NewLandUseId { get; set; }
        public int NewLandUseTypeId { get; set; }
        public string Reasons { get; set; }
        public string ActionBy { get; set; }

        public SwapLandUseAndLandUseTypeDto()
		{
		}
	}
}

