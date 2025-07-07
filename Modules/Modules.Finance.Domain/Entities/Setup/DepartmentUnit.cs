// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/DepartmentUnit.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 10:51 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.Entities.Setup
{
    public class DepartmentUnit : AuditableEntity
    {
        [Required]
        public int DepartmentId { get; private set; }

        // Navigation property for Department
        public virtual Department? Department { get; private set; }

        [Key]
        [Required]
        public int UnitId { get; private set; }

        [Required]
        [StringLength(30)]
        public string? UnitName { get; private set; }

        public DepartmentUnit(int departmentId, int unitId, string? unitName)
        {
            DepartmentId = departmentId;
            UnitId = unitId;
            UnitName = unitName;
        }

        public static DepartmentUnit Create(int departmentId, int unitId, string unitName)
        {
            Validate(departmentId, unitId, unitName);
            return new DepartmentUnit(departmentId, unitId, unitName);
        }

        public void Update(int departmentId, int unitId, string unitName)
        {
            Validate(departmentId, unitId, unitName);

            DepartmentId = departmentId;
            UnitId = unitId;
            UnitName = unitName;
        }

        private static void Validate(int departmentId, int unitId, string unitName)
        {
            if (departmentId < 0 || unitId < 0 || string.IsNullOrWhiteSpace(unitName))
            {
                throw new ArgumentException("Department Unit Data.");
            }

            if (departmentId < 0)
                throw new ArgumentException("Department Id must be greater than or equal to zero.");

            if (unitId < 0)
                throw new ArgumentException("Unit Id must be greater than or equal to zero.");

            if (string.IsNullOrWhiteSpace(unitName) || unitName.Length > 30)
                throw new ArgumentException("Unit Name cannot be empty or exceed 30 characters.");
        }
    }
}

