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
    public class Department : AuditableEntity
    {
        [Key]
        [Required]
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string DepartmentName { get; set; }

        public Department(int departmentId, string departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public static Department CreateUpdate(int departmentId, string departmentName)
        {
            if (string.IsNullOrWhiteSpace(departmentName) || departmentId < 0)
            {
                throw new ArgumentException("Invalid department data.");
            }

            if (departmentId <= 0)
                throw new ArgumentException("The department id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(departmentName) || departmentName.Length > 50)
                throw new ArgumentException("The department name must not be null or exceed 50 characters.");

            return new Department(departmentId, departmentName);
        }

    }
}


