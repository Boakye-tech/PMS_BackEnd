using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class ComplaintStatuses : AuditableEntity
	{
        [Key]
        [Required]
        public int ComplaintStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string? ComplaintStatus { get; set; }

        [Required]
        [StringLength(255)]
        public string? Description { get; set; }


        public ComplaintStatuses(int complaintStatusId, string complaintStatus, string description)
        {
            ComplaintStatusId = complaintStatusId;
            ComplaintStatus = complaintStatus;
            Description = description;
        }

        public static ComplaintStatuses CreateUpdate(int complaintStatusId, string complaintStatus, string description)
        {
            if (string.IsNullOrWhiteSpace(complaintStatus) || complaintStatusId < 0 || string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Invalid Complaint Status Data.");
            }

            if (complaintStatusId < 0)
                throw new ArgumentException("Complaint Status Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(complaintStatus) || complaintStatus.Length > 20)
                throw new ArgumentException("Complaint Status must not be null or exceed 20 characters.");

            if (string.IsNullOrWhiteSpace(description) || complaintStatus.Length > 255)
                throw new ArgumentException("Complaint Status description must not be null or exceed 255 characters.");


            return new ComplaintStatuses(complaintStatusId, complaintStatus, description);
        }
    }
}

