// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Property/AssignPropertytoCustomerDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/07/2025 12:13 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Property
{
	public class AssignPropertytoCustomerDto
	{
		[Required]
		[StringLength(75)]
        public required string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [Required]
        [StringLength(36)]
        public required string ActionBy { get; set; }

  //      public AssignPropertytoCustomerDto()
		//{
		//}
	}
}

