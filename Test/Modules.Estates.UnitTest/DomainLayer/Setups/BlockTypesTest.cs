// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/BlockTypesTest.cs
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
	public class BlockTypesTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateBlockTypes()
		{
			// Arrange
			int blockTypeId = 1;
			string blockType = "Residential";

			// Act
			var blockTypes = BlockTypes.Create(blockTypeId, blockType);

			// Assert
			Assert.Equal(blockTypeId, blockTypes.BlockTypeId);
			Assert.Equal(blockType, blockTypes.BlockType);
		}

		[Theory]
		[InlineData(-1, "Residential", "Block Type Id must be greater than zero.")]
		[InlineData(1, "", "Block Type cannot be empty or exceed 20 characters.")]
		[InlineData(1, null, "Block Type cannot be empty or exceed 20 characters.")]
		[InlineData(1, "This block type name is way too long and exceeds the maximum allowed length", "Block Type cannot be empty or exceed 20 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int blockTypeId, string blockType, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => BlockTypes.Create(blockTypeId, blockType));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateBlockTypes()
		{
			// Arrange
			var blockTypes = BlockTypes.Create(1, "Residential");
			int newBlockTypeId = 2;
			string newBlockType = "Commercial";

			// Act
			blockTypes.Update(newBlockTypeId, newBlockType);

			// Assert
			Assert.Equal(newBlockTypeId, blockTypes.BlockTypeId);
			Assert.Equal(newBlockType, blockTypes.BlockType);
		}

		[Theory]
		[InlineData(-1, "Residential", "Block Type Id must be greater than zero.")]
		[InlineData(1, "", "Block Type cannot be empty or exceed 20 characters.")]
		[InlineData(1, null, "Block Type cannot be empty or exceed 20 characters.")]
		[InlineData(1, "This block type name is way too long and exceeds the maximum allowed length", "Block Type cannot be empty or exceed 20 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int blockTypeId, string blockType, string expectedMessage)
		{
			// Arrange
			var blockTypes = BlockTypes.Create(1, "Residential");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				blockTypes.Update(blockTypeId, blockType));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

