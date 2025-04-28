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
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Customers.Domain.Entities
{
	public class ComplaintType
	{
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ComplaintTypeId { get; set; }

        [Required]
        [StringLength(120)]
        public string? ComplaintTypes { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        public int DepartmentUnitId { get; set; }


        public ComplaintType(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            ComplaintTypeId = complaintTypeId;
            ComplaintTypes = complaintTypes;
            DepartmentId = departmentId;
            DepartmentUnitId = departmentUnitId;

        }

        public static ComplaintType Create(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypeId < 0 || departmentId == 0)
            {
                throw new ArgumentException("Invalid Complaint Type Data.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypes.Length > 120)
                throw new ArgumentException("Complaint Types must not be null or exceed 120 characters.");

            if (departmentId == 0)
                throw new ArgumentException("Department Id must be greater than zero.");


            return new ComplaintType(complaintTypeId, complaintTypes, departmentId, departmentUnitId);
        }

        public static ComplaintType Update(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypeId < 0)
            {
                throw new ArgumentException("Invalid Complaint Type Data.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypes.Length > 120)
                throw new ArgumentException("Complaint Types must not be null or exceed 120 characters.");

            if (departmentId == 0)
                throw new ArgumentException("Department Id must be greater than zero.");

            return new ComplaintType(complaintTypeId, complaintTypes, departmentId, departmentUnitId);

        }

    }
}

