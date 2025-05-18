// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/PropertyHeightServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:31 PM
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
using System.Collections.Generic;
using System.Linq.Expressions;
using Xunit;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class PropertyHeightServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly PropertyHeightService _propertyHeightService;

		public PropertyHeightServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_propertyHeightService = new PropertyHeightService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetPropertyHeightAsync_ShouldReturnAllPropertyHeights()
		{
			// Arrange
			var propertyHeights = new List<PropertyHeight>();
			var propertyHeightDtos = new List<PropertyHeightReadDto>();
			_unitOfWorkMock.Setup(x => x.PropertyHeight.GetAll()).ReturnsAsync(propertyHeights);
			_mapperMock.Setup(x => x.Map<IEnumerable<PropertyHeightReadDto>>(propertyHeights)).Returns(propertyHeightDtos);

			// Act
			var result = await _propertyHeightService.GetPropertyHeightAsync();

			// Assert
			Assert.Equal(propertyHeightDtos, result);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetPropertyHeightAsync_WithValidId_ShouldReturnPropertyHeight()
		{
			// Arrange
			int propertyHeightId = 1;
			var propertyHeight = new PropertyHeight(propertyHeightId, "HEIGHT");
			var propertyHeightDto = new PropertyHeightReadDto(propertyHeightId, "HEIGHT");
			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(propertyHeightId)).ReturnsAsync(propertyHeight);
			_mapperMock.Setup(x => x.Map<PropertyHeightReadDto>(propertyHeight)).Returns(propertyHeightDto);

			// Act
			var result = await _propertyHeightService.GetPropertyHeightAsync(propertyHeightId);

			// Assert
			Assert.Equal(propertyHeightDto, result);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.Get(propertyHeightId), Times.Once);
		}

		[Fact]
		public async Task GetPropertyHeightAsync_WithValidString_ShouldReturnPropertyHeight()
		{
			// Arrange
			string value = "test";
			var propertyHeight = new PropertyHeight(1, "HEIGHT");
			var propertyHeightDto = new PropertyHeightReadDto(1, "HEIGHT");
			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(It.IsAny<Expression<Func<PropertyHeight, bool>>>(), null)).ReturnsAsync(propertyHeight);
			_mapperMock.Setup(x => x.Map<PropertyHeightReadDto>(propertyHeight)).Returns(propertyHeightDto);

			// Act
			var result = await _propertyHeightService.GetPropertyHeightAsync(value);

			// Assert
			Assert.Equal(propertyHeightDto, result);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.Get(It.IsAny<Expression<Func<PropertyHeight, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreatePropertyHeightAsync_WithValidData_ShouldCreatePropertyHeight()
		{
			// Arrange
			var createDto = new PropertyHeightCreateDto
			(
				propertyHeights: "Test Height",
				createdBy: "testuser"
			);

			var propertyHeight = PropertyHeight.Create(0, createDto.propertyHeights!);
			var propertyHeightDto = new PropertyHeightReadDto(0, createDto.propertyHeights!);

			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(It.IsAny<Expression<Func<PropertyHeight, bool>>>(), null)).ReturnsAsync((PropertyHeight)null!);
			_mapperMock.Setup(x => x.Map<PropertyHeightReadDto>(It.IsAny<PropertyHeight>())).Returns(propertyHeightDto);

			// Act
			var result = await _propertyHeightService.CreatePropertyHeightAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.Insert(It.IsAny<PropertyHeight>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreatePropertyHeightAsync_WithExistingName_ShouldReturnError()
		{
			// Arrange
			var createDto = new PropertyHeightCreateDto
			(
				propertyHeights: "Test Height",
				createdBy: "testuser"
			);

			var existingPropertyHeight = PropertyHeight.Create(2, "Test Height");
			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(It.IsAny<Expression<Func<PropertyHeight, bool>>>(), null)).ReturnsAsync(existingPropertyHeight);

			// Act
			var result = await _propertyHeightService.CreatePropertyHeightAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Property Height already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdatePropertyHeightAsync_WithValidData_ShouldUpdatePropertyHeight()
		{
			// Arrange
			var updateDto = new PropertyHeightUpdateDto
			(
				propertyHeightId: 1,
				propertyHeights: "Updated Height",
				modifiedBy: "testuser"
			);

			var existingPropertyHeight = PropertyHeight.Create(1, "Old Height");
			var propertyHeightDto = new PropertyHeightReadDto(1, "Old Height");

			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(updateDto.propertyHeightId)).ReturnsAsync(existingPropertyHeight);
			_mapperMock.Setup(x => x.Map<PropertyHeightReadDto>(It.IsAny<PropertyHeight>())).Returns(propertyHeightDto);

			// Act
			var result = await _propertyHeightService.UpdatePropertyHeightAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.Update(It.IsAny<PropertyHeight>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdatePropertyHeightAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new PropertyHeightUpdateDto
			(
				propertyHeightId: 999,
				propertyHeights: "Test Height",
				modifiedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(updateDto.propertyHeightId)).ReturnsAsync((PropertyHeight)null!);

			// Act
			var result = await _propertyHeightService.UpdatePropertyHeightAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeletePropertyHeight_WithValidId_ShouldDeletePropertyHeight()
		{
			// Arrange
			int propertyHeightId = 1;
			var existingPropertyHeight = PropertyHeight.Create(propertyHeightId, "Test Height");
			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(propertyHeightId)).ReturnsAsync(existingPropertyHeight);

			// Act
			var result = await _propertyHeightService.DeletePropertyHeight(propertyHeightId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.PropertyHeight.Delete(It.IsAny<PropertyHeight>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeletePropertyHeight_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int propertyHeightId = 999;
			_unitOfWorkMock.Setup(x => x.PropertyHeight.Get(propertyHeightId)).ReturnsAsync((PropertyHeight)null!);

			// Act
			var result = await _propertyHeightService.DeletePropertyHeight(propertyHeightId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

