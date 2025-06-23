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

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ApartmentFeatures : AuditableEntity
    {
        [Key]
        [Required]
        public int ApartmentFeaturesId { get; private set; }


        [Required]
        public ApartmentCategoryEnum ApartmentCategory { get; set; }

        [Required]
        public int ApartmentTypeId { get; private set; }

        // Navigation property for ApartmentType
        public virtual ApartmentTypes? ApartmentType { get; private set; }

        [Required]
        public int FeaturesId { get; private set; }

        // Navigation property for Features
        public virtual ICollection<Features> Features { get; private set; }

        [Required]
        public decimal FloorArea { get; private set; }

        public ApartmentFeatures(ApartmentCategoryEnum apartmentCategory, int apartmentFeaturesId, int apartmentTypeId, int featureId, decimal floorArea)
        {
            ApartmentCategory = apartmentCategory;
            ApartmentFeaturesId = apartmentFeaturesId;
            ApartmentTypeId = apartmentTypeId;
            FeaturesId = featureId;
            FloorArea = floorArea;
            Features = new List<Features>();
        }

        public static ApartmentFeatures Create(ApartmentCategoryEnum apartmentCategory, int apartmentFeaturesId, int apartmentTypeId, int featureId, decimal floorArea)
        {
            Validate(apartmentFeaturesId, apartmentTypeId, featureId, floorArea);
            return new ApartmentFeatures(apartmentCategory, apartmentFeaturesId, apartmentTypeId, featureId, floorArea);
        }

        public void Update(int apartmentFeaturesId, int apartmentTypeId, int featureId, decimal floorArea)
        {
            Validate(apartmentFeaturesId, apartmentTypeId, featureId, floorArea);

            ApartmentFeaturesId = apartmentFeaturesId;
            ApartmentTypeId = apartmentTypeId;
            FeaturesId = featureId;
            FloorArea = floorArea;
        }

        private static void Validate(int apartmentFeaturesId, int apartmentTypeId, int featureId, decimal floorArea)
        {
            if (apartmentFeaturesId < 0)
                throw new ArgumentException("Apartment Feature Id must be greater than zero.");

            if (apartmentTypeId <= 0)
                throw new ArgumentException("Apartment Type Id must be greater than zero.");

            if (featureId <= 0)
                throw new ArgumentException("Features Id must be greater than zero.");

            if (floorArea < 0)
                throw new ArgumentException("Floor Area must be greater than zero.");
        }


    }
}