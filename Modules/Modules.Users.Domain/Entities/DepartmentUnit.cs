using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class DepartmentUnit : AuditableEntity
    {
		[Required]
		public int DepartmentId { get; set; }

		[Key]
		[Required]
        public int UnitId { get; set; }

		[Required]
		[StringLength(30)]
        public string UnitName { get; set; }

		public DepartmentUnit(int departmentId, int unitId, string unitName)
		{
			DepartmentId = departmentId;
			UnitId = unitId;
			UnitName = unitName;
        }

        public static DepartmentUnit CreateUpdate(int departmentId, int unitId, string unitName)
        {
            if (string.IsNullOrWhiteSpace(unitName) || departmentId < 0 || unitId < 0)
            {
                throw new ArgumentException("Invalid department unit data.");
            }

            if (departmentId <= 0)
                throw new ArgumentException("The department id must be greater than zero.");

            if (unitId <= 0)
                throw new ArgumentException("The department unit id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(unitName) || unitName.Length > 30)
                throw new ArgumentException("The department unit name must not be null or exceed 50 characters.");

            return new DepartmentUnit(departmentId, unitId, unitName);
        }
    }
}

