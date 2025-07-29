// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Entities.Management
{
	public class ActivityTransactions : AuditableEntity
	{
		[Key]
		public int ActivityTransactionId { get; set; }

		[Required]
		[StringLength(10)]
		public string? CustomerCode { get; set; }

        [Required]
        [StringLength(75)]
        public string? PropertyNumber { get; set; }

		public DateTime ActivityDate { get; set; }

		public int ActivityId { get; set; }

		public int ActivityTypeId { get; set; }

		public string? Comments { get; set; }


		public ActivityTransactions()
		{
		}

	}
}

