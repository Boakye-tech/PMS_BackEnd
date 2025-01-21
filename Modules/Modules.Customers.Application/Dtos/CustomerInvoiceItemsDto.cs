using System;
namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceItemsDto
	{
        public required string Description { get; set; }
        public required double Amount { get; set; }
    }
}

