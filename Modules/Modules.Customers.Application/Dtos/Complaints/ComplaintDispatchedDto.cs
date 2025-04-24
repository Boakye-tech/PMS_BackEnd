using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintDispatchedDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [StringLength(36)]
        public string? DispatchedBy { get; set; }

        [Required]
        public int DispatchedTo_DepartmentId { get; set; }

        public int DispatchedTo_DepartmentUnitId { get; set; }

    }
}

