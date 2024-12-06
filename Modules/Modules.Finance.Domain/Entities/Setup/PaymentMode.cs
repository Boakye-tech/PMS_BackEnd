using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class PaymentMode : AuditableEntity
    {
        [Key]
        [Required]
        public required int PaymentModeId { get; set; }

        [Required]
        [StringLength(20)]
        public required string PaymentModes { get; set; }
    }
}

