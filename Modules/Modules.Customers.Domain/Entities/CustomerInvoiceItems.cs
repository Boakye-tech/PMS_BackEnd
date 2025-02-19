using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerInvoiceItems
	{
        [Key]
        public int InvoiceItemsId { get; set; }

        [Required]
        public string? InvoiceNumber { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public double Amount { get; set; }

        public int Status { get; set; }


        public CustomerInvoiceItems()
		{
		}

        public CustomerInvoiceItems(int invoiceItemsId, string invoiceNumber, string description, double amount, int status)
        {
                
        }

        public static CustomerInvoiceItems AddInvoiceItems(int invoiceItemsId, string invoiceNumber, string description, double amount, int status)
        {
            if (string.IsNullOrWhiteSpace(invoiceNumber) || string.IsNullOrWhiteSpace(invoiceNumber) || string.IsNullOrWhiteSpace(description) || amount < 0)
            {
                throw new ArgumentException("Invalid customer invoice items details data.");
            }


            if (string.IsNullOrWhiteSpace(invoiceNumber))
            {
                throw new ArgumentException("Invoice number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Invoice description must not be null or empty.");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Invoice amount must be greater than zero.");
            }

            return new CustomerInvoiceItems
            {
                InvoiceItemsId = invoiceItemsId,
                InvoiceNumber = invoiceNumber,
                Description = description,
                Amount = amount,
                Status = status
            };

        }


    }
}

