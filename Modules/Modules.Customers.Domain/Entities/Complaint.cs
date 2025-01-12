using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Domain.Entities
{
	public class Complaint
	{
		[Key]
		public int ComplaintId { get; set; }

        [Required]
        [StringLength(20)]
        public string? ComplaintNumber { get; set; }

        [Required]
        [StringLength(25)]
        public string? PropertyNumber { get; set; }

        [Required]
        [StringLength(250)]
        public string? CustomerCode { get; set; }

		public string? CustomerName { get; set; }

        [Required]
        [StringLength(12)]
        public string? PhoneNumber { get; set; }

        [Required]
        [StringLength(75)]
        public string? EmailAddress { get; set; }

        [Required]
        [StringLength(30)]
        public string? Locality { get; set; }

        [Required]
        public string? DetailsOfComplaint { get; set; }

		public bool IsTheMatterInCourt { get; set; }

		public DateTime ComplaintDate { get; set; }

		public string? SubmittedBy { get; set; }

        [StringLength(255)]
        public string? DocumentOne { get; set; }

        [StringLength(255)]
        public string? DocumentTwo { get; set; }

        [StringLength(255)]
        public string? DocumentThree { get; set; }

        [StringLength(50)]
        public string ?CreatedBy { get; set; }

	}
}

