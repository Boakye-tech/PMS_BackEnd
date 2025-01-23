using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceDto
	{
        [StringLength(50)]
        public required string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        [StringLength(25)]
        public required string PropertyNumber { get; set; }

        public double Acreage { get; set; }

        public string? TransactionCode { get; set; }

        public string? TransactionNumber { get; set; }

        public required DateTime ExpirationDate { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerEmailAddress { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        public required double InvoiceAmount { get; set; }

        public required IEnumerable<CustomerInvoiceItemsDto> InvoiceItems { get; set; }
    }
}

