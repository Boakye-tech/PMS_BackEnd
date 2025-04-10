using System;
namespace Modules.Estates.Domain.Events.Complaints
{
	public class ComplaintCreatedEvent : DomainEvent
	{
        public string ComplaintNumber { get; }
        public string NatureOfComplaint { get; }
        public string PropertyNumber { get; }
        public string CreatedBy { get; }


        public ComplaintCreatedEvent(string complaintNumber, string natureOfComplaint, string propertyNumber, string createdBy)
		{
            ComplaintNumber = complaintNumber;
            NatureOfComplaint = natureOfComplaint;
            PropertyNumber = propertyNumber;
            CreatedBy = createdBy;
		}
	}
}

