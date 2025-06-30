// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/Setups/Category.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 10:59 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Domain.Entities.Setups;

public class Category : AuditableEntity
{
	[Key]
	[Required]
	public int CategoryId { get; private set; }

	[Required]
	[StringLength(100)]
	public string? CategoryName { get; private set; }

	public Category(int categoryId, string? categoryName)
	{
		CategoryId = categoryId;
		CategoryName = categoryName;
	}

	public static Category Create(int categoryId, string categoryName)
	{
		Validate(categoryId, categoryName);
		return new Category(categoryId, categoryName);
	}

	public void Update(int categoryId, string categoryName)
	{
		Validate(categoryId, categoryName);

		CategoryId = categoryId;
		CategoryName = categoryName;
	}

	private static void Validate(int categoryId, string categoryName)
	{
		if (categoryId < 0 || string.IsNullOrWhiteSpace(categoryName))
		{
			throw new ArgumentException("Category data is invalid.");
		}

		if (categoryId < 0)
			throw new ArgumentException("Category ID must be greater than zero.");

		if (string.IsNullOrWhiteSpace(categoryName) || categoryName.Length > 100)
			throw new ArgumentException("Category Name cannot be empty or exceed 100 characters.");
	}
}

