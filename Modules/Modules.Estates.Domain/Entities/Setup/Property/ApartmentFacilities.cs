// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentFacilities.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ApartmentFacilities : AuditableEntity
    {
        [Key]
        [Required]
        public int ApartmentFacilitiesId { get; private set; }

        [Required]
        public int ApartmentTypeId { get; private set; }

        [Required]
        public int FacilityId { get; private set; }

        [Required]
        public decimal FloorArea { get; private set; }

        public ApartmentFacilities(int apartmentFacilitiesId, int apartmentTypeId, int facilityId, decimal floorArea)
        {
            ApartmentFacilitiesId = apartmentFacilitiesId;
            ApartmentTypeId = apartmentTypeId;
            FacilityId = facilityId;
            FloorArea = floorArea;
        }

        public static ApartmentFacilities Create(int apartmentFacilitiesId, int apartmentTypeId, int facilityId, decimal floorArea)
        {
            Validate(apartmentFacilitiesId, apartmentTypeId, facilityId, floorArea);
            return new ApartmentFacilities(apartmentFacilitiesId, apartmentTypeId, facilityId, floorArea);
        }

        public void Update(int apartmentFacilitiesId, int apartmentTypeId, int facilityId, decimal floorArea)
        {
            Validate(apartmentFacilitiesId, apartmentTypeId, facilityId, floorArea);

            ApartmentFacilitiesId = apartmentFacilitiesId;
            ApartmentTypeId = apartmentTypeId;
            FacilityId = facilityId;
            FloorArea = floorArea;
        }

        private static void Validate(int apartmentFacilitiesId, int apartmentTypeId, int facilityId, decimal floorArea)
        {
            if (apartmentFacilitiesId <= 0)
                throw new ArgumentException("Apartment Facilities Id must be greater than zero.");

            if (apartmentTypeId <= 0)
                throw new ArgumentException("Apartment Type Id must be greater than zero.");

            if (facilityId <= 0)
                throw new ArgumentException("Facility Id must be greater than zero.");

            if (floorArea <= 0)
                throw new ArgumentException("Floor Area must be greater than zero.");
        }

        public ApartmentFacilities()
        {
        }
    }
}

