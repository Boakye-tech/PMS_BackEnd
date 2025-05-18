// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/BlockSidesTest.cs
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
	public class BlockSidesTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateBlockSides()
		{
			// Arrange
			int sideId = 1;
			string side = "North";

			// Act
			var blockSides = BlockSides.Create(sideId, side);

			// Assert
			Assert.Equal(sideId, blockSides.SideId);
			Assert.Equal(side, blockSides.Side);
		}

		[Theory]
		[InlineData(-1, "North", "Block Side Id must be greater than zero.")]
		[InlineData(1, "", "Block Side cannot be empty or exceed 10 characters.")]
		[InlineData(1, null, "Block Side cannot be empty or exceed 10 characters.")]
		[InlineData(1, "This side name is way too long", "Block Side cannot be empty or exceed 10 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(int sideId, string side, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => BlockSides.Create(sideId, side));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateBlockSides()
		{
			// Arrange
			var blockSides = BlockSides.Create(1, "North");
			int newSideId = 2;
			string newSide = "South";

			// Act
			blockSides.Update(newSideId, newSide);

			// Assert
			Assert.Equal(newSideId, blockSides.SideId);
			Assert.Equal(newSide, blockSides.Side);
		}

		[Theory]
		[InlineData(-1, "North", "Block Side Id must be greater than zero.")]
		[InlineData(1, "", "Block Side cannot be empty or exceed 10 characters.")]
		[InlineData(1, null, "Block Side cannot be empty or exceed 10 characters.")]
		[InlineData(1, "This side name is way too long", "Block Side cannot be empty or exceed 10 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int sideId, string side, string expectedMessage)
		{
			// Arrange
			var blockSides = BlockSides.Create(1, "North");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				blockSides.Update(sideId, side));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

