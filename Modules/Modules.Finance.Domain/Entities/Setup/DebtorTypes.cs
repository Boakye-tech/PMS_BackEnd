// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/DebtorTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/09/2025 9:25 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;
namespace Modules.Finance.Domain.Entities.Setup
{
	public class DebtorTypes : AuditableEntity
	{

		[Required]
        public int RentalTypesId { get;  private set; }

        // Navigation property for RentalTypes
        public virtual RentalTypes? RentalTypes { get; private set; }

        [Key]
		[Required]
		public int DebtorTypesId { get; private set; }

		[Required]
		public int DebtorType { get; private set; }

		[StringLength(100)]
		public string Description { get; private set; }

        // Navigation property for DebtorGroups
        public virtual ICollection<DebtorGroups>? DebtorGroups { get; private set; }

        private DebtorTypes()
		{
			Description = string.Empty;
		}

		public DebtorTypes(int rentalTypesId,int debtorTypesId, int debtorType, string description)
		{
			Validate(rentalTypesId,debtorTypesId, debtorType, description);

            RentalTypesId = rentalTypesId;
            DebtorTypesId = debtorTypesId;
			DebtorType = debtorType;
			Description = description ?? string.Empty;
            DebtorGroups = new List<DebtorGroups>();
        }

		public static DebtorTypes Create(int rentalTypesId, int debtorTypesId, int debtorType, string description)
		{
			Validate(rentalTypesId, debtorTypesId, debtorType, description);
			return new DebtorTypes(rentalTypesId, debtorTypesId, debtorType, description);
		}

		public void Update(int rentalTypesId, int debtorTypesId, int debtorType, string description)
		{
			Validate(rentalTypesId, debtorTypesId, debtorType, description);

			RentalTypesId = rentalTypesId;
			DebtorTypesId = debtorTypesId;
			DebtorType = debtorType;
			Description = description ?? string.Empty;
		}

		private static void Validate(int rentalTypesId, int debtorTypesId, int debtorType, string description)
		{
            if (rentalTypesId < 0)
                throw new ArgumentException("Rental Type Id must be greater than or equal to zero.");

            if (debtorTypesId < 0)
				throw new ArgumentException("Debtor Type Id must be greater than or equal to zero.");

			if (debtorType <= 0)
				throw new ArgumentException("Debtor Type must be greater than zero.");

			if (!string.IsNullOrEmpty(description) && description.Length > 100)
				throw new ArgumentException("Description cannot exceed 100 characters.");
		}
	}
}

