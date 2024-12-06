using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class CurrencyAndExchangeRate : AuditableEntity
    {
        [Key]
        [Required]
        public required int CurrencyId { get; set; }

        [Required]
        [StringLength(5)]
        public required string CurrencyInitial { get; set; }

        [Required]
        [StringLength(15)]
        public required string CurrencyName { get; set; }

        [Required]
        public required double BuyingRate { get; set; }

        [Required]
        public required double SellingRate { get; set; }

        [Required]
        public required bool BaseCurrency { get; set; }

        [Required]
        public required DateTime ApplicableDate { get; set; }

        [Required]
        public required short IsCurrent { get; set; }
    }
}

