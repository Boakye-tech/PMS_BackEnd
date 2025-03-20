using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Customer
{
	public record StopDebitRequestDto
	{
		[Key]
		public int StopDebitId { get; set; }

		[StringLength(10)]
		public string? CustomerCode { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [StringLength(255)]
		public string? Reasons { get; set; }

		public DateTime DebtorStatus { get; set; }

		[StringLength(36)]
		public string? StoppedBy { get; set; }
	}
}

