using System;
using System.ComponentModel.DataAnnotations;
using Modules.Customers.Domain.Enums;

namespace Modules.Customers.Application.Dtos.Complaints
{
	public class ComplaintCreateDto
	{

        [Required]
        public int ComplaintTypeId { get; set; }

        [Required]
        public int[]? NatureOfComplaintId { get; set; }

        //[Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        [Required]
        public int PropertyLocationId { get; set; }

        //[Required]
        [StringLength(10)]
        public string? CustomerCode { get; set; }

        [Required]
        [StringLength(200)]
        public string? CustomerName { get; set; }

        [Required]
        [StringLength(15)]
        public string? PhoneNumber { get; set; }

        //[Required]
        [StringLength(75)]
        public string? EmailAddress { get; set; }

        public bool IsTheMatterInCourt { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

        public DateTime AvailabilityDate { get; set; }

        [StringLength(300)]
        public string? SubmittedBy { get; set; }

        [StringLength(15)]
        public string? SubmittedBy_PhoneNumber { get; set; }

        public string[]? DocumentImages { get; set; }

        public ComplaintSource Source { get; set; }

        [StringLength(36)]
        public string? CreatedBy { get; set; }
    }
}

