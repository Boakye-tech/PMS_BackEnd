using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Forms
	{
        [Key]
        [Required]
        [StringLength(5)]
        public required string FormCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string FormName { get; set; }

        [Required]
        public required double Amount { get; set; }

        [Required]
        public required int AccountCode { get; set; }
    }
}

