// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerInvoice
	{
        [Key]
        [Required]
        [StringLength(50)]
        public string? InvoiceNumber { get; set; }

        [Required]
        public DateTime InvoiceDate { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        public double Acreage { get; set; }

        public string? TransactionCode { get; set; }

        public string? TransactionNumber { get; set; }

        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        public string? CustomerName { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerEmailAddress { get; set; }

        [Required]
        public string? CustomerPhoneNumber { get; set; }

        [Required]
        public double InvoiceAmount { get; set; }

        //[Required]
        public double AmountPaid { get; set; }

        //[Required]
        public double BalanceDue { get; set; }

        public string? InvoiceStatus { get; set; }

        public CustomerInvoice()
        {

        }

        public CustomerInvoice(string invoiceNumber, DateTime invoiceDate, string? propertyNumber, double acreage, string? transactionCode, string? transactionNumber, DateTime expirationDate, string? customerCode, string? customerName, string? customerAddress, string? customerEmailAddress,
                               string? customerPhoneNumber, double invoiceAmount, double amountPaid, double balanceDue, string invoiceStatus)
        {

        }

        public static CustomerInvoice AddInvoiceDetails(string invoiceNumber, DateTime invoiceDate, string? propertyNumber, double acreage, string? transactionCode, string? transactionNumber, DateTime expirationDate, string? customerCode, string? customerName, string? customerAddress,
                                                        string? customerEmailAddress,string? customerPhoneNumber, double invoiceAmount, double amountPaid, double balanceDue, string invoiceStatus)
        {
            if (string.IsNullOrWhiteSpace(invoiceNumber) || string.IsNullOrWhiteSpace(propertyNumber) || string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(customerName)  || string.IsNullOrWhiteSpace(customerPhoneNumber) || invoiceAmount < 0 )
            {
                throw new ArgumentException("Invalid customer invoice details data.");
            }


            if (string.IsNullOrWhiteSpace(invoiceNumber))
            {
                throw new ArgumentException("Invoice number must not be null or empty.");
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

            if (string.IsNullOrWhiteSpace(customerPhoneNumber))
            {
                throw new ArgumentException("Customer phone number must not be null or empty.");
            }

            if (invoiceDate == DateTime.MinValue)
            {
                throw new ArgumentException("Invoice date must not be an invalid date.");
            }

            if (expirationDate == DateTime.MinValue)
            {
                throw new ArgumentException("Expiration date must not be an invalid date.");
            }

            if (expirationDate <= invoiceDate)
            {
                throw new ArgumentException("Expiration date cannot be less or equal to the invoice date.");
            }

            if (invoiceAmount <= 0)
            {
                throw new ArgumentException("Invoice amount must be greater than zero.");
            }

            return new CustomerInvoice
            {
                InvoiceNumber = invoiceNumber,
                InvoiceDate = invoiceDate,
                PropertyNumber = propertyNumber,
                Acreage = acreage,
                TransactionCode = transactionCode,
                TransactionNumber = transactionNumber,
                ExpirationDate = expirationDate,
                CustomerCode = customerCode,
                CustomerName = customerName,
                CustomerAddress = customerAddress,
                CustomerEmailAddress = customerEmailAddress,
                CustomerPhoneNumber = customerPhoneNumber,
                InvoiceAmount = invoiceAmount,
                AmountPaid = amountPaid,
                BalanceDue = balanceDue,
                InvoiceStatus = invoiceStatus
                
            };

        }

    }


}

