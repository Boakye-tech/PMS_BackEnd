using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class ComplaintType : AuditableEntity
	{
        [Key]
		public int ComplaintTypeId { get; set; }

        [StringLength(120)]
        public string? ComplaintTypes { get; set; }

        public int DepartmentId { get; set; }

        public int DepartmentUnitId { get; set; }


        public ComplaintType(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            ComplaintTypeId = complaintTypeId;
            ComplaintTypes = complaintTypes;
            DepartmentId = departmentId;
            DepartmentUnitId = departmentUnitId;
        }


        public static async Task<ComplaintType> Create(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, ICustomerDomainService customerDomainService)
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

            if(await customerDomainService.ComplaintTypeExist(complaintTypeId))
            {
                throw new ArgumentException("Complaint Type Id already exist");
            }

            if (await customerDomainService.ComplaintTypeExist(complaintTypes))
            {
                throw new ArgumentException("Complaint Type already exist");
            }


            return new ComplaintType(complaintTypeId, complaintTypes, departmentId, departmentUnitId);
        }

        public static async Task<ComplaintType> Update(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, ICustomerDomainService customerDomainService)
        {
            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypeId < 0 || departmentId == 0)
            {
                throw new ArgumentException("Invalid Complaint Type Data.");
            }


            if (!await customerDomainService.ComplaintTypeExist(complaintTypeId))
            {
                throw new ArgumentException("Complaint Type Id supplied does not exist.");
            }

            if (complaintTypeId < 0)
                throw new ArgumentException("Complaint Type Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(complaintTypes) || complaintTypes.Length > 120)
                throw new ArgumentException("Complaint Types must not be null or exceed 120 characters.");


            return new ComplaintType(complaintTypeId, complaintTypes,departmentId, departmentUnitId);

        }


    }
}

