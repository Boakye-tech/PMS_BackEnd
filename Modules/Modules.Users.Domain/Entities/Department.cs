// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Domain/Entities/Department.cs
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
    public class Department : AuditableEntity
    {
        [Key]
        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(3)]
        public string DepartmentInitial { get; set; }

        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        //Navigation property for DepartmentUnits
        public virtual ICollection<DepartmentUnit> DepartmentUnits { get; private set; }

        public Department(int departmentId, string departmentInitial, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            DepartmentInitial = departmentInitial;
            DepartmentUnits = new List<DepartmentUnit>();
        }

        public static Department Create(int departmentId, string departmentInitial, string departmentName)
        {
            if (string.IsNullOrWhiteSpace(departmentName) || string.IsNullOrWhiteSpace(departmentInitial) || departmentId != 0)
            {
                throw new ArgumentException("Invalid department data.");
            }

            if (departmentId != 0)
                throw new ArgumentException("The department id must be equal to zero.");

            if (string.IsNullOrWhiteSpace(departmentInitial) || departmentInitial.Length > 3)
                throw new ArgumentException("The department initial must not be null or exceed 3 characters.");

            if (string.IsNullOrWhiteSpace(departmentName) || departmentName.Length > 50)
                throw new ArgumentException("The department name must not be null or exceed 50 characters.");

            return new Department(departmentId, departmentInitial, departmentName);
        }

        public static Department Update(int departmentId, string departmentInitial, string departmentName)
        {
            if (string.IsNullOrWhiteSpace(departmentName) || string.IsNullOrWhiteSpace(departmentInitial) || departmentId < 0)
            {
                throw new ArgumentException("Invalid department data.");
            }

            if (departmentId <= 0)
                throw new ArgumentException("The department id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(departmentInitial) || departmentInitial.Length > 3)
                throw new ArgumentException("The department initial must not be null or exceed 3 characters.");

            if (string.IsNullOrWhiteSpace(departmentName) || departmentName.Length > 50)
                throw new ArgumentException("The department name must not be null or exceed 50 characters.");

            return new Department(departmentId, departmentInitial, departmentName);
        }



    }
}


