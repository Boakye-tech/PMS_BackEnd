// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/FloorNumberingServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:33 PM
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
	public class FloorNumberingServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly FloorNumberingService _floorNumberingService;

		public FloorNumberingServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_floorNumberingService = new FloorNumberingService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetFloorNumberingAsync_ShouldReturnAllFloorNumberings()
		{
			// Arrange
			var floorNumberings = new List<FloorNumbering>();
			var floorNumberingDtos = new List<FloorNumberingReadDto>();
			_unitOfWorkMock.Setup(x => x.FloorNumbering.GetAll()).ReturnsAsync(floorNumberings);
			_mapperMock.Setup(x => x.Map<IEnumerable<FloorNumberingReadDto>>(floorNumberings)).Returns(floorNumberingDtos);

			// Act
			var result = await _floorNumberingService.GetFloorNumberingAsync();

			// Assert
			Assert.Equal(floorNumberingDtos, result);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetFloorNumberingAsync_WithValidId_ShouldReturnFloorNumbering()
		{
			// Arrange
			int floorNumberingId = 1;
			var floorNumbering = new FloorNumbering(floorNumberingId, "FLOOR");
			var floorNumberingDto = new FloorNumberingReadDto(floorNumberingId, "FLOOR");
			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(floorNumberingId)).ReturnsAsync(floorNumbering);
			_mapperMock.Setup(x => x.Map<FloorNumberingReadDto>(floorNumbering)).Returns(floorNumberingDto);

			// Act
			var result = await _floorNumberingService.GetFloorNumberingAsync(floorNumberingId);

			// Assert
			Assert.Equal(floorNumberingDto, result);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.Get(floorNumberingId), Times.Once);
		}

		[Fact]
		public async Task GetFloorNumberingAsync_WithValidString_ShouldReturnFloorNumbering()
		{
			// Arrange
			string value = "test";
			var floorNumbering = new FloorNumbering(1, "FLOOR");
			var floorNumberingDto = new FloorNumberingReadDto(1, "FLOOR");
			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(It.IsAny<Expression<Func<FloorNumbering, bool>>>(), null)).ReturnsAsync(floorNumbering);
			_mapperMock.Setup(x => x.Map<FloorNumberingReadDto>(floorNumbering)).Returns(floorNumberingDto);

			// Act
			var result = await _floorNumberingService.GetFloorNumberingAsync(value);

			// Assert
			Assert.Equal(floorNumberingDto, result);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.Get(It.IsAny<Expression<Func<FloorNumbering, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateFloorNumberingAsync_WithValidData_ShouldCreateFloorNumbering()
		{
			// Arrange
			var createDto = new FloorNumberingCreateDto
			(
				floorNumber: "Test Floor",
				createdby: "testuser"
			);

			var floorNumbering = FloorNumbering.Create(0, createDto.floorNumber!);
			var floorNumberingDto = new FloorNumberingReadDto(0, createDto.floorNumber!);

			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(It.IsAny<Expression<Func<FloorNumbering, bool>>>(), null)).ReturnsAsync((FloorNumbering)null!);
			_mapperMock.Setup(x => x.Map<FloorNumberingReadDto>(It.IsAny<FloorNumbering>())).Returns(floorNumberingDto);

			// Act
			var result = await _floorNumberingService.CreateFloorNumberingAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.Insert(It.IsAny<FloorNumbering>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateFloorNumberingAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new FloorNumberingCreateDto
			(
				floorNumber: "Test Floor",
				createdby: "testuser"
			);

			var existingFloorNumbering = FloorNumbering.Create(2, "Test Floor");
			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(It.IsAny<Expression<Func<FloorNumbering, bool>>>(), null)).ReturnsAsync(existingFloorNumbering);

			// Act
			var result = await _floorNumberingService.CreateFloorNumberingAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Floor Number already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateFloorNumberingAsync_WithValidData_ShouldUpdateFloorNumbering()
		{
			// Arrange
			var updateDto = new FloorNumberingUpdateDto
			(
				floorNumberId: 1,
				floorNumber: "Updated Floor",
				modifiedby: "testuser"
			);

			var existingFloorNumbering = FloorNumbering.Create(1, "Old Floor");
			var floorNumberingDto = new FloorNumberingReadDto(1, "Old Floor");

			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(updateDto.floorNumberId)).ReturnsAsync(existingFloorNumbering);
			_mapperMock.Setup(x => x.Map<FloorNumberingReadDto>(It.IsAny<FloorNumbering>())).Returns(floorNumberingDto);

			// Act
			var result = await _floorNumberingService.UpdateFloorNumberingAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.Update(It.IsAny<FloorNumbering>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateFloorNumberingAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new FloorNumberingUpdateDto
			(
				floorNumberId: 999,
				floorNumber: "Test Floor",
				modifiedby: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(updateDto.floorNumberId)).ReturnsAsync((FloorNumbering)null!);

			// Act
			var result = await _floorNumberingService.UpdateFloorNumberingAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteFloorNumbering_WithValidId_ShouldDeleteFloorNumbering()
		{
			// Arrange
			int floorNumberingId = 1;
			var existingFloorNumbering = FloorNumbering.Create(floorNumberingId, "Test Floor");
			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(floorNumberingId)).ReturnsAsync(existingFloorNumbering);

			// Act
			var result = await _floorNumberingService.DeleteFloorNumbering(floorNumberingId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.FloorNumbering.Delete(It.IsAny<FloorNumbering>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteFloorNumbering_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int floorNumberingId = 999;
			_unitOfWorkMock.Setup(x => x.FloorNumbering.Get(floorNumberingId)).ReturnsAsync((FloorNumbering)null!);

			// Act
			var result = await _floorNumberingService.DeleteFloorNumbering(floorNumberingId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

