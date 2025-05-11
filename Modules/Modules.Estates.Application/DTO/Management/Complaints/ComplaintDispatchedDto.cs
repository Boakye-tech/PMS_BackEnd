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

namespace Modules.Estates.Application.DTO.Management.Complaints
{
	public record ComplaintDispatchedDto
	{
        [Required]
        public List<string>? ComplaintNumber { get; set; }

        [StringLength(36)]
        public string? DispatchedBy { get; set; }

        //[Required]
        //public int DispatchedTo_DepartmentId { get; set; }

        //public int DispatchedTo_DepartmentUnitId { get; set; }

    }
}

