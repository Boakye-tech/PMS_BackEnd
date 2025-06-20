// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/FloorNumberingTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:42 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class FloorNumberingTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateFloorNumbering()
		{
			// Arrange
			int floorNumberingId = 1;
			string floorNumbering = "1st Floor";

			// Act
			var floorNumber = FloorNumbering.Create(floorNumberingId, floorNumbering);

			// Assert
			Assert.Equal(floorNumberingId, floorNumber.FloorNumberId);
			Assert.Equal(floorNumbering, floorNumber.FloorNumber);
		}

		[Theory]
		[InlineData(-1, "1st Floor", "Floor Numbering Id must be greater than zero.")]
		[InlineData(1, "", "Floor Numbering cannot be empty or exceed 25 characters.")]
		[InlineData(1, null, "Floor Numbering cannot be empty or exceed 25 characters.")]
		[InlineData(1, "This floor numbering is way too long and exceeds the maximum allowed length", "Floor Numbering cannot be empty or exceed 25 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int floorNumberingId, string floorNumbering, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => FloorNumbering.Create(floorNumberingId, floorNumbering));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateFloorNumbering()
		{
			// Arrange
			var floorNumbering = FloorNumbering.Create(1, "1st Floor");
			int newFloorNumberingId = 1;
			string newFloorNumbering = "First Floor";

			// Act
			floorNumbering.Update(newFloorNumberingId, newFloorNumbering);

			// Assert
			Assert.Equal(newFloorNumberingId, floorNumbering.FloorNumberId);
			Assert.Equal(newFloorNumbering, floorNumbering.FloorNumber);
		}

		[Theory]
		[InlineData(-1, "1st Floor", "Floor Numbering Id must be greater than zero.")]
		[InlineData(1, "", "Floor Numbering cannot be empty or exceed 25 characters.")]
		[InlineData(1, null, "Floor Numbering cannot be empty or exceed 25 characters.")]
		[InlineData(1, "This floor numbering is way too long and exceeds the maximum allowed length", "Floor Numbering cannot be empty or exceed 25 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(int floorNumberingId, string floorNumbering, string expectedMessage)
		{
			// Arrange
			var floorNumber = FloorNumbering.Create(1, "1st Floor");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => floorNumber.Update(floorNumberingId, floorNumbering));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

