using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Services
	{
        [Key]
        [Required]
        [StringLength(5)]
        public required string ServiceCode { get; set; }

        [Required]
        [StringLength(50)]
        public required string ServiceName { get; set; }

        [Required]
        public required double Amount { get; set; }

        [Required]
        public required int AccountCode { get; set; }
    }
}

