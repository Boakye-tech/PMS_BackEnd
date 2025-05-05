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

namespace Modules.Customers.Application.Dtos
{
	public record CustomerInvoiceDto
	{
        [StringLength(50)]
        public required string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        [StringLength(25)]
        public required string PropertyNumber { get; set; }

        [StringLength(10)]
        public required string CustomerCode { get; set; }

        public double Acreage { get; set; }

        public string? TransactionCode { get; set; }

        public string? TransactionNumber { get; set; }

        public required DateTime ExpirationDate { get; set; }

        public string? CustomerName { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerEmailAddress { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        public required double InvoiceAmount { get; set; }

        public double AmountPaid { get; set; }

        public double BalanceDue { get; set; }

        public string? InvoiceStatus { get; set; }

        public required IEnumerable<CustomerInvoiceItemsDto> InvoiceItems { get; set; }
    }


    public record CustomerInvoiceSummaryDto
    {
        [StringLength(50)]
        public required string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        [StringLength(10)]
        public  string? CustomerCode { get; set; }

        [StringLength(75)]
        public string? PropertyNumber { get; set; }

        [StringLength(50)]
        public required string InvoiceDescription { get; set; }

        public required double InvoiceAmount { get; set; }

        public string? InvoiceStatus { get; set; }

    }

    public record CustomerInvoiceSummaryReadDto
    {
        [StringLength(50)]
        public required string InvoiceNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        [StringLength(50)]
        public required string InvoiceDescription { get; set; }

        public required double InvoiceAmount { get; set; }

        public string? InvoiceStatus { get; set; }

    }
}

