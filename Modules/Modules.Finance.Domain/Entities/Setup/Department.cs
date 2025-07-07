// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Department.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 10:49 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.Entities.Setup
{
    public class Department : AuditableEntity
    {
        [Key]
        [Required]
        public int DepartmentId { get; private set; }

        [Required]
        [StringLength(50)]
        public string? DepartmentName { get; private set; }

        //Navigation property for DepartmentUnits
        public virtual ICollection<DepartmentUnit> DepartmentUnits { get; private set; }

        public Department(int departmentId, string? departmentName)
        {
            DepartmentId = departmentId;
            DepartmentName = departmentName;
            DepartmentUnits = new List<DepartmentUnit>();
        }

        public static Department Create(int departmentId, string departmentName)
        {
            Validate(departmentId, departmentName);
            return new Department(departmentId, departmentName);
        }

        public void Update(int departmentId, string departmentName)
        {
            Validate(departmentId, departmentName);

            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        private static void Validate(int departmentId, string departmentName)
        {
            if (departmentId < 0 || string.IsNullOrWhiteSpace(departmentName))
            {
                throw new ArgumentException("Department Data.");
            }

            if (departmentId < 0)
                throw new ArgumentException("Department Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(departmentName) || departmentName.Length > 50)
                throw new ArgumentException("Department Name cannot be empty or exceed 50 characters.");
        }
    }
}

