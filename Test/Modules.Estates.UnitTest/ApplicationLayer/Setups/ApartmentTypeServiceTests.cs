// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/ApartmentTypeServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:28 PM
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
using Modules.Estates.Domain.Entities.Setup.Customer;
using System.Linq.Expressions;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class ApartmentTypeServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly ApartmentTypeService _apartmentTypeService;

		public ApartmentTypeServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_apartmentTypeService = new ApartmentTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetApartmentTypeAsync_ShouldReturnAllApartmentTypes()
		{
			// Arrange
			var apartmentTypes = new List<ApartmentTypes>();
			var apartmentTypeDtos = new List<ApartmentTypeReadDto>();
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.GetAll()).ReturnsAsync(apartmentTypes);
			_mapperMock.Setup(x => x.Map<IEnumerable<ApartmentTypeReadDto>>(apartmentTypes)).Returns(apartmentTypeDtos);

			// Act
			var result = await _apartmentTypeService.GetApartmentTypeAsync();

			// Assert
			Assert.Equal(apartmentTypeDtos, result);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetApartmentTypeAsync_WithValidId_ShouldReturnApartmentType()
		{
			// Arrange
			int apartmentTypeId = 1;
			var apartmentType = new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE ,1, "STUDIO", 8000, 2, 21.2);
			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 1, "STUDIO", 8000, "USD", 21.2);
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(apartmentTypeId)).ReturnsAsync(apartmentType);
			_mapperMock.Setup(x => x.Map<ApartmentTypeReadDto>(apartmentType)).Returns(apartmentTypeDto);

			// Act
			var result = await _apartmentTypeService.GetApartmentTypeAsync(apartmentTypeId);

			// Assert
			Assert.Equal(apartmentTypeDto, result);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.Get(apartmentTypeId), Times.Once);
		}

		[Fact]
		public async Task GetApartmentTypeAsync_WithValidString_ShouldReturnApartmentType()
		{
			// Arrange
			string value = "test";
			var apartmentType = new ApartmentTypes(ApartmentCategoryEnum.AFFORDABLE, 1, "STUDIO", 8000, 2, 21.2);
			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 1, "STUDIO", 8000, "USD", 21.2);
            _unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(It.IsAny< Expression<Func<ApartmentTypes, bool>>>(), null)).ReturnsAsync(apartmentType);

            _mapperMock.Setup(x => x.Map<ApartmentTypeReadDto>(apartmentType)).Returns(apartmentTypeDto);

			// Act
			var result = await _apartmentTypeService.GetApartmentTypeAsync(value);

			// Assert
			Assert.Equal(apartmentTypeDto, result);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.Get(It.IsAny<Expression<Func<ApartmentTypes, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateApartmentTypeAsync_WithValidData_ShouldCreateApartmentType()
		{
			// Arrange
			var createDto = new ApartmentTypeCreateDto
			(
				apartmentCategory: ApartmentCategoryEnum.AFFORDABLE,
				apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100.25,
				createdBy: "testuser"
			);

			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 0, createDto.apartmentType!, createDto.sellingPrice, "USD", createDto.floorArea);

			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(It.IsAny<Expression<Func<ApartmentTypes, bool>>>(), null)).ReturnsAsync((ApartmentTypes)null!);
			_mapperMock.Setup(x => x.Map<ApartmentTypeReadDto>(It.IsAny<ApartmentTypes>())).Returns(apartmentTypeDto);

			// Act
			var result = await _apartmentTypeService.CreateApartmentTypeAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.Insert(It.IsAny<ApartmentTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateApartmentTypeAsync_WithExistingType_ShouldReturnError()
		{
			// Arrange
			var createDto = new ApartmentTypeCreateDto
			(
                apartmentCategory: ApartmentCategoryEnum.AFFORDABLE,
                apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100,
				createdBy: "testuser"
			);

			var existingApartmentType = ApartmentTypes.Create(createDto.apartmentCategory, 2, "Test Apartment", 200000, 1, 200);
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(It.IsAny<Expression<Func<ApartmentTypes, bool>>>(), null)).ReturnsAsync(existingApartmentType);

			// Act
			var result = await _apartmentTypeService.CreateApartmentTypeAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Apartment Type already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateApartmentTypeAsync_WithValidData_ShouldUpdateApartmentType()
		{
			// Arrange
			var updateDto = new ApartmentTypeUpdateDto
			(
                apartmentCategory: ApartmentCategoryEnum.AFFORDABLE,
                apartmentTypeId: 1,
				apartmentType: "Updated Apartment",
				sellingPrice: 150000,
				currencyId: 1,
				floorArea: 150,
				modifiedBy: "testuser"
			);

			var existingApartmentType = ApartmentTypes.Create(apartmentCategory: ApartmentCategoryEnum.AFFORDABLE, 1, "Old Apartment", 100000, 1, 100);
			var apartmentTypeDto = new ApartmentTypeReadDto(apartmentCategory: "AFFORDABLE", 1, "Updated Apartment", 150000, "USD", 150);

			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(updateDto.apartmentTypeId)).ReturnsAsync(existingApartmentType);
			_mapperMock.Setup(x => x.Map<ApartmentTypeReadDto>(It.IsAny<ApartmentTypes>())).Returns(apartmentTypeDto);

			// Act
			var result = await _apartmentTypeService.UpdateApartmentTypeAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.Update(It.IsAny<ApartmentTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateApartmentTypeAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new ApartmentTypeUpdateDto
			(
				apartmentCategory: ApartmentCategoryEnum.AFFORDABLE,
				apartmentTypeId: 999,
				apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100,
				modifiedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(updateDto.apartmentTypeId)).ReturnsAsync((ApartmentTypes)null!);

			// Act
			var result = await _apartmentTypeService.UpdateApartmentTypeAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteApartmentType_WithValidId_ShouldDeleteApartmentType()
		{
			// Arrange
			int apartmentTypeId = 1;
			var existingApartmentType = ApartmentTypes.Create(apartmentCategory: ApartmentCategoryEnum.AFFORDABLE, apartmentTypeId, "Test Apartment", 100000, 1, 100);
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(apartmentTypeId)).ReturnsAsync(existingApartmentType);

			// Act
			var result = await _apartmentTypeService.DeleteApartmentType(apartmentTypeId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.Delete(It.IsAny<ApartmentTypes>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteApartmentType_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int apartmentTypeId = 999;
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(apartmentTypeId)).ReturnsAsync((ApartmentTypes)null!);

			// Act
			var result = await _apartmentTypeService.DeleteApartmentType(apartmentTypeId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

