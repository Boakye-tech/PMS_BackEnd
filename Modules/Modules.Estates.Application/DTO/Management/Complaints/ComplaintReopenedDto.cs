using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Complaints
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

