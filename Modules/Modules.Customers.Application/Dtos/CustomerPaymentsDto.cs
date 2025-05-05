// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

        public required double Amount { get; set; }

        public required double AmountPaid { get; set; }

        public string? IssuingBank { get; set; }

        public string? IssuingBranch { get; set; }

        public string? ReceivingBank { get; set; }

        public string? ProcessingBranch { get; set; }

        public string? ReceivingBranch { get; set; }

        public string? PayPoint { get; set; }

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

        public int InvoiceItemId { get; set; }

        [StringLength(150)]
        public required string Cashier { get; set; }
    }

    public record CustomerPaymentsSummaryDto
    {
        [StringLength(50)]
        public required string ReceiptNumber { get; set; }

        [Required]
        public required string Narration { get; set; }

        public required DateTime DateOfPayment { get; set; }

        public required string PaymentMode { get; set; } //cash, cheque etc

        public string? PaymentCurrency { get; set; }

        public required double AmountPaid { get; set; }

        [StringLength(10)]
        public string? ChequeNumber { get; set; }

    }

}

