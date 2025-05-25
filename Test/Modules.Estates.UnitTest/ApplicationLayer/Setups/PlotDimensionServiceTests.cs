// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/PlotDimensionServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:32 PM
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
	public class PlotDimensionServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly PlotDimensionService _plotDimensionService;

		public PlotDimensionServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_plotDimensionService = new PlotDimensionService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetPlotDimensionAsync_ShouldReturnAllPlotDimensions()
		{
			// Arrange
			var PlotDimensions = new List<PlotDimension>();
			var PlotDimensionDtos = new List<PlotDimensionReadDto>();
			_unitOfWorkMock.Setup(x => x.PlotDimension.GetAll()).ReturnsAsync(PlotDimensions);
			_mapperMock.Setup(x => x.Map<IEnumerable<PlotDimensionReadDto>>(PlotDimensions)).Returns(PlotDimensionDtos);

			// Act
			var result = await _plotDimensionService.GetPlotDimensionAsync();

			// Assert
			Assert.Equal(PlotDimensionDtos, result);
			_unitOfWorkMock.Verify(x => x.PlotDimension.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetPlotDimensionAsync_WithValidId_ShouldReturnPlotDimension()
		{
			// Arrange
			int PlotDimensionId = 1;
			var PlotDimension = new PlotDimension(PlotDimensionId, "70x100");
			var PlotDimensionDto = new PlotDimensionReadDto(PlotDimensionId, "70x100");
			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(PlotDimensionId)).ReturnsAsync(PlotDimension);
			_mapperMock.Setup(x => x.Map<PlotDimensionReadDto>(PlotDimension)).Returns(PlotDimensionDto);

			// Act
			var result = await _plotDimensionService.GetPlotDimensionAsync(PlotDimensionId);

			// Assert
			Assert.Equal(PlotDimensionDto, result);
			_unitOfWorkMock.Verify(x => x.PlotDimension.Get(PlotDimensionId), Times.Once);
		}

		[Fact]
		public async Task GetPlotDimensionAsync_WithValidString_ShouldReturnPlotDimension()
		{
			// Arrange
			string value = "test";
			var PlotDimension = new PlotDimension(1, "70x100");
			var PlotDimensionDto = new PlotDimensionReadDto(1, "70x100");
			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(It.IsAny<Expression<Func<PlotDimension, bool>>>(), null)).ReturnsAsync(PlotDimension);
			_mapperMock.Setup(x => x.Map<PlotDimensionReadDto>(PlotDimension)).Returns(PlotDimensionDto);

			// Act
			var result = await _plotDimensionService.GetPlotDimensionAsync(value);

			// Assert
			Assert.Equal(PlotDimensionDto, result);
			_unitOfWorkMock.Verify(x => x.PlotDimension.Get(It.IsAny<Expression<Func<PlotDimension, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreatePlotDimensionAsync_WithValidData_ShouldCreatePlotDimension()
		{
			// Arrange
			var createDto = new PlotDimensionCreateDto
			(
				PlotDimensions: "70x100",
				CreatedBy: "testuser"
			);

			var PlotDimension = _plotDimensionService.CreatePlotDimensionAsync(createDto);
			var PlotDimensionDto = new PlotDimensionReadDto(0, createDto.PlotDimensions!);

			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(It.IsAny<Expression<Func<PlotDimension, bool>>>(), null)).ReturnsAsync((PlotDimension)null!);
			_mapperMock.Setup(x => x.Map<PlotDimensionReadDto>(It.IsAny<PlotDimension>())).Returns(PlotDimensionDto);

			// Act
			var result = await _plotDimensionService.CreatePlotDimensionAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PlotDimension.Insert(It.IsAny<PlotDimension>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreatePlotDimensionAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new PlotDimensionCreateDto
			(
				PlotDimensions: "70x100",
				CreatedBy: "testuser"
			);

			var existingPlotDimension = PlotDimension.Create(2, "70x100");
			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(It.IsAny<Expression<Func<PlotDimension, bool>>>(), null)).ReturnsAsync(existingPlotDimension);

			// Act
			var result = await _plotDimensionService.CreatePlotDimensionAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Plot Dimension already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task CreatePlotDimensionAsync_WithPlotDimensionsTooLong_ShouldReturnError()
		{
			// Arrange
			// Assuming a max length of 22 for PlotDimensions for this test example
			string longPlotDimension = new string('x', 22);
			var createDto = new PlotDimensionCreateDto
			(
				PlotDimensions: longPlotDimension,
				CreatedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(It.IsAny<Expression<Func<PlotDimension, bool>>>(), null))
						   .ReturnsAsync((PlotDimension)null!); // Ensure it's not an "already exists" error

			// Act
			var result = await _plotDimensionService.CreatePlotDimensionAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.NotNull(result.ErrorResponse);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
			Assert.False(string.IsNullOrEmpty(result.ErrorResponse.Message), "Plot Dimension cannot be empty or exceed 20 characters.");

			_unitOfWorkMock.Verify(x => x.PlotDimension.Insert(It.IsAny<PlotDimension>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}

		[Fact]
		public async Task UpdatePlotDimensionAsync_WithValidData_ShouldUpdatePlotDimension()
		{
			// Arrange
			var updateDto = new PlotDimensionUpdateDto
			(
				PlotDimensionId: 1,
				PlotDimensions: "80x120",
				ModifiedBy: "testuser"
			);

			var existingPlotDimension = PlotDimension.Create(1, "70x100");
			var PlotDimensionDto = new PlotDimensionReadDto(1, "70x100");

			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(updateDto.PlotDimensionId)).ReturnsAsync(existingPlotDimension);
			_mapperMock.Setup(x => x.Map<PlotDimensionReadDto>(It.IsAny<PlotDimension>())).Returns(PlotDimensionDto);

			// Act
			var result = await _plotDimensionService.UpdatePlotDimensionAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PlotDimension.Update(It.IsAny<PlotDimension>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdatePlotDimensionAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new PlotDimensionUpdateDto
			(
				PlotDimensionId: 999,
				PlotDimensions: "80x120",
				ModifiedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(updateDto.PlotDimensionId)).ReturnsAsync((PlotDimension)null!);

			// Act
			var result = await _plotDimensionService.UpdatePlotDimensionAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task UpdatePlotDimensionAsync_WithPlotDimensionsTooLong_ShouldReturnError()
		{
			// Arrange
			// Assuming a max length of 21 for PlotDimensions for this test example
			string longPlotDimension = new string('p', 21);
			var updateDto = new PlotDimensionUpdateDto
			(
				PlotDimensionId: 1,
				PlotDimensions: longPlotDimension,
				ModifiedBy: "testuser"
			);

			var existingPlotDimension = PlotDimension.Create(1, "70x100");
			var PlotDimensionDto = new PlotDimensionReadDto(1, "70x100");

			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(updateDto.PlotDimensionId)).ReturnsAsync(existingPlotDimension);
			_mapperMock.Setup(x => x.Map<PlotDimensionReadDto>(It.IsAny<PlotDimension>())).Returns(PlotDimensionDto);


			// Act
			var result = await _plotDimensionService.UpdatePlotDimensionAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.NotNull(result.ErrorResponse);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
			Assert.False(string.IsNullOrEmpty(result.ErrorResponse.Message), "Plot Dimension cannot be empty or exceed 20 characters.");

			_unitOfWorkMock.Verify(x => x.PlotDimension.Update(It.IsAny<PlotDimension>()), Times.Never);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
		}

		[Fact]
		public async Task DeletePlotDimension_WithValidId_ShouldDeletePlotDimension()
		{
			// Arrange
			int PlotDimensionId = 1;
			var existingPlotDimension = PlotDimension.Create(PlotDimensionId, "70x100");
			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(PlotDimensionId)).ReturnsAsync(existingPlotDimension);

			// Act
			var result = await _plotDimensionService.DeletePlotDimension(PlotDimensionId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PlotDimension.Delete(It.IsAny<PlotDimension>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeletePlotDimension_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int PlotDimensionId = 999;
			_unitOfWorkMock.Setup(x => x.PlotDimension.Get(PlotDimensionId)).ReturnsAsync((PlotDimension)null!);

			// Act
			var result = await _plotDimensionService.DeletePlotDimension(PlotDimensionId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

