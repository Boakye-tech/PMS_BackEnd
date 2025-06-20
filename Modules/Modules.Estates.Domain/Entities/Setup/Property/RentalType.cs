// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/RentalType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/05/2025 5:22 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class RentalType : AuditableEntity
    {
        [Required]
        public int RentalCategoryId { get; private set; }

        // Navigation property for RentalCategory
        public virtual RentalCategory? RentalCategory { get; private set; }

        [Key]
        [Required]
        public int RentalTypeId { get; private set; }

        [Required]
        [StringLength(50)]
        public string RentalTypes { get; private set; }

        public RentalType(int rentalCategoryId, int rentalTypeId, string rentalTypes)
        {
            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            RentalTypes = rentalTypes;
        }

        public static RentalType Create(int rentalCategoryId, int rentalTypeId, string rentalTypes)
        {
            Validate(rentalCategoryId, rentalTypeId, rentalTypes);
            return new RentalType(rentalCategoryId, rentalTypeId, rentalTypes)
            {
                RentalCategoryId = rentalCategoryId,
                RentalTypeId = rentalTypeId,
                RentalTypes = rentalTypes
            };
        }

        public void Update(int rentalCategoryId, int rentalTypeId, string rentalTypes)
        {
            Validate(rentalCategoryId, rentalTypeId, rentalTypes);

            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            RentalTypes = rentalTypes;
        }

        private static void Validate(int rentalCategoryId, int rentalTypeId, string rentalTypes)
        {
            if (rentalCategoryId <= 0)
                throw new ArgumentException("Rental Category Id must be greater than zero.");

            if (rentalTypeId < 0)
                throw new ArgumentException("Rental Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(rentalTypes) || rentalTypes.Length > 50)
                throw new ArgumentException("Rental Type cannot be empty or exceed 50 characters.");
        }
    }
}

