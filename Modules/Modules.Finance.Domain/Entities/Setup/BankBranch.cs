using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class BankBranch : AuditableEntity
    {
        [Required]
        public required string BankId { get; set; }

        [Key]
        [Required]
        public required string BranchId { get; set; }

        [Required]
        [StringLength(120)]
        public required string BranchName { get; set; }
    }
}

