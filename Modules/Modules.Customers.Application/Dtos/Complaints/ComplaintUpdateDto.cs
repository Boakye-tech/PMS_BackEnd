using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintUpdateDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        [StringLength(75)]
        public string? EmailAddress { get; set; }

        public bool IsTheMatterInCourt { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

        public DateTime AvailabilityDate { get; set; }

        public string[]? DocumentImages { get; set; }

        [StringLength(36)]
        public string? ModifiedBy { get; set; }

    }
}

