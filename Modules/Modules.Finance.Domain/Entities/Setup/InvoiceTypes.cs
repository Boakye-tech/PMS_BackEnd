using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class InvoiceTypes : AuditableEntity
	{
        [Key]
        [Required]
        public int InvoiceTypesId { get; set; }

        [Required]
        [StringLength(5)]
        public string? InvoiceInitials { get; set; }

        [Required]
        [StringLength(75)]
        public string? InvoiceDescriptions { get; set; }

        [Required]
        public double InvoiceAmount { get; set; }


        public InvoiceTypes(int invoiceTypesId,string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
        {
            InvoiceTypesId = invoiceTypesId;
            InvoiceInitials = invoiceInitials;
            InvoiceDescriptions = invoiceDescriptions;
            InvoiceAmount = invoiceAmount;
        }

        public static InvoiceTypes CreateUpdate(int invoiceTypesId, string invoiceInitials, string invoiceDescriptions, double invoiceAmount)
        {
            if (string.IsNullOrWhiteSpace(invoiceInitials) || string.IsNullOrWhiteSpace(invoiceDescriptions) || invoiceAmount < 0 )
            {
                throw new ArgumentException("Invalid Invoice Type Data.");
            }

            if (string.IsNullOrWhiteSpace(invoiceInitials) || invoiceInitials.Length > 5)
                throw new ArgumentException("Invoice type initials must not be null or exceed 5 characters.");

            if (invoiceAmount <= 0)
                throw new ArgumentException("Invoice type amount must be greater than zero.");

            
            if (string.IsNullOrWhiteSpace(invoiceDescriptions) || invoiceDescriptions.Length > 75)
                throw new ArgumentException("Invoice type description must not be null or exceed 75 characters.");

            return new InvoiceTypes(invoiceTypesId, invoiceInitials, invoiceDescriptions, invoiceAmount);
        }



    }





}

