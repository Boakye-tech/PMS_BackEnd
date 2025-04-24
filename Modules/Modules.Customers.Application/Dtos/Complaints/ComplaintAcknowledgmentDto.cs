using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintAcknowledgmentDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [StringLength(36)]
        public string? AcknowledgedBy { get; set; }
    }
}

