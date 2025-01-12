using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerPayments
	{
        [Key]
        [Required]
        [StringLength(50)]
        public string ReceiptNumber { get; set; }


        [Required]
        [StringLength(25)]
        public string PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string CustomerCode { get; set; }

        [Required]
        [StringLength(255)]
        public string CustomerName { get; set; }

        [Required]
        public DateTime DateOfPayment { get; set; }


        [Required]
        public string PaymentMode { get; set; } //cash, cheque etc

        public string PaymentType { get; set; } //arrear, misc, current etc

        public string InvoiceCurrency { get; set; }

        public string PaymentCurrency { get; set; }

        [Required]
        public float Amount { get; set; }

        [Required]
        public float AmountPaid { get; set; }

        public string IssuingBank { get; set; }

        public string IssuingBranch { get; set; }

        [StringLength(10)]
        public string ChequeNumber { get; set; }

        [StringLength(50)]
        public string ReferenceNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string PayeeName { get; set; }

        [Required]
        public string Narration { get; set; }
        
        [Required]
        [StringLength(20)]
        public string InvoiceNumber { get; set; }


        public CustomerPayments()
		{
		}
	}
}

