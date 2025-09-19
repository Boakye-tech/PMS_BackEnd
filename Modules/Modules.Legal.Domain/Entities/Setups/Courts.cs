// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/Courts.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
	public class Courts : AuditableEntity
	{
		[Key]
		[Required]
		public int CourtsId { get; private set; }

		[Required]
		[StringLength(50)]
		public string CourtType { get; private set; }

		// Private constructor for EF Core
		private Courts()
		{
			CourtType = string.Empty;
		}

		public Courts(int courtsId, string courtType)
		{
			Validate(courtsId, courtType);

			CourtsId = courtsId;
			CourtType = courtType ?? throw new ArgumentNullException(nameof(courtType));
		}

		// Convenience overload to preserve existing callers
		public Courts(string courtType) : this(0, courtType) { }

		// Domain methods
		public void UpdateCourtType(int courtsId, string courtType)
		{
			Validate(courtsId, courtType);

			CourtsId = courtsId;
			CourtType = courtType ?? throw new ArgumentNullException(nameof(courtType));
		}

		private static void Validate(int courtsId, string courtType)
		{
			if ((courtsId < 0 || string.IsNullOrWhiteSpace(courtType)))
			{
				throw new ArgumentException("Invalid Court Data.");
			}

			if (courtsId < 0)
				throw new ArgumentException("Court Id must be greater than or equal to zero.");

			if (string.IsNullOrWhiteSpace(courtType) || courtType.Length > 50)
				throw new ArgumentException("Court Type cannot be empty or exceed 50 characters.");
		}
	}
}

