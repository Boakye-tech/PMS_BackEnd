using System;
namespace Modules.Estates.Domain.Events.Complaints
{
	public class ComplaintCreatedEvent : DomainEvent
	{
        public string ComplaintNumber { get; }
        public ComplaintStatusEnum ComplaintStatus { get; set; }
        public string CreatedBy { get; }


        public ComplaintCreatedEvent(string complaintNumber, ComplaintStatusEnum complaintStatus, string createdBy)
		{
            ComplaintNumber = complaintNumber;
            ComplaintStatus = complaintStatus;
            CreatedBy = createdBy;
		}
	}

    
}

