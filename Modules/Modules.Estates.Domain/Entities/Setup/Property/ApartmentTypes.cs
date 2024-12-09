using System;
namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class ApartmentTypes : AuditableEntity
	{
        [Key]
        public int ApartmentTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string? ApartmentType { get; set; }

        [Required]
        public float SellingPrice { get; set; }

        [Required]
        public int CurrencyId { get; set; }

        [Required]
        public double FloorArea { get; set; }


        public ApartmentTypes(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            ApartmentTypeId = apartmentTypeId;
            ApartmentType = apartmentType;
            SellingPrice = sellingPrice;
            CurrencyId = currencyId;
            FloorArea = floorArea;
        }


        public static ApartmentTypes Create(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            if (string.IsNullOrWhiteSpace(apartmentType) || apartmentTypeId <= -1 || sellingPrice <= 0 || currencyId < 0 || floorArea <= 0)
            {
                throw new ArgumentException("Invalid Apartment Type Data.");
            }

            if (apartmentTypeId <= -1)
            {
                throw new ArgumentException("Apartment Type Id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(apartmentType) || apartmentType.Length > 50)
            {
                throw new ArgumentException("Apartment Type must not be null or exceed 50 characters.");
            }

            if (sellingPrice <= 0)
            {
                throw new ArgumentException("Selling Price must be greater than zero.");
            }

            if (currencyId <= 0)
            {
                throw new ArgumentException("Currency Id must be greater than zero.");
            }

            if (floorArea <= 0.0)
            {
                throw new ArgumentException("Floor Area must be greater than zero.");
            }

            return new ApartmentTypes(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea);
        }

        public static ApartmentTypes Update(int apartmentTypeId, string apartmentType, float sellingPrice, int currencyId, double floorArea)
        {
            if (string.IsNullOrWhiteSpace(apartmentType) || apartmentTypeId <= -1 || sellingPrice <= 0 || currencyId < 0 || floorArea <= 0)
            {
                throw new ArgumentException("Invalid Apartment Type Data.");
            }

            if (apartmentTypeId <= -1)
            {
                throw new ArgumentException("Apartment Type Id must be greater than zero.");
            }

            if (string.IsNullOrWhiteSpace(apartmentType) || apartmentType.Length > 50)
            {
                throw new ArgumentException("Apartment Type must not be null or exceed 50 characters.");
            }

            if (sellingPrice <= 0)
            {
                throw new ArgumentException("Selling Price must be greater than zero.");
            }

            if (currencyId <= 0)
            {
                throw new ArgumentException("Currency Id must be greater than zero.");
            }

            if (floorArea <= 0)
            {
                throw new ArgumentException("Floor Area must be greater than zero.");
            }

            return new ApartmentTypes(apartmentTypeId, apartmentType, sellingPrice, currencyId, floorArea);
        }

    }

    

}

