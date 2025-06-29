// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Dtos/CustomerOpeningBalancesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:48 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Dtos
{
	public record CustomerOpeningBalancesDto
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(75)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(10)]
        public string? AccountCode { get; set; }

        [Required]
        public decimal OpeningBalance { get; set; }

        [Required]
        public int Years { get; set; }
    }
}

