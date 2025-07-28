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

using Microsoft.EntityFrameworkCore;

namespace Modules.Estates.Domain.ValueObjects.Property
{
    [Owned]
    public record PlotSize : ValueObject
	{
		public int DimensionId { get; init; }
		public decimal Acreage { get; init; }
		public decimal Acreage2 { get; init; }

		private PlotSize(){}

        private PlotSize(int dimensionId, string dimensions, double areaInSquareFeet)
		{
			DimensionId = dimensionId;
            double acres = areaInSquareFeet / 43560; // Convert to acres
            Acreage = decimal.Parse(acres.ToString("F2")); 
		}

		public static Result<PlotSize> Create(int dimensionId, string dimension)
		{
			if (string.IsNullOrWhiteSpace(dimension))
				return Result<PlotSize>.Failure("Plot dimension cannot be null or empty.");

            if (dimension.Length < 5)
                return Result<PlotSize>.Failure("Plot dimension cannot be less than five(5) characters.");

            if (!dimension.ToLower().Contains('x'))
                return Result<PlotSize>.Failure("Invalid format: expected format 'number x number'.");

			//split based on 'x' and check if 1st and last values are numbers
            var _parts = dimension.ToLower().Split('x');

			if(!int.TryParse(_parts.FirstOrDefault(),out int _lenght))
                return Result<PlotSize>.Failure($"Invalid dimension: '{_parts.FirstOrDefault()}' is not a valid integer.");

            if(!int.TryParse(_parts.LastOrDefault(),out int _width))
                return Result<PlotSize>.Failure($"Invalid dimension: '{_parts.LastOrDefault()}' is not a valid integer.");

			double _areaInSquareFeet = _lenght * _width;

            return Result<PlotSize>.Success(new PlotSize(dimensionId, dimension, _areaInSquareFeet));
		}
	}
}

