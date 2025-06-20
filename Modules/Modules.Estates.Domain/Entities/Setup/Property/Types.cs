// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Types.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:09 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class Types : AuditableEntity
	{
        [Key]
        [Required]
        public int TypeId { get; private set; }

        [StringLength(10)]
        public string Code { get; private set; }

        [StringLength(50)]
        public string TypeName { get; private set; }

        [Required]
        public int RentalCategoryId { get; private set; }

        //navigation property for rental category
        public virtual RentalCategory? RentalCategory { get; private set; }

        [Required]
        public int RentalTypeId { get; private set; }

        //navigation property for rental types
        public virtual RentalType? RentalType { get; private set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string[] Features { get; private set; }

        [Required]
        [StringLength(100)]
        public string Notes { get; private set; }


        public Types(int typeId, string code, string typeName, int rentalCategoryId, int rentalTypeId, string[] features, string notes)
        {
            TypeId = typeId;
            Code = code;
            TypeName = typeName;
            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            Features = features;
            Notes = notes;
        }

        public static Types Create(int typeId, string code, string typeName, int rentalCategoryId, int rentalTypeId, string[] features, string notes)
        {
            Validate(typeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes);

            return new Types(typeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes)
            {
                TypeId = typeId,
                Code = code,
                TypeName = typeName,
                RentalCategoryId = rentalCategoryId,
                RentalTypeId = rentalTypeId,
                Features = features,
                Notes = notes
            };
        }

        public void Update(int typeId, string code, string typeName, int rentalCategoryId, int rentalTypeId, string[] features, string notes)
        {
            Validate(typeId, code, typeName, rentalCategoryId, rentalTypeId, features, notes);

            Code = code;
            TypeName = typeName;
            RentalCategoryId = rentalCategoryId;
            RentalTypeId = rentalTypeId;
            Features = features;
            Notes = notes;
        }

        private static void Validate(int typeId, string code, string typeName, int rentalCategoryId, int rentalTypeId, string[] features, string notes)
        {
            if (typeId < 0)
                throw new ArgumentException("Type Id must be greater than zero.");

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

