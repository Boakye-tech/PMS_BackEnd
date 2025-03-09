using System;
namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceItemsDto
	{
        public required string Description { get; set; }
        public required double Amount { get; set; }
        public double AmountPaid { get; set; }
        public double BalanceDue { get; set; }
        public string? Status { get; set; }
    }
}

