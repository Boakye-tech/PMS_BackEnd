using System;
namespace Modules.Estates.Domain.Events.Complaints
{
	public class ComplaintStatusChangedEvent : DomainEvent
    {
		public string ComplaintNumber { get; set; }
        public ComplaintStatusEnum ComplaintStatus { get; set; }
        public string ActionBy { get; set; }


        public ComplaintStatusChangedEvent(string complaintNumber, ComplaintStatusEnum complaintStatus, string actionBy)
		{
            ComplaintNumber = complaintNumber;
            ComplaintStatus = complaintStatus;
            ActionBy = actionBy;
        }
	}
}

