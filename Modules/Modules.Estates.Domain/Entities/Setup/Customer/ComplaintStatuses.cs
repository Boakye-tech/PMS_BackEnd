using System;
namespace Modules.Estates.Domain.Entities.Setup.Customer
{
	public class ComplaintStatuses : AuditableEntity
	{
        [Key]
        [Required]
        public int ComplaintStatusId { get; set; }

        [Required]
        [StringLength(20)]
        public string? ComplaintStatus { get; set; }

    }
}

