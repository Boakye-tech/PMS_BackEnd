using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Bank : AuditableEntity
    {
        [Key]
        [Required]
        public required string BankId { get; set; }

        [Required]
        [StringLength(50)]
        public required string BankName { get; set; }
    }
}

