// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Property/PlotSize.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/05/2025 12:12 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Estates.Domain.ValueObjects.Property
{
    [Owned]
    public record PlotSize : ValueObject
	{
		public double Dimension { get; init; }
		public double Acreage { get; init; }

		private PlotSize(double dimension)
		{
			Dimension = dimension;
			Acreage = dimension * 43560; // Convert to acres
		}

		public static Result<PlotSize> Create(double dimension)
		{
			if (dimension <= 0)
				return Result<PlotSize>.Failure("Plot dimension must be greater than zero.");

			return Result<PlotSize>.Success(new PlotSize(dimension));
		}
	}
}

