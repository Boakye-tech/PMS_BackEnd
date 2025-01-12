using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerTransactions
	{
        [Key]
        public int CustomerTransactionId { get; set; }

        [Required]
        [StringLength(50)]
        public required string VoucherNumber { get; set; }

        [Required]
        [StringLength(50)]
        public required string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [Required]
        public required DateTime TransactionDate { get; set; }

        [StringLength(50)]
        public string? ReferenceNumber { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

        [Required]
        public required double Amount { get; set; }

        public required int AccountCode { get; set; }

        [Required]
        [StringLength(2)]
        public required string TransactionType { get; set; }

        [Required]
        [StringLength(3)]
        public required string VoucherType { get; set; }
	}



}

