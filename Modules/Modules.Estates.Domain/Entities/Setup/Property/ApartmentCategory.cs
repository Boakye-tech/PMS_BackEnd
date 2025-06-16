// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ApartmentCategory.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:23 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class ApartmentCategory : AuditableEntity
	{
		[Key]
		[Required]
		public int ApartmentCategoryId { get; private set; }

		[Required]
		[StringLength(50)]
		public string? ApartmentCategoryName { get; private set; }

		// Navigation property for ApartmentTypes
		public virtual ICollection<ApartmentTypes> ApartmentTypes { get; private set; }

		public ApartmentCategory(int apartmentCategoryId, string? apartmentCategoryName)
		{
			ApartmentCategoryId = apartmentCategoryId;
			ApartmentCategoryName = apartmentCategoryName;
			ApartmentTypes = new List<ApartmentTypes>();
		}

		public static ApartmentCategory Create(int apartmentCategoryId, string apartmentCategoryName)
		{
			Validate(apartmentCategoryId, apartmentCategoryName);
			return new ApartmentCategory(apartmentCategoryId, apartmentCategoryName);
		}

		public void Update(int apartmentCategoryId, string apartmentCategoryName)
		{
			Validate(apartmentCategoryId, apartmentCategoryName);

			ApartmentCategoryId = apartmentCategoryId;
			ApartmentCategoryName = apartmentCategoryName;
		}

		private static void Validate(int apartmentCategoryId, string apartmentCategoryName)
		{
			if (apartmentCategoryId < 0)
				throw new ArgumentException("Apartment Category Id must be greater than zero.");

			if (string.IsNullOrWhiteSpace(apartmentCategoryName) || apartmentCategoryName.Length > 50)
				throw new ArgumentException("Apartment Category Name cannot be empty or exceed 50 characters.");
		}
	}
}

