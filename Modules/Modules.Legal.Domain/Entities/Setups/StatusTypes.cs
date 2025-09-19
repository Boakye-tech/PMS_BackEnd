// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/StatusTypes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:32 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
	public class StatusTypes : AuditableEntity
	{
		[Key]
		[Required]
		public int StatusTypesId { get; private set; }

		[Required]
		[StringLength(50)]
		public string StatusType { get; private set; }

		// Private constructor for EF Core
		private StatusTypes()
		{
			StatusType = string.Empty;
		}

		public StatusTypes(int statusTypesId, string statusType)
		{
			Validate(statusTypesId, statusType);

			StatusTypesId = statusTypesId;
			StatusType = statusType ?? throw new ArgumentNullException(nameof(statusType));
		}

		// Convenience overload to preserve existing callers
		public StatusTypes(string statusType) : this(0, statusType) { }

		// Domain methods
		public void UpdateStatusType(int statusTypesId, string statusType)
		{
			Validate(statusTypesId, statusType);

			StatusTypesId = statusTypesId;
			StatusType = statusType ?? throw new ArgumentNullException(nameof(statusType));
		}

		private static void Validate(int statusTypesId, string statusType)
		{
			if ((statusTypesId < 0 || string.IsNullOrWhiteSpace(statusType)))
			{
				throw new ArgumentException("Invalid Status Type Data.");
			}

			if (statusTypesId < 0)
				throw new ArgumentException("Status Type Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(statusType) || statusType.Length > 50)
				throw new ArgumentException("Status Type cannot be empty or exceed 50 characters.");
		}
	}
}

