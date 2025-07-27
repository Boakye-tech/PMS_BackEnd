// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/ActivityAndActivityTypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:19 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Management.Property
{
	public class ActivityAndActivityTypesDto
    {
		public string PropertyNumber { get; set; }
		public DateTime ActivityDate { get; set; }
		public int ActivityId { get; set; }
        public int ActivityTypeId { get; set; }
		public string Notes { get; set; }
		public string CustomerCode { get; set; }

		public ActivityAndActivityTypesDto()
		{
		}
	}
}

