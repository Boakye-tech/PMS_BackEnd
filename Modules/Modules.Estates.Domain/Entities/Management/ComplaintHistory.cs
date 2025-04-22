using System;
using System.Net.NetworkInformation;

namespace Modules.Estates.Domain.Entities.Management
{
	public class ComplaintHistory
	{
        [Key]
		public int ComplaintHistoryId { get; set; }

        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [Required]
        public ComplaintStatusEnum ComplaintStatus { get; set; }

        [Required]
        [StringLength(36)]
        public string? ActionBy { get; set; }

        [Required]
        public DateTime ActionOn { get; set; }


        public ComplaintHistory()
		{
		}

        public ComplaintHistory(int complaintHistoryId, string? complaintNumber, ComplaintStatusEnum complaintStatus, string? actionBy, DateTime actionOn)
        {
        }

        public static ComplaintHistory Create(int complaintHistoryId, string? complaintNumber, ComplaintStatusEnum complaintStatus, string? actionBy, DateTime actionOn)
        {
            if (string.IsNullOrWhiteSpace(complaintNumber))
            {
                throw new ArgumentException("Complaint number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(actionBy))
            {
                throw new ArgumentException("Action by must not be null or empty");
            }


            var _newComplaintHistory = new ComplaintHistory
            {
                ComplaintHistoryId = complaintHistoryId,
                ComplaintNumber = complaintNumber,
                ComplaintStatus = complaintStatus,
                ActionBy = actionBy,
                ActionOn = actionOn
            };

            return _newComplaintHistory;

        }




    }
}

