// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using Modules.Customers.Domain.Events;

namespace Modules.Customers.Domain.Entities
{
    public class Complaint //: AuditableEntity
    {
        private readonly List<ComplaintDomainEvent> _domainEvents = new();

        public IReadOnlyCollection<ComplaintDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

        public void AddDomainEvent(ComplaintDomainEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }

        [Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComplaintId { get; set; }

        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        public int ComplaintTypeId { get; set; }

        [StringLength(50)]
        public string? NatureOfComplaintId { get; set; }

        [Required]
        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(75)]
        public string? PropertyLocation { get; set; }

        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(200)]
        public string? CustomerName { get; set; }

        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(75)]
        public string? EmailAddress { get; set; }

        [StringLength(3)]
        public string? IsTheMatterInCourt { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

        public DateTime AvailabilityDate { get; set; }

        public DateTime ComplaintDate { get; set; }

        [StringLength(300)]
        public string? SubmittedBy { get; set; }

        [StringLength(15)]
        public string? SubmittedBy_PhoneNumber { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string[]? DocumentList { get; set; }

        public ComplaintStatus ComplaintStatus { get; set; }

        [StringLength(36)]
        public int DispatachedTo_Department { get; set; }

        public int DispatachedTo_DepartmentUnit { get; set; }

        [StringLength(36)]
        public string? AssignedTo { get; set; }

        public string? Notes { get; set; }

        public ComplaintSource Source { get; set; }

        public string? ReviewNotes { get; set; }

        public string? CancelNotes { get; set; }

        public string? ReopenNotes { get; set; }

        public string? ClosedNotes { get; set; }

        public Complaint()
        {

        }

        public Complaint(int complaintId, string complaintNumber, int complaintTypeId, string natureOfComplaintId,
                         string propertyNumber, string propertyLocation, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, string isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string[] documentList, ComplaintStatus complaintStatus,
                         string reviewedBy, DateTime dateReviewed, string assignedTo, string assignedBy, DateTime dateAssigned,
                         string resolvedBy, DateTime resolutionDate, string notes, ComplaintSource source, string ReviewNotes, string CancelNotes, string ReopenNotes, string ClosedNotes)
        {
        }

        public static Complaint CreateNewComplaint(int complaintId, string complaintNumber, int complaintTypeId, string natureOfComplaintId,
                         string propertyNumber, string propertyLocation, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, string isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string[] documentList, ComplaintStatus complaintStatus, ComplaintSource source)
        {
            if (complaintTypeId <= 0)
            {
                throw new ArgumentException("Complaint type id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(natureOfComplaintId))
            {
                throw new ArgumentException("Nature of complaint must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(propertyLocation))
            {
                throw new ArgumentException("Property locatiion must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerCode))
            {
                throw new ArgumentException("Customer code must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentException("Customer name must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(phoneNumber))
            {
                throw new ArgumentException("Phone number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(detailsOfComplaint))
            {
                throw new ArgumentException("Complaint details must not be null or empty");
            }

            if (source == ComplaintSource.CUSTOMER)
            {
                string _complaintNumber = new Random().Next(0, 100000).ToString();
                complaintNumber = string.Concat("C", _complaintNumber);
            }

            var _newComplaint = new Complaint
            {
                ComplaintId = complaintId,
                ComplaintNumber = complaintNumber,
                ComplaintTypeId = complaintTypeId,
                NatureOfComplaintId = natureOfComplaintId,
                PropertyNumber = propertyNumber,
                PropertyLocation = propertyLocation,
                CustomerCode = customerCode,
                CustomerName = customerName,
                PhoneNumber = phoneNumber,
                EmailAddress = emailAddress,
                IsTheMatterInCourt = isTheMatterInCourt,
                DetailsOfComplaint = detailsOfComplaint,
                AvailabilityDate = availabilityDate,
                ComplaintDate = DateTime.UtcNow,
                SubmittedBy = submittedBy,
                SubmittedBy_PhoneNumber = submittedBy_PhoneNumber,
                DocumentList = documentList,
                ComplaintStatus = complaintStatus,
                DispatachedTo_Department = 0,
                DispatachedTo_DepartmentUnit = 0,
                AssignedTo = string.Empty,
                Notes = string.Empty,
                Source = source,
                ReviewNotes = string.Empty,
                ReopenNotes = string.Empty,
                ClosedNotes = string.Empty,
                CancelNotes = string.Empty
            };

            _newComplaint.AddDomainEvent(new ComplaintSubmittedEvent(_newComplaint, submittedBy));

            return _newComplaint;
        }

        public void ChangeStatus(ComplaintStatus newStatus, string changedBy)
        {
            var oldStatus = ComplaintStatus;
            ComplaintStatus = newStatus;
            AddDomainEvent(new ComplaintStatusChangedEvent(ComplaintNumber!, oldStatus, newStatus, changedBy));
        }

        public void Assign(string assignedTo, string assignedBy)
        {
            AssignedTo = assignedTo;
            AddDomainEvent(new ComplaintAssignedEvent(ComplaintNumber!, assignedTo, assignedBy));
        }

        public void Cancel(string cancelledBy, string cancelNotes)
        {
            CancelNotes = cancelNotes;
            ComplaintStatus = ComplaintStatus.CANCELLED;
            AddDomainEvent(new ComplaintCancelledEvent(ComplaintNumber!, cancelledBy, cancelNotes));
        }

        public void Reopen(string reopenedBy, string reopenNotes)
        {
            ReopenNotes = reopenNotes;
            ComplaintStatus = ComplaintStatus.REOPEN;
            AddDomainEvent(new ComplaintReopenedEvent(ComplaintNumber!, reopenedBy, reopenNotes));
        }

        public void Close(string closedBy, string closeNotes)
        {
            ClosedNotes = closeNotes;
            ComplaintStatus = ComplaintStatus.CLOSED;
            AddDomainEvent(new ComplaintClosedEvent(ComplaintNumber!, closedBy, closeNotes));
        }

        public void Acknowledge(string acknowledgedBy)
        {
            ComplaintStatus = ComplaintStatus.ACKNOWLEDGED;
            AddDomainEvent(new ComplaintAcknowledgedEvent(ComplaintNumber!, acknowledgedBy));
        }

        public void Dispatch(string dispatchedBy, int departmentId, int departmentUnitId)
        {
            DispatachedTo_Department = departmentId;
            DispatachedTo_DepartmentUnit = departmentUnitId;
            ComplaintStatus = ComplaintStatus.DISPATCHED;
            AddDomainEvent(new ComplaintDispatchedEvent(ComplaintNumber!, dispatchedBy, departmentId, departmentUnitId));
        }
    }
}

