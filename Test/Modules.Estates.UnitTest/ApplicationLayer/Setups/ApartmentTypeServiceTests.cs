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
using Modules.Estates.Domain.Entities.Setup;
using static System.Net.Mime.MediaTypeNames;

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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
			var apartmentTypes = new List<ApartmentTypes>
			{
				new ApartmentTypes(1, 1, "STUDIO", 8000, 2, 21.2, images)
			};

			var currencyExchangeRates = new List<CurrencyExchangeRate>
			{
				new CurrencyExchangeRate(2, "USD", "U.S. DOLLAR", 12.15m, 12.36m, false, DateTime.Now)
			};

			var expectedDtos = new List<ApartmentTypesReadDto>
			{
				new ApartmentTypesReadDto(1, "STUDIO", 8000, 2, "USD","U.S. DOLLAR", 21.2, images)
			};

			_unitOfWorkMock.Setup(x => x.ApartmentTypes.GetAll()).ReturnsAsync(apartmentTypes);
			_unitOfWorkMock.Setup(x => x.CurrencyExchangeRate.GetAll()).ReturnsAsync(currencyExchangeRates);
			_mapperMock.Setup(x => x.Map<IEnumerable<ApartmentTypesReadDto>>(It.IsAny<IEnumerable<ApartmentTypesReadDto>>()))
				.Returns(expectedDtos);

			// Act
			var result = await _apartmentTypeService.GetApartmentTypeAsync();

			// Assert
			Assert.Equal(expectedDtos, result);
			_unitOfWorkMock.Verify(x => x.ApartmentTypes.GetAll(), Times.Once);
			_unitOfWorkMock.Verify(x => x.CurrencyExchangeRate.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetApartmentTypeAsync_WithValidId_ShouldReturnApartmentType()
		{
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };

			// Arrange
			int apartmentTypeId = 1;
			var apartmentType = new ApartmentTypes(1, 1, "STUDIO", 8000, 2, 21.2, images);
			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 1, "STUDIO", 8000, 2, 21.2, images);
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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };

			// Arrange
			string value = "test";
			var apartmentType = new ApartmentTypes(1, 1, "STUDIO", 8000, 2, 21.2, images);
			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 1, "STUDIO", 8000, 2, 21.2, images);
			_unitOfWorkMock.Setup(x => x.ApartmentTypes.Get(It.IsAny<Expression<Func<ApartmentTypes, bool>>>(), null)).ReturnsAsync(apartmentType);

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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
			// Arrange
			var createDto = new ApartmentTypeCreateDto
			(
				1,
				apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100.25,
				images: images,
				createdBy: "testuser"
			);

			var apartmentTypeDto = new ApartmentTypeReadDto("AFFORDABLE", 0, createDto.apartmentType!, createDto.sellingPrice, 2, createDto.floorArea, images);

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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
			// Arrange
			var createDto = new ApartmentTypeCreateDto
			(
				1,
				apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100,
				images: images,
				createdBy: "testuser"
			);

			var existingApartmentType = ApartmentTypes.Create(1, 2, "Test Apartment", 200000, 1, 200, images);
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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
			// Arrange
			var updateDto = new ApartmentTypeUpdateDto
			(
				1,
				apartmentTypeId: 1,
				apartmentType: "Updated Apartment",
				sellingPrice: 150000,
				currencyId: 1,
				floorArea: 150,
				images: images,
				modifiedBy: "testuser"
			);

			var existingApartmentType = ApartmentTypes.Create(1, 1, "Old Apartment", 100000, 1, 100, images);
			var apartmentTypeDto = new ApartmentTypeReadDto(apartmentCategory: "AFFORDABLE", 1, "Updated Apartment", 150000, 2, 150, images);

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
			string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
			// Arrange
			var updateDto = new ApartmentTypeUpdateDto
			(
				1,
				apartmentTypeId: 999,
				apartmentType: "Test Apartment",
				sellingPrice: 100000,
				currencyId: 1,
				floorArea: 100,
				images: images,
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
            string[] images = { "https://images.com", "https://images1.com", "https://images2.com", "https://images3.com", "https://images4.com" };
            // Arrange
            int apartmentTypeId = 1;
			var existingApartmentType = ApartmentTypes.Create(1, apartmentTypeId, "Test Apartment", 100000, 1, 100, images);
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

