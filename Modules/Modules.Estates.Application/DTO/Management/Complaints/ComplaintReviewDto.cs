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
	public record ComplaintReviewDto
	{
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [StringLength(3)]
        public string? IsReviewed { get; set; }

        public string? ReviewNotes { get; set; }

        [StringLength(36)]
        public string? ReviewedBy { get; set; }
    }
}

