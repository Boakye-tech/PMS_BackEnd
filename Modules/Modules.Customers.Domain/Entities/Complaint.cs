using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Customers.Domain.Entities
{
    public class Complaint : AuditableEntity
    {
        //private readonly List<DomainEvent> _domainEvents = new();

        //[NotMapped]
        //public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();


        [Key]
        [Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComplaintId { get; set; }

        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        public int ComplaintTypeId { get; set; }

        public int NatureOfComplaintId { get; set; }

        [Required]
        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [Required]
        public int PropertyLocationId { get; set; }

        //[Required]
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

        public bool IsTheMatterInCourt { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

        public DateTime AvailabilityDate { get; set; }

        public DateTime ComplaintDate { get; set; }

        [StringLength(300)]
        public string? SubmittedBy { get; set; }

        [StringLength(15)]
        public string? SubmittedBy_PhoneNumber { get; set; }

        [StringLength(255)]
        public string? DocumentOne { get; set; }

        [StringLength(255)]
        public string? DocumentTwo { get; set; }

        [StringLength(255)]
        public string? DocumentThree { get; set; }

        public int ComplaintStatus { get; set; }

        [StringLength(36)]
        public string? ReviewedBy { get; set; }

        public DateTime DateReviewed { get; set; }

        [StringLength(36)]
        public string? AssignedTo { get; set; }

        [StringLength(36)]
        public string? AssignedBy { get; set; }

        public DateTime DateAssigned { get; set; }

        [StringLength(36)]
        public string? ResolvedBy { get; set; }

        public DateTime ResolutionDate { get; set; }

        [StringLength(36)]
        public string? CancelledBy { get; set; }

        public DateTime CancelledDate { get; set; }


        public string? Notes { get; set; }

        public Complaint()
        {

        }

        public Complaint(int complaintId, string complaintNumber, int complaintTypeId, int natureOfComplaintId,
                         string propertyNumber, int propertyLocationId, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, bool isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string documentOne, string documentTwo, string documentThree, int complaintStatus, string createdBy,
                         string reviewedBy, DateTime dateReviewed, string assignedTo, string assignedBy, DateTime dateAssigned,
                         string resolvedBy, DateTime resolutionDate, string notes)
        {
        }

        public static Complaint CreateNewComplaint(int complaintId, string complaintNumber, int complaintTypeId, int natureOfComplaintId,
                         string propertyNumber, int propertyLocationId, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, bool isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string documentOne, string documentTwo, string documentThree, int complaintStatus, string createdBy)
        {
            if (complaintTypeId <= 0)
            {
                throw new ArgumentException("Complaint type id must be greater than zero.");
            }

            if (natureOfComplaintId <= 0)
            {
                throw new ArgumentException("Nature of complaint id must be greater than zero.");
            }

            if (propertyLocationId <= 0)
            {
                throw new ArgumentException("Property location id must be greater than zero.");

            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty");
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


            string _complaintNumber = new Random().Next(0, 100000).ToString();
            _complaintNumber = string.Concat("C", _complaintNumber);

            var _newComplaint = new Complaint
            {
                ComplaintId = complaintId,
                ComplaintNumber = _complaintNumber,
                ComplaintTypeId = complaintTypeId,
                NatureOfComplaintId = natureOfComplaintId,
                PropertyNumber = propertyNumber,
                PropertyLocationId = propertyLocationId,
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
                DocumentOne = documentOne,
                DocumentTwo = documentTwo,
                DocumentThree = documentThree,
                ComplaintStatus = complaintStatus,
                CreatedBy = createdBy,
                ReviewedBy = string.Empty,
                DateReviewed = Convert.ToDateTime("1900-01-01"),
                AssignedTo = string.Empty,
                AssignedBy = string.Empty,
                DateAssigned = Convert.ToDateTime("1900-01-01"),
                ResolvedBy = string.Empty,
                ResolutionDate = Convert.ToDateTime("1900-01-01"),
                Notes = string.Empty
            };

            //_newComplaint._domainEvents.Add(new ComplaintCreatedEvent(_complaintNumber, natureOfComplaintId.ToString(), propertyNumber, createdBy));

            return _newComplaint;

        }



    }
}

