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
	public record ComplaintHistoryDto
	{
        [Key]
        public int ComplaintHistoryId { get; set; }

        [StringLength(10)]
        public required string ComplaintNumber { get; set; }

        public required ComplaintStatusEnum ComplaintStatus { get; set; }

        [StringLength(36)]
        public required string ActionBy { get; set; }

        public required DateTime ActionOn { get; set; }
    }


    public record ComplaintHistoryReadDto
    {

        public required string ComplaintStatus { get; set; }

        public required string ComplaintDescription { get; set; }

        public required DateTime ActionOn { get; set; }
    }
}

