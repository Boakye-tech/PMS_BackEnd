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

namespace Modules.Users.Domain.Entities
{
	public class DepartmentUnit : AuditableEntity
    {
		[Required]
		public int DepartmentId { get; set; }

        // Navigation property for Department
        public virtual Department? Department { get; private set; }

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

        public static DepartmentUnit Create(int departmentId, int unitId, string unitName)
        {
            if (string.IsNullOrWhiteSpace(unitName) || departmentId < 0 || unitId != 0)
            {
                throw new ArgumentException("Invalid department unit data.");
            }

            if (departmentId < 0)
                throw new ArgumentException("The department id must be greater than zero.");

            if (unitId != 0)
                throw new ArgumentException("The department unit id must be equal to zero.");

            if (string.IsNullOrWhiteSpace(unitName) || unitName.Length > 30)
                throw new ArgumentException("The department unit name must not be null or exceed 50 characters.");

            return new DepartmentUnit(departmentId, unitId, unitName);
        }

        public static DepartmentUnit Update(int departmentId, int unitId, string unitName)
        {
            if (string.IsNullOrWhiteSpace(unitName) || departmentId < 0 || unitId < 0)
            {
                throw new ArgumentException("Invalid department unit data.");
            }

            if (departmentId < 0)
                throw new ArgumentException("The department id must be greater than zero.");

            if (unitId <= 0)
                throw new ArgumentException("The department unit id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(unitName) || unitName.Length > 30)
                throw new ArgumentException("The department unit name must not be null or exceed 50 characters.");

            return new DepartmentUnit(departmentId, unitId, unitName);
        }
    }
}

