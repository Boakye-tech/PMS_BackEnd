using System;
namespace Modules.Estates.Domain.Entities.Management
{
	public class StopDebit
	{
        [Key]
        public int StopDebitId { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [StringLength(255)]
        public string? Reasons { get; set; }

        public int DebtorStatus { get; set; }

        public DateTime ActionOn { get; set; }

        [StringLength(36)]
        public string? ActionBy { get; set; }
    }
}

