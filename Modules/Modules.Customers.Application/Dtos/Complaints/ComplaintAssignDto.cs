using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintAssignDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [Required]
        [StringLength(36)]
        public string? AssignedTo { get; set; }

        [StringLength(36)]
        public string? AssignedBy { get; set; }
    }
}

