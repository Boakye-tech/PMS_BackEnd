using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class ComplaintType : AuditableEntity
	{
        [Key]
        [Required]
		public int ComplaintTypeId { get; set; }

        [Required]
        [StringLength(120)]
        public string ComplaintTypes { get; set; }


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

