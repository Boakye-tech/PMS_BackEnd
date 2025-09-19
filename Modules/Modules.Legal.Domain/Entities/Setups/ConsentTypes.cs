// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/ConsentTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
	public class ConsentType : AuditableEntity
	{
		[Key]
		[Required]
		public int ConsentTypeId { get; private set; }

		[Required]
		[StringLength(50)]
		public string ConsentTypes { get; private set; }

		// Private constructor for EF Core
		private ConsentType()
		{
			ConsentTypes = string.Empty;
		}

		public ConsentType(int consentTypeId, string consentTypes)
		{
			Validate(consentTypeId, consentTypes);

			ConsentTypeId = consentTypeId;
			ConsentTypes = consentTypes ?? throw new ArgumentNullException(nameof(consentTypes));
		}

		// Convenience overload to preserve existing callers
		public ConsentType(string consentType) : this(0, consentType) { }

		// Domain methods
		public void UpdateConsentType(int consentTypeId, string consentTypes)
		{
			Validate(consentTypeId, consentTypes);

			ConsentTypeId = consentTypeId;
			ConsentTypes = consentTypes ?? throw new ArgumentNullException(nameof(consentTypes));
		}

		private static void Validate(int consentTypeId, string consentTypes)
		{
			if ((consentTypeId < 0 || string.IsNullOrWhiteSpace(consentTypes)))
			{
				throw new ArgumentException("Invalid Consent Type Data.");
			}

			if (consentTypeId < 0)
				throw new ArgumentException("Consent Type Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(consentTypes) || consentTypes.Length > 50)
				throw new ArgumentException("Consent Type cannot be empty or exceed 50 characters.");
		}
	}
}

