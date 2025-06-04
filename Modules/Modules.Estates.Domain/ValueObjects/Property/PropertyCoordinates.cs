// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/ValueObjects/Property/PropertyCoordinates.cs
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
    public record PropertyCoordinates : ValueObject
	{
		public string CoordinateOne { get; init; }
		public string CoordinateTwo { get; init; }
		public string CoordinateThree { get; init; }
		public string CoordinateFour { get; init; }
		public string CoordinateFive { get; init; }
		public string CoordinateSix { get; init; }

		private PropertyCoordinates(
			string coordinateOne,
			string coordinateTwo,
			string coordinateThree,
			string coordinateFour,
			string coordinateFive,
			string coordinateSix)
		{
			CoordinateOne = coordinateOne;
			CoordinateTwo = coordinateTwo;
			CoordinateThree = coordinateThree;
			CoordinateFour = coordinateFour;
			CoordinateFive = coordinateFive;
			CoordinateSix = coordinateSix;
		}

		public static Result<PropertyCoordinates> Create(
			string coordinateOne,
			string coordinateTwo,
			string coordinateThree,
			string coordinateFour = null!,
			string coordinateFive = null!,
			string coordinateSix = null!)
		{
			if (string.IsNullOrWhiteSpace(coordinateOne) || coordinateOne.Length > 50)
				return Result<PropertyCoordinates>.Failure("Invalid coordinate one.");

			if (string.IsNullOrWhiteSpace(coordinateTwo) || coordinateTwo.Length > 50)
				return Result<PropertyCoordinates>.Failure("Invalid coordinate two.");

			if (string.IsNullOrWhiteSpace(coordinateThree) || coordinateThree.Length > 50)
				return Result<PropertyCoordinates>.Failure("Invalid coordinate three.");

			// if (string.IsNullOrWhiteSpace(coordinateFour) || coordinateFour.Length > 50)
			// 	return Result<PropertyCoordinates>.Failure("Invalid coordinate four.");

			return Result<PropertyCoordinates>.Success(new PropertyCoordinates(
				coordinateOne,
				coordinateTwo,
				coordinateThree,
				coordinateFour,
				coordinateFive,
				coordinateSix));
		}
	}


}

