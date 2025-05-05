// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Management/Complaints/ComplainantDetails.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/04/2025 6:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
namespace Modules.Estates.Application.DTO.Management.Complaints
{
	public record ComplainantDetailsDto
	{
		public string? PropertyNumber { get; set; }
        public string? PropertyLocation { get; set; }
        public string? CustomerCode { get; set; }
        public string? CustomerName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
    }
}

