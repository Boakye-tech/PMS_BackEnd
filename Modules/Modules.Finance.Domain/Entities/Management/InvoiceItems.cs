using System;
namespace Modules.Finance.Domain.Entities.Management
{
	public class InvoiceItems
	{
        public int InvoiceItemsId { get; set; }

        public string InvoiceNumber { get; set; }

        public string Description { get; set; }

        public double Amount { get; set; }

        public int Status { get; set; }

        public InvoiceItems()
		{
		}
	}
}



