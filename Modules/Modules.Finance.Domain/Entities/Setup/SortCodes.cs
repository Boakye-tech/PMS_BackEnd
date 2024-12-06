using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class SortCodes: AuditableEntity
	{
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(6)]
        public required string SortCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string BankName { get; set; }

        [Required]
        [StringLength(120)]
        public required string BranchName { get; set; }
    }
}

