// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Property/PropertyNumber.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/05/2025 12:11 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Estates.Domain.ValueObjects.Property
{
    [Owned]
    public record PropertyNumber : ValueObject
	{
		public string Value { get; init; }

		// For EF Core
		public PropertyNumber() { }

		private PropertyNumber(string value)
		{
			Value = value;
		}

		public static Result<PropertyNumber> Create(string landUseInitial,string landUseTypeInitial,string localityInitial,string allocationTypeInitial,string blockNumber,int NumberFrom, int NumberTo,bool isApartment = false,string blockUnit = null!)
		{
			if (string.IsNullOrWhiteSpace(landUseInitial) || landUseInitial.Length > 3)
				return Result<PropertyNumber>.Failure("Land use initial must not be null or exceed 3 characters.");

			if (string.IsNullOrWhiteSpace(localityInitial) || localityInitial.Length > 3)
				return Result<PropertyNumber>.Failure("Locality initial must not be null or exceed 3 characters.");

			if (string.IsNullOrWhiteSpace(allocationTypeInitial) || allocationTypeInitial.Length > 3)
				return Result<PropertyNumber>.Failure("Allocation Type Initial must not be null or exceed 3 characters.");

			if (NumberFrom == 0)
				return Result<PropertyNumber>.Failure("Plot number cannot be null or zero.");

			if (isApartment && string.IsNullOrWhiteSpace(blockUnit))
				return Result<PropertyNumber>.Failure("Block unit is required for apartments.");

			string delimiter = "/";
			string propertyNumber;

			if (landUseInitial == "SHP")
			{
				propertyNumber = string.IsNullOrWhiteSpace(blockNumber)
					? $"{landUseTypeInitial}{delimiter}{localityInitial}{delimiter}{allocationTypeInitial}{delimiter}{NumberFrom}"
					: $"{landUseTypeInitial}{delimiter}{localityInitial}{delimiter}{allocationTypeInitial}{delimiter}{blockNumber}{delimiter}{NumberFrom}";
			}
			else if (isApartment)
			{
				propertyNumber = $"{landUseInitial}{delimiter}{localityInitial}{delimiter}{allocationTypeInitial}{delimiter}{blockNumber}{delimiter}{blockUnit}{delimiter}{NumberFrom}";
			}
			else
			{
				propertyNumber = string.IsNullOrWhiteSpace(blockNumber)
					? $"{landUseInitial}{delimiter}{localityInitial}{delimiter}{allocationTypeInitial}{delimiter}{NumberFrom}"
					: $"{landUseInitial}{delimiter}{localityInitial}{delimiter}{allocationTypeInitial}{delimiter}{blockNumber}{delimiter}{NumberFrom}";
			}

			return Result<PropertyNumber>.Success(new PropertyNumber(propertyNumber));
		}
	}
}





