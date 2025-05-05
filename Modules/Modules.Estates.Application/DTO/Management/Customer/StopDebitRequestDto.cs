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

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record StopDebitRequestDto
	{
		//[Key]
		//public int StopDebitId { get; set; }

		[StringLength(10)]
		public string? CustomerCode { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [StringLength(255)]
		public string? Reasons { get; set; }

        public int DebtorStatus { get; set; }

        //public DateTime ActionOn { get; set; }

		[StringLength(36)]
		public string? ActionBy { get; set; }
	}
}

