// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/BlockUnitTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:41 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class BlockUnitTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateBlockUnit()
		{
			// Arrange
			int blockUnitId = 1;
			string blockUnit = "A";

			// Act
			var blockunit = BlockUnit.Create(blockUnitId, blockUnit);

			// Assert
			Assert.Equal(blockUnitId, blockunit.UnitId);
			Assert.Equal(blockUnit, blockunit.Unit);
		}

		[Theory]
		[InlineData(-1, "Unit 101", "Block Unit Id must be greater than zero.")]
		[InlineData(1, "", "Block Unit cannot be empty or exceed 2 characters.")]
		[InlineData(1, null, "Block Unit cannot be empty or exceed 2 characters.")]
		[InlineData(1, "This unit name is way too long", "Block Unit cannot be empty or exceed 2 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int blockUnitId, string blockUnit, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => BlockUnit.Create(blockUnitId, blockUnit));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateBlockUnit()
		{
			// Arrange
			var blockunit = BlockUnit.Create(1, "A");
			int newBlockUnitId = 1;
			string newBlockUnit = "AA";

			// Act
			blockunit.Update(newBlockUnitId, newBlockUnit);

			// Assert
			Assert.Equal(newBlockUnitId, blockunit.UnitId);
			Assert.Equal(newBlockUnit, blockunit.Unit);
		}

		[Theory]
		[InlineData(-1, "Unit 101", "Block Unit Id must be greater than zero.")]
		[InlineData(1, "", "Block Unit cannot be empty or exceed 2 characters.")]
		[InlineData(1, null, "Block Unit cannot be empty or exceed 2 characters.")]
		[InlineData(1, "This unit name is way too long", "Block Unit cannot be empty or exceed 2 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(int blockUnitId, string blockUnit, string expectedMessage)
		{
			// Arrange
			var blockunit = BlockUnit.Create(1, "A");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => blockunit.Update(blockUnitId, blockUnit));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

