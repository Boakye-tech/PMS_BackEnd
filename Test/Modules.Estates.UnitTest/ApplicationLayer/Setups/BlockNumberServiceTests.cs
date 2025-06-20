// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/BlockNumberServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:22 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Moq;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.UseCases.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain;
using System.Linq.Expressions;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class BlockNumberServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly BlockNumberService _blockNumberService;

		public BlockNumberServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_blockNumberService = new BlockNumberService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetBlockNumberAsync_ShouldReturnAllBlockNumbers()
		{
			// Arrange
			var blockNumbers = new List<BlockNumber>();
			var blockNumberDtos = new List<BlockNumberReadDto>();
			_unitOfWorkMock.Setup(x => x.BlockNumber.GetAll()).ReturnsAsync(blockNumbers);
			_mapperMock.Setup(x => x.Map<IEnumerable<BlockNumberReadDto>>(blockNumbers)).Returns(blockNumberDtos);

			// Act
			var result = await _blockNumberService.GetBlockNumberAsync();

			// Assert
			Assert.Equal(blockNumberDtos, result);
			_unitOfWorkMock.Verify(x => x.BlockNumber.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetBlockNumberAsync_WithValidId_ShouldReturnBlockNumber()
		{
			// Arrange
			int blockNumberId = 1;
			var blockNumber = new BlockNumber(blockNumberId, "BLOCK");
			var blockNumberDto = new BlockNumberReadDto(blockNumberId, "BLOCK");
			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(blockNumberId)).ReturnsAsync(blockNumber);
			_mapperMock.Setup(x => x.Map<BlockNumberReadDto>(blockNumber)).Returns(blockNumberDto);

			// Act
			var result = await _blockNumberService.GetBlockNumberAsync(blockNumberId);

			// Assert
			Assert.Equal(blockNumberDto, result);
			_unitOfWorkMock.Verify(x => x.BlockNumber.Get(blockNumberId), Times.Once);
		}

		[Fact]
		public async Task GetBlockNumberAsync_WithValidString_ShouldReturnBlockNumber()
		{
			// Arrange
			string value = "test";
			var blockNumber = new BlockNumber(1, "BLOCK");
			var blockNumberDto = new BlockNumberReadDto(1, "BLOCK");
			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(It.IsAny<Expression<Func<BlockNumber, bool>>>(), null)).ReturnsAsync(blockNumber);
			_mapperMock.Setup(x => x.Map<BlockNumberReadDto>(blockNumber)).Returns(blockNumberDto);

			// Act
			var result = await _blockNumberService.GetBlockNumberAsync(value);

			// Assert
			Assert.Equal(blockNumberDto, result);
			_unitOfWorkMock.Verify(x => x.BlockNumber.Get(It.IsAny<Expression<Func<BlockNumber, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateBlockNumberAsync_WithValidData_ShouldCreateBlockNumber()
		{
			// Arrange
			var createDto = new BlockNumberCreateDto
			(
				blockNumbers: "8A",
				createdby: "testuser"
			);

			var blockNumber = BlockNumber.Create(0, createDto.blockNumbers!);
			var blockNumberDto = new BlockNumberReadDto(0, createDto.blockNumbers!);

			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(It.IsAny<Expression<Func<BlockNumber, bool>>>(), null)).ReturnsAsync((BlockNumber)null!);
			_mapperMock.Setup(x => x.Map<BlockNumberReadDto>(It.IsAny<BlockNumber>())).Returns(blockNumberDto);

			// Act
			var result = await _blockNumberService.CreateBlockNumberAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockNumber.Insert(It.IsAny<BlockNumber>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateBlockNumberAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockNumberCreateDto
			(
				blockNumbers: "8B",
				createdby: "testuser"
			);

			var existingBlockNumber = BlockNumber.Create(2, "8B");
			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(It.IsAny<Expression<Func<BlockNumber, bool>>>(), null)).ReturnsAsync(existingBlockNumber);

			// Act
			var result = await _blockNumberService.CreateBlockNumberAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Block Number already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateBlockNumberAsync_WithValidData_ShouldUpdateBlockNumber()
		{
			// Arrange
			var updateDto = new BlockNumberUpdateDto
			(
				blockNumberId: 1,
				blockNumbers: "108B",
				modifiedby: "testuser"
			);

			var existingBlockNumber = BlockNumber.Create(1, "118B");
			var blockNumberDto = new BlockNumberReadDto(1, "118B");

			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(updateDto.blockNumberId)).ReturnsAsync(existingBlockNumber);
			_mapperMock.Setup(x => x.Map<BlockNumberReadDto>(It.IsAny<BlockNumber>())).Returns(blockNumberDto);

			// Act
			var result = await _blockNumberService.UpdateBlockNumberAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockNumber.Update(It.IsAny<BlockNumber>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateBlockNumberAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockNumberUpdateDto
			(
				blockNumberId: 999,
				blockNumbers: "Test Block",
				modifiedby: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(updateDto.blockNumberId)).ReturnsAsync((BlockNumber)null!);

			// Act
			var result = await _blockNumberService.UpdateBlockNumberAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteBlockNumber_WithValidId_ShouldDeleteBlockNumber()
		{
			// Arrange
			int blockNumberId = 1;
			var existingBlockNumber = BlockNumber.Create(blockNumberId, "107D");
			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(blockNumberId)).ReturnsAsync(existingBlockNumber);

			// Act
			var result = await _blockNumberService.DeleteBlockNumber(blockNumberId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockNumber.Delete(It.IsAny<BlockNumber>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteBlockNumber_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int blockNumberId = 999;
			_unitOfWorkMock.Setup(x => x.BlockNumber.Get(blockNumberId)).ReturnsAsync((BlockNumber)null!);

			// Act
			var result = await _blockNumberService.DeleteBlockNumber(blockNumberId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

