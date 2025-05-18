// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/LeaseTypeAndPeriod.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class LeaseTypeAndPeriod : AuditableEntity
	{
		[Key]
		[Required]
		public int LeaseTypePeriodId { get; private set; }

		[Required]
		[StringLength(50)]
		public string LeaseType { get; private set; }

		[Required]
		public int LeasePeriod { get; private set; }

		public LeaseTypeAndPeriod(int leaseTypePeriodId, string leaseType, int leasePeriod)
		{
			LeaseTypePeriodId = leaseTypePeriodId;
			LeaseType = leaseType;
			LeasePeriod = leasePeriod;
		}

		public static LeaseTypeAndPeriod Create(int leaseTypePeriodId, string leaseType, int leasePeriod)
		{
			Validate(leaseTypePeriodId, leaseType, leasePeriod);
			return new LeaseTypeAndPeriod(leaseTypePeriodId, leaseType, leasePeriod);
		}

		public void Update(int leaseTypePeriodId, string leaseType, int leasePeriod)
		{
			Validate(leaseTypePeriodId, leaseType, leasePeriod);
			LeaseType = leaseType;
			LeasePeriod = leasePeriod;
		}

		private static void Validate(int leaseTypePeriodId, string leaseType, int leasePeriod)
		{
			if (leaseTypePeriodId < 0)
				throw new ArgumentException("Lease Type Period Id must be greater than zero.");

			if (string.IsNullOrWhiteSpace(leaseType) || leaseType.Length > 50)
				throw new ArgumentException("Lease Type cannot be empty or exceed 50 characters.");

			if (leasePeriod <= 0)
				throw new ArgumentException("Lease Period must be greater than zero.");
		}
	}
}

