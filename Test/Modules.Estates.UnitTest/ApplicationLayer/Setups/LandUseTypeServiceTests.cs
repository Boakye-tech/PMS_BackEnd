// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/LandUseTypeServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:16 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using AutoMapper;
using Microsoft.AspNetCore.Http;
using Moq;
using Modules.Estates.Application.UseCases.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain;
using Modules.Estates.Application.DTO.Setup.Property;
using System.Linq.Expressions;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class LandUseTypeServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly LandUseTypeService _landUseTypeService;

		public LandUseTypeServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_landUseTypeService = new LandUseTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetLandUseTypeAsync_ShouldReturnAllLandUseTypes()
		{
			// Arrange
			var landUseTypes = new List<LandUseType>();
			var landUseTypeDtos = new List<LandUseTypeReadDto>();
			_unitOfWorkMock.Setup(x => x.LandUseType.GetAll()).ReturnsAsync(landUseTypes);
			_mapperMock.Setup(x => x.Map<IEnumerable<LandUseTypeReadDto>>(landUseTypes)).Returns(landUseTypeDtos);

			// Act
			var result = await _landUseTypeService.GetLandUseTypeAsync();

			// Assert
			Assert.Equal(landUseTypeDtos, result);
			_unitOfWorkMock.Verify(x => x.LandUseType.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetLandUseTypeAsync_WithValidId_ShouldReturnLandUseType()
		{
			// Arrange
			int landUseTypeId = 1;
			var landUseType = new LandUseType(1,2,"SHP","SHOPS","");
			var landUseTypeDto = new LandUseTypeReadDto(1, 2, "SHP", "SHOPS", "");
			_unitOfWorkMock.Setup(x => x.LandUseType.Get(landUseTypeId)).ReturnsAsync(landUseType);
			_mapperMock.Setup(x => x.Map<LandUseTypeReadDto>(landUseType)).Returns(landUseTypeDto);

			// Act
			var result = await _landUseTypeService.GetLandUseTypeAsync(landUseTypeId);

			// Assert
			Assert.Equal(landUseTypeDto, result);
			_unitOfWorkMock.Verify(x => x.LandUseType.Get(landUseTypeId), Times.Once);
		}

		[Fact]
		public async Task GetLandUseTypeAsync_WithValidString_ShouldReturnLandUseType()
		{
			// Arrange
			string value = "test";
			var landUseType = new LandUseType(1, 2, "SHP", "SHOPS", "");
			var landUseTypeDto = new LandUseTypeReadDto(1, 2, "SHP", "SHOPS", "");
			_unitOfWorkMock.Setup(x => x.LandUseType.Get(It.IsAny<Expression<Func<LandUseType, bool>>>(), null)).ReturnsAsync(landUseType);
			_mapperMock.Setup(x => x.Map<LandUseTypeReadDto>(landUseType)).Returns(landUseTypeDto);

			// Act
			var result = await _landUseTypeService.GetLandUseTypeAsync(value);

			// Assert
			Assert.Equal(landUseTypeDto, result);
			_unitOfWorkMock.Verify(x => x.LandUseType.Get(It.IsAny<Expression<Func<LandUseType, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateLandUseTypeAsync_WithValidData_ShouldCreateLandUseType()
		{
			// Arrange
			var createDto = new LandUseTypeCreateDto
			(
				LandUseId : 1,
				LandUseTypeInitial : "TEST",
				LandUseTypeName : "Test Land Use Type",
				LandUseTypeDescription : "Test land use type description",
				CreatedBy : "testuser"
			);

			var landUseType = LandUseType.Create(createDto.LandUseId, 0, createDto.LandUseTypeInitial!, createDto.LandUseTypeName!,"");
			var landUseTypeDto = new LandUseTypeReadDto(createDto.LandUseId, 1, createDto.LandUseTypeInitial!, createDto.LandUseTypeName!, createDto.LandUseTypeDescription);

			_unitOfWorkMock.Setup(x => x.LandUseType.Get(It.IsAny<Expression<Func<LandUseType, bool>>>(), null)).ReturnsAsync((LandUseType)null!);
			_mapperMock.Setup(x => x.Map<LandUseTypeReadDto>(It.IsAny<LandUseType>())).Returns(landUseTypeDto);

			// Act
			var result = await _landUseTypeService.CreateLandUseTypeAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUseType.Insert(It.IsAny<LandUseType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateLandUseTypeAsync_WithExistingInitial_ShouldReturnError()
		{
			// Arrange
			var createDto = new LandUseTypeCreateDto
			(
                LandUseId: 1,
				LandUseTypeInitial : "TEST",
				LandUseTypeName: "Test Land Use Type",
                LandUseTypeDescription: "Test land use type description",
                CreatedBy : "testuser"
			);

			var existingLandUseType = LandUseType.Create(2, 2, "TEST", "Existing Land Use Type","");
			_unitOfWorkMock.Setup(x => x.LandUseType.Get(It.IsAny<Expression<Func<LandUseType, bool>>>(), null)).ReturnsAsync(existingLandUseType);

			// Act
			var result = await _landUseTypeService.CreateLandUseTypeAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Land Use Type Initial already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateLandUseTypeAsync_WithValidData_ShouldUpdateLandUseType()
		{
			// Arrange
			var updateDto = new LandUseTypeUpdateDto
			(
				LandUseId : 1,
				LandUseTypeId : 2,
				LandUseTypeInitial : "TEST",
				LandUseTypeName : "Updated Land Use Type",
                LandUseTypeDescription: "Update Test land use type description",
                ModifiedBy : "testuser"
			);

			var existingLandUseType = LandUseType.Create(1, 2, "OLD", "Old Land Use Type","");
			var landUseTypeDto = new LandUseTypeReadDto(1, 2, "OLD", "Old Land Use Type","");

			_unitOfWorkMock.Setup(x => x.LandUseType.Get(updateDto.LandUseTypeId)).ReturnsAsync(existingLandUseType);
			_mapperMock.Setup(x => x.Map<LandUseTypeReadDto>(It.IsAny<LandUseType>())).Returns(landUseTypeDto);

			// Act
			var result = await _landUseTypeService.UpdateLandUseTypeAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUseType.Update(It.IsAny<LandUseType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateLandUseTypeAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new LandUseTypeUpdateDto
			(
				LandUseId : 1,
				LandUseTypeId : 999,
				LandUseTypeInitial : "TEST",
				LandUseTypeName : "Test Land Use Type",
                LandUseTypeDescription: "Test land use type description",
                ModifiedBy : "testuser"
			);

			_unitOfWorkMock.Setup(x => x.LandUseType.Get(updateDto.LandUseTypeId)).ReturnsAsync((LandUseType)null!);

			// Act
			var result = await _landUseTypeService.UpdateLandUseTypeAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteLandUseType_WithValidId_ShouldDeleteLandUseType()
		{
			// Arrange
			int landUseTypeId = 1;
			var existingLandUseType = LandUseType.Create(landUseTypeId, landUseTypeId, "TEST", "Test Land Use Type","");
			_unitOfWorkMock.Setup(x => x.LandUseType.Get(landUseTypeId)).ReturnsAsync(existingLandUseType);

			// Act
			var result = await _landUseTypeService.DeleteLandUseType(landUseTypeId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUseType.Delete(It.IsAny<LandUseType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteLandUseType_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int landUseTypeId = 999;
			_unitOfWorkMock.Setup(x => x.LandUseType.Get(landUseTypeId)).ReturnsAsync((LandUseType)null!);

			// Act
			var result = await _landUseTypeService.DeleteLandUseType(landUseTypeId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

