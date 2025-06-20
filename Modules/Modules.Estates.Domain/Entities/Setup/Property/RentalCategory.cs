// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/RentalCategory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 10:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class RentalCategory : AuditableEntity
    {
        [Key]
        [Required]
        public int RentalCategoryId { get; private set; }

        [Required]
        [StringLength(50)]
        public string RentalCategories { get; private set; }

        // Navigation property for RentalTypes
        public virtual ICollection<RentalType> RentalTypes { get; private set; }

        public RentalCategory(int rentalCategoryId, string rentalCategories)
        {
            RentalCategoryId = rentalCategoryId;
            RentalCategories = rentalCategories;
            RentalTypes = new List<RentalType>();
        }

        public static RentalCategory Create(int rentalCategoryId, string rentalCategories)
        {
            Validate(rentalCategoryId, rentalCategories);
            return new RentalCategory(rentalCategoryId, rentalCategories);

        }

        public void Update(int rentalCategoryId, string rentalCategories)
        {
            Validate(rentalCategoryId, rentalCategories);

            RentalCategoryId = rentalCategoryId;
            RentalCategories = rentalCategories;
        }

        private static void Validate(int rentalCategoryId, string rentalCategories)
        {
            if (rentalCategoryId < 0)
                throw new ArgumentException("Rental Category Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(rentalCategories) || rentalCategories.Length > 50)
                throw new ArgumentException("Rental Category cannot be empty or exceed 50 characters.");
        }
    }
}

