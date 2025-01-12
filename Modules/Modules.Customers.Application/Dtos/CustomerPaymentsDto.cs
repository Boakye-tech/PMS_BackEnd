using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos
{
	public record CustomerPaymentsDto
	{
        [StringLength(50)]
        public required string ReceiptNumber { get; set; }

        [StringLength(25)]
        public required string PropertyNumber { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        [StringLength(255)]
        public required string CustomerName { get; set; }

        public required DateTime DateOfPayment { get; set; }

        public required string PaymentMode { get; set; } //cash, cheque etc

        public string? PaymentType { get; set; } //arrear, misc, current etc

        public string? InvoiceCurrency { get; set; }

        public string? PaymentCurrency { get; set; }

        public required float Amount { get; set; }

        public required float AmountPaid { get; set; }

        public string? IssuingBank { get; set; }

        public string? IssuingBranch { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

        [StringLength(50)]
        public string? ReferenceNumber { get; set; }

        [StringLength(255)]
        public required string PayeeName { get; set; }

        [Required]
        public required string Narration { get; set; }

        [StringLength(20)]
        public required string InvoiceNumber { get; set; }
    }
}

