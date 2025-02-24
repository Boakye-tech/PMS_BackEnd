using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerPayments
	{
        [Key]
        [Required]
        [StringLength(50)]
        public string? ReceiptNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(255)]
        public string? CustomerName { get; set; }

        [Required]
        public DateTime DateOfPayment { get; set; }

        [Required]
        public string? PaymentMode { get; set; } //cash, cheque etc

        public string? PaymentType { get; set; } //arrear, misc, current etc

        [Required]
        public string? InvoiceCurrency { get; set; }

        [Required]
        public string? PaymentCurrency { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public double AmountPaid { get; set; }

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

        [Required]
        [StringLength(255)]
        public string? PayeeName { get; set; }

        [Required]
        public string? Narration { get; set; }
        
        [Required]
        [StringLength(20)]
        public string? InvoiceNumber { get; set; }

        public int InvoiceItemsId { get; set; }

        [Required]
        [StringLength(150)]
        public string? Cashier { get; set; }


        public CustomerPayments()
		{
		}

        public CustomerPayments(string receiptNumber, string propertyNumber, string customerCode, string customerName, DateTime dateOfPayment, string paymentMode, string paymentType, string invoiceCurrency, string paymentCurrency, double amount, double AmountPaid, string issuingBank,
                                string issuingBranch, string receivingBank, string processingBranch, string receivingBranch, string payPoint, string chequeNumber, string referenceNumber, string payeeName, string njarration, string invoiceNumber, int invoiceItemsId, string cashier)
        {
        }

        public static CustomerPayments AddPaymentDetails(string receiptNumber, string propertyNumber, string customerCode, string customerName, DateTime dateOfPayment, string paymentMode, string paymentType, string invoiceCurrency, string paymentCurrency, double amount, double amountPaid,
                                                         string issuingBank,string issuingBranch, string receivingBank, string processingBranch, string receivingBranch, string payPoint, string chequeNumber, string referenceNumber, string payeeName, string narration, string invoiceNumber, int invoiceItemsId, string cashier)
        {

            if (string.IsNullOrWhiteSpace(receiptNumber) || string.IsNullOrWhiteSpace(propertyNumber) || string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(invoiceNumber) || string.IsNullOrWhiteSpace(narration) || amount < 0 || amountPaid < 0)
            {
                throw new ArgumentException("Invalid customer payment details data.");
            }


            if (string.IsNullOrWhiteSpace(receiptNumber))
            {
                throw new ArgumentException("Receipt number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerCode))
            {
                throw new ArgumentException("customer code must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentException("Customer name must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(invoiceNumber))
            {
                throw new ArgumentException("Invoice number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(paymentMode))
            {
                throw new ArgumentException("Payment mode must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(invoiceCurrency))
            {
                throw new ArgumentException("Invoice currency must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(paymentCurrency))
            {
                throw new ArgumentException("Payment currency must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(payeeName))
            {
                throw new ArgumentException("Payee name must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(narration))
            {
                throw new ArgumentException("Payee name must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(cashier))
            {
                throw new ArgumentException("cashier must not be null or empty.");
            }

            if (dateOfPayment == DateTime.MinValue)
            {
                throw new ArgumentException("Payment date must not be an invalid date.");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("payment amount must be greater than zero.");
            }

            if (amountPaid <= 0)
            {
                throw new ArgumentException("Amount paid must be greater than zero.");
            }

            return new CustomerPayments
            {
                ReceiptNumber = receiptNumber,
                PropertyNumber = propertyNumber,
                CustomerCode = customerCode,
                CustomerName = customerName,
                DateOfPayment = dateOfPayment,
                PaymentMode = paymentMode, //cash, cheque etc
                PaymentType = paymentType,  //arrear, misc, current etc
                InvoiceCurrency = invoiceCurrency,
                PaymentCurrency = paymentCurrency,
                Amount = amount,
                AmountPaid = amountPaid,
                IssuingBank = issuingBank,
                IssuingBranch = issuingBranch,
                ReceivingBank = receivingBank,
                ProcessingBranch = processingBranch,
                ReceivingBranch = receivingBranch,
                PayPoint = payPoint,
                ChequeNumber = chequeNumber,
                ReferenceNumber = referenceNumber ,
                PayeeName = payeeName,
                Narration = narration,
                InvoiceNumber = invoiceNumber,
                InvoiceItemsId = invoiceItemsId,
                Cashier = cashier

            };



        }

    }
}