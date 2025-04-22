using System;
using Modules.Estates.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Complaints
{
	public record ComplaintHistoryDto
	{
        [Key]
        public int ComplaintHistoryId { get; set; }

        [StringLength(10)]
        public required string ComplaintNumber { get; set; }

        public required ComplaintStatusEnum ComplaintStatus { get; set; }

        [StringLength(36)]
        public required string ActionBy { get; set; }

        public required DateTime ActionOn { get; set; }
    }
}

