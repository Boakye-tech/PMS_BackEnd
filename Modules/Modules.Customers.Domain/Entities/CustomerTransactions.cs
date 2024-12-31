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
        public string VoucherNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        [StringLength(10)]
        public string ChequeNumber { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public int AccountCode { get; set; }

        public CustomerTransactions()
		{
		}
	}
}

