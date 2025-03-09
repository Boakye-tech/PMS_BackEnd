using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class ApartmentFacilities
	{
        [Key]
        public int ApartmentFacilitiesId { get; set; }

        public int ApartmentTypeId { get; set; }

        public int FacilityId { get; set; }

        public decimal FloorArea { get; set; }


        public ApartmentFacilities()
		{
		}
	}
}

