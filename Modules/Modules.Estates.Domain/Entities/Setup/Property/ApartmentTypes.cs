// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ApartmentTypes : AuditableEntity
    {
        [Required]
        public ApartmentCategoryEnum ApartmentCategory { get; set; }

        [Key]
        [Required]
        public int ApartmentTypeId { get; private set; }

        [Required]
        [StringLength(50)]
        public string ApartmentType { get; private set; }

        [Required]
        public float SellingPrice { get; private set; }

        [Required]
        public int CurrencyId { get; private set; }

        [Required]
        public double FloorArea { get; private set; }

        public ApartmentTypes(ApartmentCategoryEnum apartmentCategory, int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            ApartmentTypeId = apartmentTypeId;
            ApartmentType = apartmentType;
            SellingPrice = sellingPrice;
            CurrencyId = currencyId;
            FloorArea = floorArea;
            ApartmentCategory = apartmentCategory;
        }

        public static ApartmentTypes Create(ApartmentCategoryEnum apartmentCategory, int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            Validate(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea);
            return new ApartmentTypes(apartmentCategory, apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea);
        }

        public void Update(ApartmentCategoryEnum apartmentCategory, int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            Validate(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea);

            ApartmentTypeId = apartmentTypeId;
            ApartmentType = apartmentType;
            SellingPrice = sellingPrice;
            CurrencyId = currencyId;
            FloorArea = floorArea;
        }

        private static void Validate(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            if (apartmentTypeId < 0)
                throw new ArgumentException("Apartment Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(apartmentType))
                throw new ArgumentException("Apartment Type cannot be empty or exceed 50 characters.");

            if (sellingPrice <= 0)
                throw new ArgumentException("Selling Price must be greater than zero.");

            if (currencyId <= 0)
                throw new ArgumentException("Currency Id must be greater than zero.");

            if (floorArea <= 0)
                throw new ArgumentException("Floor Area must be greater than zero.");
        }
    }
}

