// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/PropertyHeightTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:43 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class PropertyHeightTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreatePropertyHeight()
		{
			// Arrange
			int propertyHeightId = 1;
			string propertyHeights = "Single Story";

			// Act
			var propertyHeight = PropertyHeight.Create(propertyHeightId, propertyHeights);

			// Assert
			Assert.Equal(propertyHeightId, propertyHeight.PropertyHeightId);
			Assert.Equal(propertyHeights, propertyHeight.PropertyHeights);
		}

		[Theory]
		[InlineData(-1, "Single Story", "Property Height Id must be greater than zero.")]
		[InlineData(1, "", "Property Heights cannot be empty or exceed 30 characters.")]
		[InlineData(1, null, "Property Heights cannot be empty or exceed 30 characters.")]
		[InlineData(1, "This property height description is way too long and exceeds the maximum allowed length", "Property Heights cannot be empty or exceed 30 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int propertyHeightId, string propertyHeights, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => PropertyHeight.Create(propertyHeightId, propertyHeights));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdatePropertyHeight()
		{
			// Arrange
			var propertyHeight = PropertyHeight.Create(1, "Single Story");
			int newPropertyHeightId = 2;
			string newPropertyHeights = "Double Story";

			// Act
			propertyHeight.Update(newPropertyHeightId, newPropertyHeights);

			// Assert
			Assert.Equal(newPropertyHeightId, propertyHeight.PropertyHeightId);
			Assert.Equal(newPropertyHeights, propertyHeight.PropertyHeights);
		}

		[Theory]
		[InlineData(-1, "Single Story", "Property Height Id must be greater than zero.")]
		[InlineData(1, "", "Property Heights cannot be empty or exceed 30 characters.")]
		[InlineData(1, null, "Property Heights cannot be empty or exceed 30 characters.")]
		[InlineData(1, "This property height description is way too long and exceeds the maximum allowed length", "Property Heights cannot be empty or exceed 30 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int propertyHeightId, string propertyHeights, string expectedMessage)
		{
			// Arrange
			var propertyHeight = PropertyHeight.Create(1, "Single Story");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				propertyHeight.Update(propertyHeightId, propertyHeights));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

