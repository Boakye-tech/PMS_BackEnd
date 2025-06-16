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

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ApartmentTypes : AuditableEntity
    {
        [Key]
        [Required]
        public int ApartmentTypeId { get; private set; }

        [Required]
        public int ApartmentCategoryId { get; private set; }

        [Required]
        [StringLength(50)]
        public string ApartmentType { get; private set; }

        [Required]
        public float SellingPrice { get; private set; }

        [Required]
        public int CurrencyId { get; private set; }

        public virtual CurrencyExchangeRate? Currency { get; private set; }

        [Required]
        public double FloorArea { get; private set; }

        [Column(TypeName = "nvarchar(max)")]
        public string[] Images { get; private set; }

        // Navigation property
        public virtual ApartmentCategory? ApartmentCategory { get; private set; }

        public ApartmentTypes(int apartmentTypeId, int apartmentCategoryId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string[] images)
        {
            ApartmentTypeId = apartmentTypeId;
            ApartmentCategoryId = apartmentCategoryId;
            ApartmentType = apartmentType;
            SellingPrice = sellingPrice;
            CurrencyId = currencyId;
            FloorArea = floorArea;
            Images = images;
        }

        public static ApartmentTypes Create(int apartmentTypeId, int apartmentCategoryId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string[] images)
        {
            Validate(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea, images);
            return new ApartmentTypes(apartmentTypeId, apartmentCategoryId, apartmentType, sellingPrice, currencyId, floorArea, images);
        }

        public void Update(int apartmentTypeId, int apartmentCategoryId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string[] images)
        {
            Validate(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea, images);

            ApartmentTypeId = apartmentTypeId;
            ApartmentCategoryId = apartmentCategoryId;
            ApartmentType = apartmentType;
            SellingPrice = sellingPrice;
            CurrencyId = currencyId;
            FloorArea = floorArea;
            Images = images;
        }

        private static void Validate(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea, string[] images)
        {
            if (apartmentTypeId < 0)
                throw new ArgumentException("Apartment Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(apartmentType) || apartmentType.Length > 50)
                throw new ArgumentException("Apartment Type cannot be empty or exceed 50 characters.");

            if (sellingPrice <= 0)
                throw new ArgumentException("Selling Price must be greater than zero.");

            if (currencyId <= 0)
                throw new ArgumentException("Currency Id must be greater than zero.");

            if (floorArea <= 0)
                throw new ArgumentException("Floor Area must be greater than zero.");

            if (images.Count() == 0)
                throw new ArgumentException("There must be at least one image.");
        }
    }
}

