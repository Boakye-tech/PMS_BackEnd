using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintReopenedDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [StringLength(36)]
        public string? ReopenedBy { get; set; }
    }
}

