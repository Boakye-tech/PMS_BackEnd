// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Items.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class Items : AuditableEntity
{
	[Required]
	public int ItemCategoryId { get; private set; }

    // Navigation property for ItemsCategory
    public virtual ItemsCategory? ItemCategory { get; private set; }

    [Key]
	[Required]
	[StringLength(20)]
	public string? ItemCode { get; private set; }

	[Required]
	[StringLength(100)]
	public string? ItemName { get; private set; }


	public Items()
	{
	}

	public Items(int itemCategoryId, string? itemCode, string? itemName)
	{
		ItemCategoryId = itemCategoryId;
		ItemCode = itemCode;
		ItemName = itemName;
	}

	public static Items Create(int itemCategoryId, string itemCode, string itemName)
	{
		Validate(itemCategoryId, itemCode, itemName);
		return new Items(itemCategoryId, itemCode, itemName);
	}

	public void Update(int itemCategoryId, string itemCode, string itemName)
	{
		Validate(itemCategoryId, itemCode, itemName);

		ItemCategoryId = itemCategoryId;
		ItemCode = itemCode;
		ItemName = itemName;
	}

	private static void Validate(int itemCategoryId, string itemCode, string itemName)
	{
		if (itemCategoryId < 0 || string.IsNullOrWhiteSpace(itemCode) || string.IsNullOrWhiteSpace(itemName))
		{
			throw new ArgumentException("Item data is invalid.");
		}

		if (itemCategoryId < 0)
			throw new ArgumentException("Item Category ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(itemCode) || itemCode.Length > 20)
			throw new ArgumentException("Item Code cannot be empty or exceed 20 characters.");

		if (string.IsNullOrWhiteSpace(itemName) || itemName.Length > 100)
			throw new ArgumentException("Item Name cannot be empty or exceed 100 characters.");
	}
}

