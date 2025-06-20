// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/BlockTypeServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:21 PM
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
	public class BlockTypeServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly BlockTypeService _blockTypeService;

		public BlockTypeServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_blockTypeService = new BlockTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetBlockTypeAsync_ShouldReturnAllBlockTypes()
		{
			// Arrange
			var blockTypes = new List<BlockTypes>();
			var blockTypeDtos = new List<BlockTypeReadDto>();
			_unitOfWorkMock.Setup(x => x.BlockType.GetAll()).ReturnsAsync(blockTypes);
			_mapperMock.Setup(x => x.Map<IEnumerable<BlockTypeReadDto>>(blockTypes)).Returns(blockTypeDtos);

			// Act
			var result = await _blockTypeService.GetBlockTypeAsync();

			// Assert
			Assert.Equal(blockTypeDtos, result);
			_unitOfWorkMock.Verify(x => x.BlockType.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetBlockTypeAsync_WithValidId_ShouldReturnBlockType()
		{
			// Arrange
			int blockTypeId = 1;
			var blockType = new BlockTypes(blockTypeId, "TYPE");
			var blockTypeDto = new BlockTypeReadDto(blockTypeId, "TYPE");
			_unitOfWorkMock.Setup(x => x.BlockType.Get(blockTypeId)).ReturnsAsync(blockType);
			_mapperMock.Setup(x => x.Map<BlockTypeReadDto>(blockType)).Returns(blockTypeDto);

			// Act
			var result = await _blockTypeService.GetBlockTypeAsync(blockTypeId);

			// Assert
			Assert.Equal(blockTypeDto, result);
			_unitOfWorkMock.Verify(x => x.BlockType.Get(blockTypeId), Times.Once);
		}

		[Fact]
		public async Task GetBlockTypeAsync_WithValidString_ShouldReturnBlockType()
		{
			// Arrange
			string value = "test";
			var blockType = new BlockTypes(1, "TYPE");
			var blockTypeDto = new BlockTypeReadDto(1, "TYPE");
			_unitOfWorkMock.Setup(x => x.BlockType.Get(It.IsAny<Expression<Func<BlockTypes, bool>>>(), null)).ReturnsAsync(blockType);
			_mapperMock.Setup(x => x.Map<BlockTypeReadDto>(blockType)).Returns(blockTypeDto);

			// Act
			var result = await _blockTypeService.GetBlockTypeAsync(value);

			// Assert
			Assert.Equal(blockTypeDto, result);
			_unitOfWorkMock.Verify(x => x.BlockType.Get(It.IsAny<Expression<Func<BlockTypes, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateBlockTypeAsync_WithValidData_ShouldCreateBlockType()
		{
			// Arrange
			var createDto = new BlockTypeCreateDto
			(
				blockType: "Test Type",
				createdby: "testuser"
			);

			var blockType = BlockTypes.Create(0, createDto.blockType!);
			var blockTypeDto = new BlockTypeReadDto(0, createDto.blockType!);

			_unitOfWorkMock.Setup(x => x.BlockType.Get(It.IsAny<Expression<Func<BlockTypes, bool>>>(), null)).ReturnsAsync((BlockTypes)null!);
			_mapperMock.Setup(x => x.Map<BlockTypeReadDto>(It.IsAny<BlockTypes>())).Returns(blockTypeDto);

			// Act
			var result = await _blockTypeService.CreateBlockTypeAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockType.Insert(It.IsAny<BlockTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateBlockTypeAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockTypeCreateDto
			(
				blockType: "Test Type",
				createdby: "testuser"
			);

			var existingBlockType = BlockTypes.Create(2, "Test Type");
			_unitOfWorkMock.Setup(x => x.BlockType.Get(It.IsAny<Expression<Func<BlockTypes, bool>>>(), null)).ReturnsAsync(existingBlockType);

			// Act
			var result = await _blockTypeService.CreateBlockTypeAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Block Type already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateBlockTypeAsync_WithValidData_ShouldUpdateBlockType()
		{
			// Arrange
			var updateDto = new BlockTypeUpdateDto
			(
				blockTypeId: 1,
				blockType: "Updated Type",
				modifiedby: "testuser"
			);

			var existingBlockType = BlockTypes.Create(1, "Old Type");
			var blockTypeDto = new BlockTypeReadDto(1, "Old Type");

			_unitOfWorkMock.Setup(x => x.BlockType.Get(updateDto.blockTypeId)).ReturnsAsync(existingBlockType);
			_mapperMock.Setup(x => x.Map<BlockTypeReadDto>(It.IsAny<BlockTypes>())).Returns(blockTypeDto);

			// Act
			var result = await _blockTypeService.UpdateBlockTypeAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockType.Update(It.IsAny<BlockTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateBlockTypeAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockTypeUpdateDto
			(
				blockTypeId: 999,
				blockType: "Test Type",
				modifiedby: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.BlockType.Get(updateDto.blockTypeId)).ReturnsAsync((BlockTypes)null!);

			// Act
			var result = await _blockTypeService.UpdateBlockTypeAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteBlockType_WithValidId_ShouldDeleteBlockType()
		{
			// Arrange
			int blockTypeId = 1;
			var existingBlockType = BlockTypes.Create(blockTypeId, "Test Type");
			_unitOfWorkMock.Setup(x => x.BlockType.Get(blockTypeId)).ReturnsAsync(existingBlockType);

			// Act
			var result = await _blockTypeService.DeleteBlockType(blockTypeId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockType.Delete(It.IsAny<BlockTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteBlockType_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int blockTypeId = 999;
			_unitOfWorkMock.Setup(x => x.BlockType.Get(blockTypeId)).ReturnsAsync((BlockTypes)null!);

			// Act
			var result = await _blockTypeService.DeleteBlockType(blockTypeId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

