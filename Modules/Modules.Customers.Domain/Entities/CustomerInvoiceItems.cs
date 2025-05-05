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

        public double AmountPaid { get; set; }

        public double BalanceDue { get; set; }

        public string? Status { get; set; }


        public CustomerInvoiceItems()
		{
		}

        public CustomerInvoiceItems(int invoiceItemsId, string invoiceNumber, string description, double amount, double amountPaid, double balanceDue, string status)
        {
                
        }

        public static CustomerInvoiceItems AddInvoiceItems(int invoiceItemsId, string invoiceNumber, string description, double amount, double amountPaid, double balanceDue, string status)
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
                throw new ArgumentException("Invoice Item description must not be null or empty.");
            }

            if (amount <= 0)
            {
                throw new ArgumentException("Invoice Item amount must be greater than zero.");
            }

            return new CustomerInvoiceItems
            {
                InvoiceItemsId = invoiceItemsId,
                InvoiceNumber = invoiceNumber,
                Description = description,
                Amount = amount,
                AmountPaid = amountPaid,
                BalanceDue = balanceDue,
                Status = status
            };

        }


    }
}

