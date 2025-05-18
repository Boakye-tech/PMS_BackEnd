// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/BlockNumberTest.cs
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
	public class BlockNumberTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateBlockNumber()
		{
			// Arrange
			int blockNumberId = 1;
			string blockNumbers = "A1";

			// Act
			var blockNumber = BlockNumber.Create(blockNumberId, blockNumbers);

			// Assert
			Assert.Equal(blockNumberId, blockNumber.BlockNumberId);
			Assert.Equal(blockNumbers, blockNumber.BlockNumbers);
		}

		[Theory]
		[InlineData(-1, "A1", "Block Number Id must be greater than zero.")]
		[InlineData(1, "", "Block Numbers cannot be empty or exceed 5 characters.")]
		[InlineData(1, null, "Block Numbers cannot be empty or exceed 5 characters.")]
		[InlineData(1, "A12345", "Block Numbers cannot be empty or exceed 5 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(int blockNumberId, string blockNumbers, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => BlockNumber.Create(blockNumberId, blockNumbers));

			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateBlockNumber()
		{
			// Arrange
			var blockNumber = BlockNumber.Create(1, "A1");
			int newBlockNumberId = 2;
			string newBlockNumbers = "B2";

			// Act
			blockNumber.Update(newBlockNumberId, newBlockNumbers);

			// Assert
			Assert.Equal(newBlockNumberId, blockNumber.BlockNumberId);
			Assert.Equal(newBlockNumbers, blockNumber.BlockNumbers);
		}

		[Theory]
		[InlineData(-1, "A1", "Block Number Id must be greater than zero.")]
		[InlineData(1, "", "Block Numbers cannot be empty or exceed 5 characters.")]
		[InlineData(1, null, "Block Numbers cannot be empty or exceed 5 characters.")]
		[InlineData(1, "A12345", "Block Numbers cannot be empty or exceed 5 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(int blockNumberId, string blockNumbers, string expectedMessage)
		{
			// Arrange
			var blockNumber = BlockNumber.Create(1, "A1");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => blockNumber.Update(blockNumberId, blockNumbers));

			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

