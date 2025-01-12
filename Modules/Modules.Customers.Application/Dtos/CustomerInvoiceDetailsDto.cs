using System;
namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceDetailsDto
	{
        public required string Description { get; set; }
        public required double Amount { get; set; }
    }
}

