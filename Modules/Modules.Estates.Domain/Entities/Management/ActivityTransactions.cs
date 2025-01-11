using System;
namespace Modules.Estates.Domain.Entities.Management
{
	public class ActivityTransactions
	{
		[Key]
		public int ActivityTransactionId { get; set; }

		public string? CustomerCode { get; set; }

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

