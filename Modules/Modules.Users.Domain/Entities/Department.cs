using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
    public class Department
    {
        [Key]
        public required int DepartmentId { get; set; }

        public required string DepartmentName { get; set; }

    }
}


