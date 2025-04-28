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
	public record ComplaintUpdateDto
	{
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        //[Required]
        //[StringLength(50)]
        //public string? PropertyNumber { get; set; }

        //[Required]
        //public int PropertyLocationId { get; set; }

        ////[Required]
        //[StringLength(10)]
        //public string? CustomerCode { get; set; }

        //[Required]
        //[StringLength(200)]
        //public string? CustomerName { get; set; }

        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [StringLength(75)]
        public string? EmailAddress { get; set; }

        [StringLength(3)]
        public string? IsTheMatterInCourt { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

        public DateTime AvailabilityDate { get; set; }

        public string[]? DocumentImages { get; set; }

        [StringLength(36)]
        public string? ModifiedBy { get; set; }

    }
}

