using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class PaymentType : AuditableEntity
    {
        [Key]
        [Required]
        public int PaymentTypeId { get; set; }

        [Required]
        [StringLength(20)]
        public required string PaymentTypes { get; set; }
    }
}

