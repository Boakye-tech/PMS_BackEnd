using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class NatureOfComplaint : AuditableEntity
	{
        [Required]
        public int ComplaintTypeId { get; set; }

        [Key]
        [Required]
        public int NatureOfComplaintId { get; set; }

        [Required]
        [StringLength(75)]
        public string NatureOfComplaints { get; set; }


        public NatureOfComplaint(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
        {
            ComplaintTypeId = complaintTypeId;
            NatureOfComplaintId = natureOfComplaintId;
            NatureOfComplaints = natureOfComplaints;
        }

        public static async Task<NatureOfComplaint> Create(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, ICustomerDomainService customerDomainService)
        {
            if (string.IsNullOrWhiteSpace(natureOfComplaints) || complaintTypeId < 0 || natureOfComplaintId < 0)
            {
                throw new ArgumentException("Invalid Nature Of Complaint Data.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (natureOfComplaintId < 0)
                throw new ArgumentException("Nature Of Complaint Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(natureOfComplaints) || natureOfComplaints.Length > 75)
                throw new ArgumentException("Nature Of Complaint must not be null or exceed 75 characters.");

            if (await customerDomainService.NatureOfComplaintExist(natureOfComplaintId))
            {
                throw new ArgumentException("Nature Of Complaint Id already exist");
            }

            if (await customerDomainService.NatureOfComplaintExist(natureOfComplaints))
            {
                throw new ArgumentException("Nature Of Complaint already exist");
            }

            return new NatureOfComplaint(complaintTypeId, natureOfComplaintId, natureOfComplaints);

        }

        public static async Task<NatureOfComplaint> Update(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, ICustomerDomainService customerDomainService)
        {
            if (string.IsNullOrWhiteSpace(natureOfComplaints) || complaintTypeId < 0 || natureOfComplaintId < 0)
            {
                throw new ArgumentException("Invalid Nature Of Complaint Data.");
            }

            if (!await customerDomainService.NatureOfComplaintExist(complaintTypeId))
            {
                throw new ArgumentException("Complaint Type Id supplied does not exist.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (natureOfComplaintId < 0)
                throw new ArgumentException("Nature Of Complaint Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(natureOfComplaints) || natureOfComplaints.Length > 75)
                throw new ArgumentException("Nature Of Complaint must not be null or exceed 75 characters.");


            return new NatureOfComplaint(complaintTypeId, natureOfComplaintId, natureOfComplaints);

        }

    }
}

