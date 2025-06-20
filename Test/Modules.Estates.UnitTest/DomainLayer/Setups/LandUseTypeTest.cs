// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/LandUseTypeTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:18 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class LandUseTypeTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateLandUseType()
		{
			// Arrange
			int landUseId = 1;
			int landUseTypeId = 1;
			string landUseTypeInitial = "RES";
			string landUseTypeName = "Residential";
			string landUseTypeDescription = "Descriptions for residential houses";

			// Act
			var landUseType = LandUseType.Create(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, landUseTypeDescription);

			// Assert
			Assert.Equal(landUseId, landUseType.LandUseId);
			Assert.Equal(landUseTypeId, landUseType.LandUseTypeId);
			Assert.Equal(landUseTypeInitial, landUseType.LandUseTypeInitial);
			Assert.Equal(landUseTypeName, landUseType.LandUseTypeName);
		}

		[Theory]
		[InlineData(-1, 1, "RES", "Residential", "Descriptions for residential houses", "Land Use Id must be greater than zero.")]
		[InlineData(1, -1, "RES", "Residential", "Descriptions for residential houses", "Land Use Type Id must be greater than zero.")]
		[InlineData(1, 1, "", "Residential", "Descriptions for residential houses", "Land Use Type Initial cannot be empty or exceed 5 characters.")]
		[InlineData(1, 1, null, "Residential", "Descriptions for residential houses", "Land Use Type Initial cannot be empty or exceed 5 characters.")]
		[InlineData(1, 1, "RES", "", "Descriptions for residential houses", "Land Use Type Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, 1, "RES", null, "Descriptions for residential houses", "Land Use Type Name cannot be empty or exceed 50 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string landUseTypeDescription, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				LandUseType.Create(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, landUseTypeDescription));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateLandUseType()
		{
			// Arrange
			var landUseType = LandUseType.Create(1, 1, "RES", "Residential","");
			int newLandUseId = 2;
			int newLandUseTypeId = 2;
			string newLandUseTypeInitial = "COM";
			string newLandUseTypeName = "Commercial";

			// Act
			landUseType.Update(newLandUseId, newLandUseTypeId, newLandUseTypeInitial, newLandUseTypeName, "");

			// Assert
			Assert.Equal(newLandUseId, landUseType.LandUseId);
			Assert.Equal(newLandUseTypeId, landUseType.LandUseTypeId);
			Assert.Equal(newLandUseTypeInitial, landUseType.LandUseTypeInitial);
			Assert.Equal(newLandUseTypeName, landUseType.LandUseTypeName);
		}

		[Theory]
		[InlineData(-1, 1, "RES", "Residential", "Land Use Id must be greater than zero.")]
		[InlineData(1, -1, "RES", "Residential", "Land Use Type Id must be greater than zero.")]
		[InlineData(1, 1, "", "Residential", "Land Use Type Initial cannot be empty or exceed 5 characters.")]
		[InlineData(1, 1, null, "Residential", "Land Use Type Initial cannot be empty or exceed 5 characters.")]
		[InlineData(1, 1, "RES", "", "Land Use Type Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, 1, "RES", null, "Land Use Type Name cannot be empty or exceed 50 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int landUseId, int landUseTypeId, string landUseTypeInitial, string landUseTypeName, string expectedMessage)
		{
			// Arrange
			var landUseType = LandUseType.Create(1, 1, "RES", "Residential", "");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				landUseType.Update(landUseId, landUseTypeId, landUseTypeInitial, landUseTypeName, ""));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

