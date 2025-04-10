using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Customers.Domain.Entities
{
	public class ComplaintType
	{
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComplaintTypeId { get; set; }

        [Required]
        [StringLength(120)]
        public string? ComplaintTypes { get; set; }

        public ComplaintType(int complaintTypeId, string complaintTypes)
        {
            ComplaintTypeId = complaintTypeId;
            ComplaintTypes = complaintTypes;
        }

        public static ComplaintType Create(int complaintTypeId, string complaintTypes)
        {
            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypeId < 0)
            {
                throw new ArgumentException("Invalid Complaint Type Data.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypes.Length > 120)
                throw new ArgumentException("Complaint Types must not be null or exceed 120 characters.");


            return new ComplaintType(complaintTypeId, complaintTypes);
        }

        public static ComplaintType Update(int complaintTypeId, string complaintTypes)
        {
            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypeId < 0)
            {
                throw new ArgumentException("Invalid Complaint Type Data.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypes.Length > 120)
                throw new ArgumentException("Complaint Types must not be null or exceed 120 characters.");


            return new ComplaintType(complaintTypeId, complaintTypes);

        }

    }
}

