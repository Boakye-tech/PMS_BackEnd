// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/BlockSideServiceTests.cs
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
	public class BlockSideServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly BlockSideService _blockSideService;

		public BlockSideServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_blockSideService = new BlockSideService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetBlockSideAsync_ShouldReturnAllBlockSides()
		{
			// Arrange
			var blockSides = new List<BlockSides>();
			var blockSideDtos = new List<BlockSideReadDto>();
			_unitOfWorkMock.Setup(x => x.BlockSides.GetAll()).ReturnsAsync(blockSides);
			_mapperMock.Setup(x => x.Map<IEnumerable<BlockSideReadDto>>(blockSides)).Returns(blockSideDtos);

			// Act
			var result = await _blockSideService.GetBlockSideAsync();

			// Assert
			Assert.Equal(blockSideDtos, result);
			_unitOfWorkMock.Verify(x => x.BlockSides.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetBlockSideAsync_WithValidId_ShouldReturnBlockSide()
		{
			// Arrange
			int blockSideId = 1;
			var blockSide = new BlockSides(blockSideId, "SIDE");
			var blockSideDto = new BlockSideReadDto(blockSideId, "SIDE");
			_unitOfWorkMock.Setup(x => x.BlockSides.Get(blockSideId)).ReturnsAsync(blockSide);
			_mapperMock.Setup(x => x.Map<BlockSideReadDto>(blockSide)).Returns(blockSideDto);

			// Act
			var result = await _blockSideService.GetBlockSideAsync(blockSideId);

			// Assert
			Assert.Equal(blockSideDto, result);
			_unitOfWorkMock.Verify(x => x.BlockSides.Get(blockSideId), Times.Once);
		}

		[Fact]
		public async Task GetBlockSideAsync_WithValidString_ShouldReturnBlockSide()
		{
			// Arrange
			string value = "test";
			var blockSide = new BlockSides(1, "SIDE");
			var blockSideDto = new BlockSideReadDto(1, "SIDE");
			_unitOfWorkMock.Setup(x => x.BlockSides.Get(It.IsAny<Expression<Func<BlockSides, bool>>>(), null)).ReturnsAsync(blockSide);
			_mapperMock.Setup(x => x.Map<BlockSideReadDto>(blockSide)).Returns(blockSideDto);

			// Act
			var result = await _blockSideService.GetBlockSideAsync(value);

			// Assert
			Assert.Equal(blockSideDto, result);
			_unitOfWorkMock.Verify(x => x.BlockSides.Get(It.IsAny<Expression<Func<BlockSides, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateBlockSideAsync_WithValidData_ShouldCreateBlockSide()
		{
			// Arrange
			var createDto = new BlockSideCreateDto
			(
				side: "Test Side",
				createdby: "testuser"
			);

			var blockSide = BlockSides.Create(0, createDto.side!);
			var blockSideDto = new BlockSideReadDto(0, createDto.side!);

			_unitOfWorkMock.Setup(x => x.BlockSides.Get(It.IsAny<Expression<Func<BlockSides, bool>>>(), null)).ReturnsAsync((BlockSides)null!);
			_mapperMock.Setup(x => x.Map<BlockSideReadDto>(It.IsAny<BlockSides>())).Returns(blockSideDto);

			// Act
			var result = await _blockSideService.CreateBlockSideAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockSides.Insert(It.IsAny<BlockSides>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateBlockSideAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new BlockSideCreateDto
			(
				side: "Test Side",
				createdby: "testuser"
			);

			var existingBlockSide = BlockSides.Create(2, "Test Side");
			_unitOfWorkMock.Setup(x => x.BlockSides.Get(It.IsAny<Expression<Func<BlockSides, bool>>>(), null)).ReturnsAsync(existingBlockSide);

			// Act
			var result = await _blockSideService.CreateBlockSideAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Block Side already exists.", result.ErrorResponse.Message);
		}

        [Fact]
        public async Task CreateBlockSideAsync_WithLongerName_ShouldReturnError()
        {
            // Arrange
            var createDto = new BlockSideCreateDto
            (
                side: "Testing Sides",
                createdby: "testuser"
            );

            var blockSide = BlockSides.Create(0, "Side One");
            var blockSideDto = new BlockSideReadDto(0, "Side One");

            _unitOfWorkMock.Setup(x => x.BlockSides.Get(It.IsAny<Expression<Func<BlockSides, bool>>>(), null)).ReturnsAsync((BlockSides)null!);
            _mapperMock.Setup(x => x.Map<BlockSideReadDto>(It.IsAny<BlockSides>())).Returns(blockSideDto);


            // Act
            var result = await _blockSideService.CreateBlockSideAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
            Assert.Equal("Block Side cannot be empty or exceed 10 characters.", result.ErrorResponse.Message);
        }

        [Fact]
		public async Task UpdateBlockSideAsync_WithValidData_ShouldUpdateBlockSide()
		{
			// Arrange
			var updateDto = new BlockSideUpdateDto
			(
				sideId: 1,
				side: "New Side",
				modifiedby: "testuser"
			);

            

            var existingBlockSide = BlockSides.Create(1, "Old Side");
			var blockSideDto = new BlockSideReadDto(1, "Old Side");

			_unitOfWorkMock.Setup(x => x.BlockSides.Get(updateDto.sideId)).ReturnsAsync(existingBlockSide);
			_mapperMock.Setup(x => x.Map<BlockSideReadDto>(It.IsAny<BlockSides>())).Returns(blockSideDto);

			// Act
			var result = await _blockSideService.UpdateBlockSideAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockSides.Update(It.IsAny<BlockSides>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}



		[Fact]
		public async Task UpdateBlockSideAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new BlockSideUpdateDto
			(
				sideId: 999,
				side: "Test Side",
				modifiedby: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.BlockSides.Get(updateDto.sideId)).ReturnsAsync((BlockSides)null!);

			// Act
			var result = await _blockSideService.UpdateBlockSideAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteBlockSide_WithValidId_ShouldDeleteBlockSide()
		{
			// Arrange
			int blockSideId = 1;
			var existingBlockSide = BlockSides.Create(blockSideId, "Test Side");
			_unitOfWorkMock.Setup(x => x.BlockSides.Get(blockSideId)).ReturnsAsync(existingBlockSide);

			// Act
			var result = await _blockSideService.DeleteBlockSide(blockSideId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.BlockSides.Delete(It.IsAny<BlockSides>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteBlockSide_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int blockSideId = 999;
			_unitOfWorkMock.Setup(x => x.BlockSides.Get(blockSideId)).ReturnsAsync((BlockSides)null!);

			// Act
			var result = await _blockSideService.DeleteBlockSide(blockSideId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

