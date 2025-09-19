// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/RentalTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 3:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class RentalTypes : AuditableEntity
	{
		[Key]
		[Required]
		public int RentalTypesId { get; private set; }

		[Required]
		[StringLength(50)]
		public string RentalType { get; private set; }

		// Navigation property for DebtorTypes
		public virtual ICollection<DebtorTypes>? DebtorTypes { get; private set; }

		private RentalTypes()
		{
			RentalType = string.Empty;
			DebtorTypes = new List<DebtorTypes>();
		}

		public RentalTypes(int rentalTypesId, string rentalType)
		{
			Validate(rentalTypesId, rentalType);
			RentalTypesId = rentalTypesId;
			RentalType = rentalType;
			DebtorTypes = new List<DebtorTypes>();
		}

		public static RentalTypes Create(int rentalTypesId, string rentalType)
		{
			Validate(rentalTypesId, rentalType);
			return new RentalTypes(rentalTypesId, rentalType);
		}

		public void Update(int rentalTypesId, string rentalType)
		{
			Validate(rentalTypesId, rentalType);
			RentalTypesId = rentalTypesId;
			RentalType = rentalType;
		}

		private static void Validate(int rentalTypesId, string rentalType)
		{
			if (rentalTypesId < 0)
				throw new ArgumentException("Rental Types Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(rentalType) || rentalType.Length > 50)
				throw new ArgumentException("Rental Type must not be empty or exceed 50 characters.");
		}
	}
}

