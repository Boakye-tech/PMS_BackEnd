﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Paypoints : AuditableEntity
	{
        [Key]
        [Required]
        public int PaypointId { get; set; }

        [Required]
        [StringLength(30)]
        public string? Paypoint { get; set; }

        public Paypoints(int paypointId, string paypoint)
		{
            PaypointId = paypointId;
            Paypoint = paypoint;
		}

        public static Paypoints CreateUpdate(int paypointId, string paypoint)
        {
            if (string.IsNullOrWhiteSpace(paypoint) || paypointId < 0)
            {
                throw new ArgumentException("Invalid Pay Point Data.");
            }

            if (paypointId <= -1)
                throw new ArgumentException("The pay point id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(paypoint) || paypoint.Length > 30)
                throw new ArgumentException("The pay point must not be null or exceed 30 characters.");

            return new Paypoints(paypointId, paypoint);
        }

    }



}
