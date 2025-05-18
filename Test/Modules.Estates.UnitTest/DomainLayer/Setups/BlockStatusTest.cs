// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/BlockStatusTest.cs
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
	public class BlockStatusTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateBlockStatus()
		{
			// Arrange
			int blockStatusId = 1;
			string blockStatus = "Available";

			// Act
			var blockstatus = BlockStatus.Create(blockStatusId, blockStatus);

			// Assert
			Assert.Equal(blockStatusId, blockstatus.BlockStatusId);
			Assert.Equal(blockStatus, blockstatus.BlockStatusType);
		}

		[Theory]
		[InlineData(-1, "Available", "Block Status Id must be greater than zero.")]
		[InlineData(1, "", "Block Status Type cannot be empty or exceed 25 characters.")]
		[InlineData(1, null, "Block Status Type cannot be empty or exceed 25 characters.")]
		[InlineData(1, "This status name type is way too long and exceeds the maximum allowed length", "Block Status Type cannot be empty or exceed 25 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(int blockStatusId, string blockStatus, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => BlockStatus.Create(blockStatusId, blockStatus));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateBlockStatus()
		{
			// Arrange
			var blockStatus = BlockStatus.Create(1, "Available");
			int newBlockStatusId = 2;
			string newBlockStatus = "Occupied";

			// Act
			blockStatus.Update(newBlockStatusId, newBlockStatus);

			// Assert
			Assert.Equal(newBlockStatusId, blockStatus.BlockStatusId);
			Assert.Equal(newBlockStatus, blockStatus.BlockStatusType);
		}

		[Theory]
		[InlineData(-1, "Available", "Block Status Id must be greater than zero.")]
		[InlineData(1, "", "Block Status Type cannot be empty or exceed 25 characters.")]
		[InlineData(1, null, "Block Status Type cannot be empty or exceed 25 characters.")]
		[InlineData(1, "This status name is way too long and exceeds the maximum allowed length", "Block Status Type cannot be empty or exceed 25 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int blockStatusId, string blockStatus, string expectedMessage)
		{
			// Arrange
			var blockstatus = BlockStatus.Create(1, "Available");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => blockstatus.Update(blockStatusId, blockStatus));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

