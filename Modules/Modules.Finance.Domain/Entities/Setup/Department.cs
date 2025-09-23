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
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Finance.Domain.Entities.Setup
{
    public class Department : AuditableEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DepartmentId { get; private set; }

        [Required]
        [StringLength(3)]
        public string? DepartmentInitial { get; set; }

        [Required]
        [StringLength(50)]
        public string? DepartmentName { get; private set; }

        //Navigation property for DepartmentUnits
        public virtual ICollection<DepartmentUnit>? DepartmentUnits { get; private set; }

        //Navigation property for InvoiceTypes
        public virtual InvoiceTypes? InvoiceTypes { get; private set; }

        public Department(int departmentId, string departmentInitial, string? departmentName)
        {
            DepartmentId = departmentId;
            DepartmentInitial = departmentInitial;
            DepartmentName = departmentName;
            DepartmentUnits = new List<DepartmentUnit>();
            //InvoiceTypes = new InvoiceTypes;
        }

        public static Department Create(int departmentId, string departmentInitial, string departmentName)
        {
            Validate(departmentId, departmentInitial, departmentName);
            return new Department(departmentId, departmentInitial, departmentName);
        }

        public void Update(int departmentId, string departmentInitial, string departmentName)
        {
            Validate(departmentId, departmentInitial, departmentName);

            DepartmentId = departmentId;
            DepartmentInitial = departmentInitial;
            DepartmentName = departmentName;
        }

        private static void Validate(int departmentId,string departmentInitial, string departmentName)
        {
            if (departmentId <= 0 || string.IsNullOrWhiteSpace(departmentInitial) || string.IsNullOrWhiteSpace(departmentName))
            {
                throw new ArgumentException("Department Data.");
            }

            if (departmentId <= 0)
                throw new ArgumentException("Department Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(departmentInitial) || departmentInitial.Length > 3)
                throw new ArgumentException("Department Initials cannot be empty or exceed 3 characters.");

            if (string.IsNullOrWhiteSpace(departmentName) || departmentName.Length > 50)
                throw new ArgumentException("Department Name cannot be empty or exceed 50 characters.");
        }
    }
}

