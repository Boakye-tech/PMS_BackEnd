using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos
{
	public record CustomerTransactionsDto
	{
        [StringLength(50)]
        public required string VoucherNumber { get; set; }

        [StringLength(50)]
        public required string PropertyNumber { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [Required]
        public required DateTime TransactionDate { get; set; }

        [StringLength(50)]
        public string? ReferenceNumber { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

        public required double Amount { get; set; }

        public required int AccountCode { get; set; }

        [StringLength(2)]
        public required string TransactionType { get; set; }

        [StringLength(3)]
        public required int VoucherType { get; set; }
    }
}

