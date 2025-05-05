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
	public record ComplaintReadDto
	{
        [StringLength(20)]
        public string? ComplaintNumber { get; set; }

        public string? NatureOfComplaint { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        public DateTime ComplaintDate { get; set; }

        public string? ComplaintStatus { get; set; }
    }


    public record ComplaintStaffReadDto
    (
         string? ComplaintNumber,

         string? ComplaintType,

         List<string>? NatureOfComplaint,

         string? CustomerCode,

         string? CustomerName,

         string? PropertyNumber,

         string? PhoneNumber,

         DateTime ComplaintDate,

         string? ComplaintStatus,

         string? InitiatedBy
    );

}

