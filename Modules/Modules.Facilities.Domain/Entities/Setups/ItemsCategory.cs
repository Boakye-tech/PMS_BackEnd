// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/ItemsCategory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class ItemsCategory : AuditableEntity
{
	[Key]
	[Required]
	public int ItemCategoryId { get; private set; }

	[Required]
	[StringLength(100)]
	public string? ItemCategoryName { get; private set; }

	public ItemsCategory()
	{
	}

	public ItemsCategory(int itemCategoryId, string? itemCategoryName)
	{
		ItemCategoryId = itemCategoryId;
		ItemCategoryName = itemCategoryName;
	}

	public static ItemsCategory Create(int itemCategoryId, string itemCategoryName)
	{
		Validate(itemCategoryId, itemCategoryName);
		return new ItemsCategory(itemCategoryId, itemCategoryName);
	}

	public void Update(int itemCategoryId, string itemCategoryName)
	{
		Validate(itemCategoryId, itemCategoryName);

		ItemCategoryId = itemCategoryId;
		ItemCategoryName = itemCategoryName;
	}

	private static void Validate(int itemCategoryId, string itemCategoryName)
	{
		if (itemCategoryId < 0 || string.IsNullOrWhiteSpace(itemCategoryName))
		{
			throw new ArgumentException("Item Category data is invalid.");
		}

		if (itemCategoryId < 0)
			throw new ArgumentException("Item Category ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(itemCategoryName) || itemCategoryName.Length > 100)
			throw new ArgumentException("Item Category Name cannot be empty or exceed 100 characters.");
	}
}

