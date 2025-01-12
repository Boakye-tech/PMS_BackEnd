using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerInvoiceItems
	{
        [Key]
        public int InvoiceItemsId { get; set; }

        public string InvoiceNumber { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public int Status { get; set; }


        public CustomerInvoiceItems()
		{
		}
	}
}

