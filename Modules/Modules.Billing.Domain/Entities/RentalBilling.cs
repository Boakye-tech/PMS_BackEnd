using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Billing.Domain.Entities
{
	public class RentalBilling : BillGenerationBaseEntity
    {
        [Required]
        public int NumberOfRooms { get; set; }

        [Required]
        public int UnitsOccupied { get; set; }

        [Required]
        public string? StartMonth { get; set; }

        [Required]
        public string? EndMonth { get; set; }

    }


}

