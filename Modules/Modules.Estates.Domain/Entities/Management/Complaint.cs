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
	public class Complaint //: AuditableEntity
	{
        private readonly List<DomainEvent> _domainEvents = new();

        [NotMapped]
        public IReadOnlyCollection<DomainEvent> DomainEvents => _domainEvents.AsReadOnly();


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

        [StringLength(255)]
        public string? DocumentOne { get; set; }

        [StringLength(255)]
        public string? DocumentTwo { get; set; }

        [StringLength(255)]
        public string? DocumentThree { get; set; }

        public ComplaintStatusEnum ComplaintStatus { get; set; }

        [StringLength(36)]
        public int DispatachedTo_Department { get; set; }

        public int DispatachedTo_DepartmentUnit { get; set; }

        [StringLength(36)]
        public string? AssignedTo { get; set; }

        public string? Notes { get; set; }

        public ComplaintSourceEnum Source { get; set; }

        public Complaint()
        {
        }

        public Complaint(int complaintId, string complaintNumber, int complaintTypeId, string natureOfComplaintId,
                         string propertyNumber, string propertyLocation, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, string isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string documentOne, string documentTwo, string documentThree, ComplaintStatusEnum complaintStatus, string createdBy,
                         string reviewedBy, DateTime dateReviewed, string assignedTo, string assignedBy, DateTime dateAssigned,
                         string resolvedBy, DateTime resolutionDate, ComplaintSourceEnum Source,string notes)
        {
        }

        public static Complaint CreateNewComplaint(int complaintId, string complaintNumber, int complaintTypeId, string natureOfComplaintId,
                         string propertyNumber, string propertyLocation, string customerCode, string customerName,
                         string phoneNumber, string emailAddress, string isTheMatterInCourt, string detailsOfComplaint,
                         DateTime availabilityDate, DateTime complaintDate, string submittedBy, string submittedBy_PhoneNumber,
                         string documentOne, string documentTwo, string documentThree, ComplaintStatusEnum complaintStatus, ComplaintSourceEnum source, string createdBy)
        {
            if(complaintTypeId <= 0)
            {
                throw new ArgumentException("Complaint type id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(natureOfComplaintId))
            {
                throw new ArgumentException("Nature of complaint must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty");
            }

            if (string.IsNullOrWhiteSpace(propertyLocation))
            {
                throw new ArgumentException("Property location must not be null or empty");
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

            if (source == ComplaintSourceEnum.STAFF)
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
                DocumentOne = documentOne,
                DocumentTwo = documentTwo,
                DocumentThree = documentThree,
                ComplaintStatus = complaintStatus,
                DispatachedTo_Department = 0,
                DispatachedTo_DepartmentUnit = 0,
                AssignedTo = string.Empty,
                Notes = string.Empty,
                Source = source
            };

            _newComplaint._domainEvents.Add(new ComplaintCreatedEvent(complaintNumber, complaintStatus, createdBy));

            return _newComplaint;

        }





    }
}

