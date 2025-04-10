﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
	public class ComplaintCreateDto
	{
        [Required]
        public int ComplaintTypeId { get; set; }

        [Required]
        public int NatureOfComplaintId { get; set; }

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

        //public DateTime ComplaintDate { get; set; }

        [StringLength(300)]
        public string? SubmittedBy { get; set; }

        [StringLength(15)]
        public string? SubmittedBy_PhoneNumber { get; set; }

        public string[]? DocumentImages { get; set; }

        //[StringLength(255)]
        //public string? DocumentOne { get; set; }

        //[StringLength(255)]
        //public string? DocumentTwo { get; set; }

        //[StringLength(255)]
        //public string? DocumentThree { get; set; }

        //public int ComplaintStatus { get; set; }

        [StringLength(36)]
        public string? CreatedBy { get; set; }
    }
}

