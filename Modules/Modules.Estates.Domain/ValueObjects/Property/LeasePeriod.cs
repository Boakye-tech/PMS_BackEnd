// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Property/LeasePeriod.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/05/2025 12:13 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Estates.Domain.ValueObjects.Property
{
	[Owned]
	public record LeasePeriod : ValueObject
	{
		public DateTime CommencementDate { get; init; }
		public int TermInYears { get; init; }
		public DateTime ExpiryDate { get; init; }

		private LeasePeriod(DateTime commencementDate, int termInYears)
		{
			CommencementDate = commencementDate;
			TermInYears = termInYears;
			ExpiryDate = commencementDate.AddYears(termInYears);
		}

		public static Result<LeasePeriod> Create(DateTime commencementDate, int termInYears)
		{
			if (commencementDate < DateTime.UtcNow)
				return Result<LeasePeriod>.Failure("Lease commencement date cannot be in the past.");

			if (termInYears <= 0)
				return Result<LeasePeriod>.Failure("Lease term must be greater than zero.");

			return Result<LeasePeriod>.Success(new LeasePeriod(commencementDate, termInYears));
		}

		public bool IsExpired => DateTime.UtcNow > ExpiryDate;

		public int RemainingYears => Math.Max(0, (ExpiryDate - DateTime.UtcNow).Days / 365);
	}
}

