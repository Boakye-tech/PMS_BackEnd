using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Complaints
{
	public record ComplaintAssignDto
	{
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [Required]
        [StringLength(36)]
        public string? AssignedTo { get; set; }

        [Required]
        [StringLength(36)]
        public string? AssignedBy { get; set; }
    }
}

