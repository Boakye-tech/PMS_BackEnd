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

        public string? CustomerName { get; set; }

        public string? CustomerAddress { get; set; }

        public string? CustomerEmailAddress { get; set; }

        public string? CustomerPhoneNumber { get; set; }

        [Required]
        public double InvoiceAmount { get; set; }

        //public IEnumerable<InvoiceDetails>? InvoiceDetails { get; set; }

    }

    //public class InvoiceDetails
    //{
    //    public string? Description { get; set; }
    //    public double Amount { get; set; }
    //}

}

