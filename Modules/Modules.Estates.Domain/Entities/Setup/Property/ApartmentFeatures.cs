// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentFeatures.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using AutoMapper.Features;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ApartmentFeatures : AuditableEntity
    {
        [Required]
        public ApartmentCategoryEnum ApartmentCategory { get; set; }

        [Required]
        public int ApartmentTypeId { get; private set; }

        [Key]
        [Required]
        public int ApartmentFeaturesId { get; private set; }

        [Required]
        [StringLength(50)]
        public string Feature { get; private set; }

        [Required]
        public decimal FloorArea { get; private set; }

        public ApartmentFeatures(ApartmentCategoryEnum apartmentCategory, int apartmentFeaturesId, int apartmentTypeId, string feature, decimal floorArea)
        {
            ApartmentCategory = apartmentCategory;
            ApartmentFeaturesId = apartmentFeaturesId;
            ApartmentTypeId = apartmentTypeId;
            Feature = feature;
            FloorArea = floorArea;
        }

        public static ApartmentFeatures Create(ApartmentCategoryEnum apartmentCategory, int apartmentFeaturesId, int apartmentTypeId, string feature, decimal floorArea)
        {
            Validate(apartmentFeaturesId, apartmentTypeId, feature, floorArea);
            return new ApartmentFeatures(apartmentCategory, apartmentFeaturesId, apartmentTypeId, feature, floorArea);
        }

        public void Update(int apartmentFeaturesId, int apartmentTypeId, string feature, decimal floorArea)
        {
            Validate(apartmentFeaturesId, apartmentTypeId, feature, floorArea);

            ApartmentFeaturesId = apartmentFeaturesId;
            ApartmentTypeId = apartmentTypeId;
            Feature = feature;
            FloorArea = floorArea;
        }

        private static void Validate(int apartmentFeaturesId, int apartmentTypeId, string feature, decimal floorArea)
        {
            if (apartmentFeaturesId < 0)
                throw new ArgumentException("Apartment Feature Id must be greater than zero.");

            if (apartmentTypeId <= 0)
                throw new ArgumentException("Apartment Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(feature))
                throw new ArgumentException("Feature cannot be empty or exceed 50 characters.");

            if (floorArea < 0)
                throw new ArgumentException("Floor Area must be greater than zero.");
        }


    }
}