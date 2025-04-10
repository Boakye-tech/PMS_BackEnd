using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class ComplaintStatuses
	{
        [Key]
        [Required]
        public int ComplaintStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string? ComplaintStatus { get; set; }
    }
}

