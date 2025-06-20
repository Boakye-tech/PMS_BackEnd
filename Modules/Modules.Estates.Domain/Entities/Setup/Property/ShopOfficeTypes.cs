// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ShopOfficeTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations.Schema;


namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ShopOfficeTypes : AuditableEntity
    {
        [Key]
        [Required]
        public int ShopOfficeTypeId { get; private set; }

        [StringLength(10)]
        public string Code { get; private set; }

        [StringLength(50)]
        public string TypeName { get; private set; }

        [Required]
        public int RentalCategoryId { get; private set; }

        [Required]
        public int RentalTypeId { get; private set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string[] Features { get; private set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; private set; }

        public ShopOfficeTypes(int shopOfficeTypeId,string code,string typeName,int rentalCategoryId,int rentalTypeId,string[] features,string notes)
        {
            ShopOfficeTypeId = shopOfficeTypeId;
            Code = code;
            TypeName = typeName;
            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            Features = features;
            Notes = notes;
        }

        public static ShopOfficeTypes Create(int shopOfficeTypeId,string code,string typeName,int rentalCategoryId,int rentalTypeId,string[] features,string notes)
        {
            Validate(shopOfficeTypeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes);

            return new ShopOfficeTypes(shopOfficeTypeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes)
            {
                ShopOfficeTypeId = shopOfficeTypeId,
                Code = code,
                TypeName = typeName,
                RentalCategoryId = rentalCategoryId,
                RentalTypeId = rentalTypeId,
                Features = features,
                Notes = notes
            };
        }

        public void Update(string code,string typeName,int rentalCategoryId,int rentalTypeId,string[] features,string notes)
        {
            Validate(ShopOfficeTypeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes);

            Code = code;
            TypeName = typeName;
            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            Features = features;
            Notes = notes;
        }

        private static void Validate(int shopOfficeTypeId,string code,string typeName,int rentalCategoryId,int rentalTypeId,string[] features,string notes)
        {
            if (shopOfficeTypeId <= 0)
                throw new ArgumentException("Shop Office Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(code) || code.Length > 10)
                throw new ArgumentException("Code cannot be empty or exceed 10 characters.");

            if (string.IsNullOrWhiteSpace(typeName) || typeName.Length > 50)
                throw new ArgumentException("Type Name cannot be empty or exceed 50 characters.");

            if (rentalCategoryId <= 0)
                throw new ArgumentException("Rental Category Id must be greater than zero.");

            if (rentalTypeId <= 0)
                throw new ArgumentException("Rental Type Id must be greater than zero.");

            if (features == null || features.Length == 0)
                throw new ArgumentException("Features cannot be empty.");

            if (string.IsNullOrWhiteSpace(notes) || notes.Length > 100)
                throw new ArgumentException("Notes cannot be empty or exceed 100 characters.");
        }
    }
}

