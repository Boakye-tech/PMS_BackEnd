// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Domain
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/06/2025
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Customers.Domain.Events
{
    public abstract class ComplaintDomainEvent
    {
        public string ComplaintNumber { get; }
        public DateTime OccurredOn { get; }

        protected ComplaintDomainEvent(string complaintNumber)
        {
            ComplaintNumber = complaintNumber;
            OccurredOn = DateTime.UtcNow;
        }
    }

    public class ComplaintSubmittedEvent : ComplaintDomainEvent
    {
        public Complaint Complaint { get; }
        public string SubmittedBy { get; }

        public ComplaintSubmittedEvent(Complaint complaint, string submittedBy)
            : base(complaint.ComplaintNumber!)
        {
            Complaint = complaint;
            SubmittedBy = submittedBy;
        }
    }

    public class ComplaintAssignedEvent : ComplaintDomainEvent
    {
        public string AssignedTo { get; }
        public string AssignedBy { get; }

        public ComplaintAssignedEvent(string complaintNumber, string assignedTo, string assignedBy)
            : base(complaintNumber)
        {
            AssignedTo = assignedTo;
            AssignedBy = assignedBy;
        }
    }

    public class ComplaintStatusChangedEvent : ComplaintDomainEvent
    {
        public ComplaintStatus OldStatus { get; }
        public ComplaintStatus NewStatus { get; }
        public string ChangedBy { get; }

        public ComplaintStatusChangedEvent(
            string complaintNumber,
            ComplaintStatus oldStatus,
            ComplaintStatus newStatus,
            string changedBy)
            : base(complaintNumber)
        {
            OldStatus = oldStatus;
            NewStatus = newStatus;
            ChangedBy = changedBy;
        }
    }

    public class ComplaintCancelledEvent : ComplaintDomainEvent
    {
        public string CancelledBy { get; }
        public string CancelNotes { get; }

        public ComplaintCancelledEvent(string complaintNumber, string cancelledBy, string cancelNotes)
            : base(complaintNumber)
        {
            CancelledBy = cancelledBy;
            CancelNotes = cancelNotes;
        }
    }

    public class ComplaintReopenedEvent : ComplaintDomainEvent
    {
        public string ReopenedBy { get; }
        public string ReopenNotes { get; }

        public ComplaintReopenedEvent(string complaintNumber, string reopenedBy, string reopenNotes)
            : base(complaintNumber)
        {
            ReopenedBy = reopenedBy;
            ReopenNotes = reopenNotes;
        }
    }

    public class ComplaintClosedEvent : ComplaintDomainEvent
    {
        public string ClosedBy { get; }
        public string CloseNotes { get; }

        public ComplaintClosedEvent(string complaintNumber, string closedBy, string closeNotes)
            : base(complaintNumber)
        {
            ClosedBy = closedBy;
            CloseNotes = closeNotes;
        }
    }

    public class ComplaintAcknowledgedEvent : ComplaintDomainEvent
    {
        public string AcknowledgedBy { get; }

        public ComplaintAcknowledgedEvent(string complaintNumber, string acknowledgedBy)
            : base(complaintNumber)
        {
            AcknowledgedBy = acknowledgedBy;
        }
    }

    public class ComplaintDispatchedEvent : ComplaintDomainEvent
    {
        public string DispatchedBy { get; }
        public int DepartmentId { get; }
        public int DepartmentUnitId { get; }

        public ComplaintDispatchedEvent(string complaintNumber,string dispatchedBy,int departmentId, int departmentUnitId): base(complaintNumber)
        {
            DispatchedBy = dispatchedBy;
            DepartmentId = departmentId;
            DepartmentUnitId = departmentUnitId;
        }
    }
}