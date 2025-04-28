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

namespace Modules.Customers.Domain.Entities
{
	public class NatureOfComplaint
	{
        [Required]
        public int ComplaintTypeId { get; set; }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NatureOfComplaintId { get; set; }

        [Required]
        [StringLength(75)]
        public string? NatureOfComplaints { get; set; }

        public NatureOfComplaint(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
        {
            ComplaintTypeId = complaintTypeId;
            NatureOfComplaintId = natureOfComplaintId;
            NatureOfComplaints = natureOfComplaints;
        }

        public static NatureOfComplaint Create(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
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


            return new NatureOfComplaint(complaintTypeId, natureOfComplaintId, natureOfComplaints);

        }

        public static NatureOfComplaint Update(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
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


            return new NatureOfComplaint(complaintTypeId, natureOfComplaintId, natureOfComplaints);

        }
    }
}

