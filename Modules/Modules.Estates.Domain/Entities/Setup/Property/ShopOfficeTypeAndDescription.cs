// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ShopOfficeTypeAndDescription.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class ShopOfficeTypeAndDescription : AuditableEntity
	{
		public ShopTypeCategoryEnum ShopTypeCategory { get; private set; }

		[Key]
		[Required]
		public int ShopOfficeTypeId { get; private set; }

		[Required]
		[StringLength(10)]
		public string TypeName { get; private set; }

		[Required]
		[StringLength(100)]
		public string Description { get; private set; }

		public ShopOfficeTypeAndDescription(ShopTypeCategoryEnum shopTypeCategory, int shopOfficeTypeId, string typeName, string description)
		{
			ShopTypeCategory = shopTypeCategory;
			ShopOfficeTypeId = shopOfficeTypeId;
			TypeName = typeName;
			Description = description;
		}

		public static ShopOfficeTypeAndDescription Create(ShopTypeCategoryEnum shopTypeCategory, int shopOfficeTypeId, string typeName, string description)
		{
			Validate(shopOfficeTypeId, typeName, description);
			return new ShopOfficeTypeAndDescription(shopTypeCategory, shopOfficeTypeId, typeName, description);
		}

		public void Update(ShopTypeCategoryEnum shopTypeCategory, int shopOfficeTypeId, string typeName, string description)
		{
			Validate(shopOfficeTypeId, typeName, description);
			ShopTypeCategory = shopTypeCategory;
			TypeName = typeName;
			Description = description;
		}

		private static void Validate(int shopOfficeTypeId, string typeName, string description)
		{
			if (shopOfficeTypeId < 0)
				throw new ArgumentException("Shop Office Type Id must be greater than zero.");

			if (string.IsNullOrWhiteSpace(typeName) || typeName.Length > 10)
				throw new ArgumentException("Type Name cannot be empty or exceed 10 characters.");

			if (string.IsNullOrWhiteSpace(description) || description.Length > 100)
				throw new ArgumentException("Description cannot be empty or exceed 100 characters.");
		}
	}
}

