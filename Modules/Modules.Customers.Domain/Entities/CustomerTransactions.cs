using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

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

        [StringLength(255)]
        public required string Narration { get; set; }

        [Required]
        public required double Amount { get; set; }

        public required int AccountCode { get; set; }

        [Required]
        [StringLength(2)]
        public required string TransactionType { get; set; }

        [Required]
        [StringLength(3)]
        public required string VoucherType { get; set; }






        public CustomerTransactions()
        {
        }


        public CustomerTransactions(int customerTransactionId, string voucherNumber, string propertyNumber, string customerCode, DateTime transactionDate, string? referenceNumber, string? chequeNumber, string narration, double amount, int accountCode, string transactionType, string voucherType)
        {
        }

        public static CustomerTransactions AddCustomerTransaction(int customerTransactionId, string voucherNumber, string propertyNumber, string customerCode, DateTime transactionDate, string? referenceNumber, string? chequeNumber, string narration, double amount, int accountCode, string transactionType, string voucherType)
        {
            if (string.IsNullOrWhiteSpace(voucherNumber) || string.IsNullOrWhiteSpace(propertyNumber) || string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(transactionType) || string.IsNullOrWhiteSpace(voucherType) || string.IsNullOrWhiteSpace(narration) || amount < 0 || accountCode < 0)
            {
                throw new ArgumentException("Invalid customer transaction details data.");
            }


            if (string.IsNullOrWhiteSpace(voucherNumber))
            {
                throw new ArgumentException("Voucher number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerCode))
            {
                throw new ArgumentException("Customer code must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(narration))
            {
                throw new ArgumentException("Narration must not be null or empty.");
            }

            if (transactionDate == DateTime.MinValue)
            {
                throw new ArgumentException("Transaction date must not be an invalid date.");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Transaction amount must be greater than zero.");
            }

            if (accountCode <= 0)
            {
                throw new ArgumentException("Account code must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(transactionType))
            {
                throw new ArgumentException("Transaction Type must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(voucherType))
            {
                throw new ArgumentException("Voucher type must not be null or empty.");
            }


            return new CustomerTransactions
            {
                CustomerTransactionId = customerTransactionId,
                VoucherNumber = voucherNumber,
                PropertyNumber = propertyNumber,
                CustomerCode = customerCode,
                TransactionDate = transactionDate,
                ReferenceNumber = referenceNumber,
                ChequeNumber = chequeNumber,
                Narration = narration,
                Amount = amount,
                AccountCode = accountCode,
                TransactionType = transactionType,
                VoucherType = voucherType
            };

        }
    }



}

