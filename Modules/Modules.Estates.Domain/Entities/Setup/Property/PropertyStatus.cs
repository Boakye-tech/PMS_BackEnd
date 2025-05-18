// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PropertyStatus.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/05/2025 5:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class PropertyStatus : AuditableEntity
	{
		[Key]
		[Required]
		public int PropertyStatusId { get; private set; }

		[Required]
		[StringLength(50)]
		public string PropertyStatusName { get; private set; }

		public PropertyStatus(int propertyStatusId, string propertyStatusName)
		{
			PropertyStatusId = propertyStatusId;
			PropertyStatusName = propertyStatusName;
		}

		public static PropertyStatus Create(int propertyStatusId, string propertyStatusName)
		{
			Validate(propertyStatusId, propertyStatusName);
			return new PropertyStatus(propertyStatusId, propertyStatusName);
		}

		public void Update(int propertyStatusId, string propertyStatusName)
		{
			Validate(propertyStatusId, propertyStatusName);
			PropertyStatusName = propertyStatusName;
		}

		private static void Validate(int propertyStatusId, string propertyStatusName)
		{
			if (propertyStatusId < 0)
				throw new ArgumentException("Property Status Id must be greater than zero.");

			if (string.IsNullOrWhiteSpace(propertyStatusName) || propertyStatusName.Length > 50)
				throw new ArgumentException("Property Status Name cannot be empty or exceed 50 characters.");
		}
	}
}

