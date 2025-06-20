// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/BlockUnitServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:20 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
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
	public class BlockUnitServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly BlockUnitService _blockUnitService;

		public BlockUnitServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_blockUnitService = new BlockUnitService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetBlockUnitAsync_ShouldReturnAllBlockUnits()
		{
			// Arrange
			var blockUnits = new List<BlockUnit>();
			var blockUnitDtos = new List<BlockUnitReadDto>();
			_unitOfWorkMock.Setup(x => x.BlockUnit.GetAll()).ReturnsAsync(blockUnits);
			_mapperMock.Setup(x => x.Map<IEnumerable<BlockUnitReadDto>>(blockUnits)).Returns(blockUnitDtos);

			// Act
			var result = await _blockUnitService.GetBlockUnitAsync();

			// Assert
			Assert.Equal(blockUnitDtos, result);
			_unitOfWorkMock.Verify(x => x.BlockUnit.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetBlockUnitAsync_WithValidId_ShouldReturnBlockUnit()
		{
			// Arrange
			int blockUnitId = 1;
			var blockUnit = new BlockUnit(blockUnitId, "UNIT");
			var blockUnitDto = new BlockUnitReadDto(blockUnitId, "UNIT");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(blockUnitId)).ReturnsAsync(blockUnit);
			_mapperMock.Setup(x => x.Map<BlockUnitReadDto>(blockUnit)).Returns(blockUnitDto);

			// Act
			var result = await _blockUnitService.GetBlockUnitAsync(blockUnitId);

			// Assert
			Assert.Equal(blockUnitDto, result);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Get(blockUnitId), Times.Once);
		}

		[Fact]
		public async Task GetBlockUnitAsync_WithValidString_ShouldReturnBlockUnit()
		{
			// Arrange
			string value = "test";
			var blockUnit = new BlockUnit(1, "UNIT");
			var blockUnitDto = new BlockUnitReadDto(1, "UNIT");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(It.IsAny<Expression<Func<BlockUnit, bool>>>(), null)).ReturnsAsync(blockUnit);
			_mapperMock.Setup(x => x.Map<BlockUnitReadDto>(blockUnit)).Returns(blockUnitDto);

			// Act
			var result = await _blockUnitService.GetBlockUnitAsync(value);

			// Assert
			Assert.Equal(blockUnitDto, result);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Get(It.IsAny<Expression<Func<BlockUnit, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateBlockUnitAsync_WithValidData_ShouldCreateBlockUnit()
		{
			// Arrange
			var createDto = new BlockUnitCreateDto
			(
				unit: "A1",
				createdby: "testuser"
			);

			var blockUnit = BlockUnit.Create(0, createDto.unit!);
			var blockUnitDto = new BlockUnitReadDto(0, createDto.unit!);

			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(It.IsAny<Expression<Func<BlockUnit, bool>>>(), null)).ReturnsAsync((BlockUnit)null!);
			_mapperMock.Setup(x => x.Map<BlockUnitReadDto>(It.IsAny<BlockUnit>())).Returns(blockUnitDto);

			// Act
			var result = await _blockUnitService.CreateBlockUnitAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Insert(It.IsAny<BlockUnit>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateBlockUnitAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockUnitCreateDto
			(
				unit: "A2",
				createdby: "testuser"
			);

			var existingBlockUnit = BlockUnit.Create(2, "A2");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(It.IsAny<Expression<Func<BlockUnit, bool>>>(), null)).ReturnsAsync(existingBlockUnit);

			// Act
			var result = await _blockUnitService.CreateBlockUnitAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Block Unit already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateBlockUnitAsync_WithValidData_ShouldUpdateBlockUnit()
		{
			// Arrange
			var updateDto = new BlockUnitUpdateDto
			(
				unitId: 1,
				unit: "A3",
				modifiedby: "testuser"
			);

			var existingBlockUnit = BlockUnit.Create(1, "A2");
			var blockUnitDto = new BlockUnitReadDto(1, "A2");

			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(updateDto.unitId)).ReturnsAsync(existingBlockUnit);
			_mapperMock.Setup(x => x.Map<BlockUnitReadDto>(It.IsAny<BlockUnit>())).Returns(blockUnitDto);

			// Act
			var result = await _blockUnitService.UpdateBlockUnitAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Update(It.IsAny<BlockUnit>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateBlockUnitAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockUnitUpdateDto
			(
				unitId: 999,
				unit: "Test Unit",
				modifiedby: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(updateDto.unitId)).ReturnsAsync((BlockUnit)null!);

			// Act
			var result = await _blockUnitService.UpdateBlockUnitAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteBlockUnit_WithValidId_ShouldDeleteBlockUnit()
		{
			// Arrange
			int blockUnitId = 1;
			var existingBlockUnit = BlockUnit.Create(blockUnitId, "A2");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(blockUnitId)).ReturnsAsync(existingBlockUnit);

			// Act
			var result = await _blockUnitService.DeleteBlockUnit(blockUnitId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Delete(It.IsAny<BlockUnit>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteBlockUnit_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int blockUnitId = 999;
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(blockUnitId)).ReturnsAsync((BlockUnit)null!);

			// Act
			var result = await _blockUnitService.DeleteBlockUnit(blockUnitId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task CreateBlockUnitAsync_WithTooLongUnitName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockUnitCreateDto
			(
				unit: "A123456789012345678901234567890", // Assuming max length is 10 characters
				createdby: "testuser"
			);

            var blockUnit = BlockUnit.Create(0, "AA");
            var blockUnitDto = new BlockUnitReadDto(0, "AA");

            _unitOfWorkMock.Setup(x => x.BlockUnit.Get(It.IsAny<Expression<Func<BlockUnit, bool>>>(), null)).ReturnsAsync((BlockUnit)null!);
            _mapperMock.Setup(x => x.Map<BlockUnitReadDto>(It.IsAny<BlockUnit>())).Returns(blockUnitDto);

            // Act
            var result = await _blockUnitService.CreateBlockUnitAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
			Assert.Equal("Block Unit cannot be empty or exceed 2 characters.", result.ErrorResponse.Message);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Insert(It.IsAny<BlockUnit>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}


		[Fact]
		public async Task UpdateBlockUnitAsync_WithTooLongUnitName_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockUnitUpdateDto
			(
				unitId: 1,
				unit: "A123456789012345678901234567890", // Assuming max length is 10 characters
				modifiedby: "testuser"
			);

			var existingBlockUnit = BlockUnit.Create(1, "A2");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(updateDto.unitId)).ReturnsAsync(existingBlockUnit);

			// Act
			var result = await _blockUnitService.UpdateBlockUnitAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
			Assert.Equal("Block Unit cannot be empty or exceed 2 characters.", result.ErrorResponse.Message);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Update(It.IsAny<BlockUnit>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}

		[Fact]
		public async Task CreateBlockUnitAsync_WithEmptyUnitName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockUnitCreateDto
			(
				unit: "",
				createdby: "testuser"
			);

			// Act
			var result = await _blockUnitService.CreateBlockUnitAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Block Unit name cannot be empty.", result.ErrorResponse.Message);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Insert(It.IsAny<BlockUnit>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}

		[Fact]
		public async Task UpdateBlockUnitAsync_WithEmptyUnitName_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockUnitUpdateDto
			(
				unitId: 1,
				unit: "",
				modifiedby: "testuser"
			);

			var existingBlockUnit = BlockUnit.Create(1, "A2");
			_unitOfWorkMock.Setup(x => x.BlockUnit.Get(updateDto.unitId)).ReturnsAsync(existingBlockUnit);

			// Act
			var result = await _blockUnitService.UpdateBlockUnitAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
			Assert.Equal("Block Unit cannot be empty or exceed 2 characters.", result.ErrorResponse.Message);
			_unitOfWorkMock.Verify(x => x.BlockUnit.Update(It.IsAny<BlockUnit>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}
	}
}

