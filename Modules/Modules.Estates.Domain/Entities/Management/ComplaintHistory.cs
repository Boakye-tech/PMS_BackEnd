// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Management
{
	public class ComplaintHistory
	{
        private readonly List<DomainEvent> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();


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

        public static ComplaintHistory ProcessComplaint(int complaintHistoryId, string? complaintNumber, ComplaintStatusEnum complaintStatus, string? actionBy, DateTime actionOn)
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

            //fire domain event, when the complaint status changes
            _newComplaintHistory._domainEvents.Add(new ComplaintStatusChangedEvent(complaintNumber, complaintStatus, actionBy));

            return _newComplaintHistory;

        }

        public void ClearDomainEvents() => _domainEvents.Clear();

    }
}

