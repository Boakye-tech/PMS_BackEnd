using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Billing.Domain.Entities
{
	public class BillingTypes
	{
		public int BillingTypesId { get; set; }

		[Required]
        [StringLength(4)]
        public string BillingTypeInitial { get; set; }

        [Required]
        [StringLength(50)]
        public string BillingType { get; set; }

        [Required]
        [StringLength(20)]
        public string Cycle { get; set; }

        [Required]
        public DateTime BillingDate { get; set; }

		public BillingTypes()
		{
		}
	}
}

