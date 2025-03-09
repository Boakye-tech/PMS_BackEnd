using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Billing.Domain.Entities
{
	public class NonRentalBilling : BillGenerationBaseEntity
    {

        [Required]
        public int LandUseId { get; set; }

        public int LandUseTypeId { get; set; }

        [Required]
        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }


        public NonRentalBilling()
        {

        }

    }
}

