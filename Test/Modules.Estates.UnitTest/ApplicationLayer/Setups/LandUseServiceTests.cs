// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/LandUseServiceTests.cs
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
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.UseCases.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain;
using System.Linq.Expressions;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class LandUseServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly LandUseService _landUseService;

		public LandUseServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_landUseService = new LandUseService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetLandUseAsync_ShouldReturnAllLandUses()
		{
			// Arrange
			var landUses = new List<LandUse>();
			var landUseDtos = new List<LandUseReadDto>();
			_unitOfWorkMock.Setup(x => x.LandUse.GetAll()).ReturnsAsync(landUses);
			_mapperMock.Setup(x => x.Map<IEnumerable<LandUseReadDto>>(landUses)).Returns(landUseDtos);

			// Act
			var result = await _landUseService.GetLandUseAsync();

			// Assert
			Assert.Equal(landUseDtos, result);
			_unitOfWorkMock.Verify(x => x.LandUse.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetLandUseAsync_WithValidId_ShouldReturnLandUse()
		{
			// Arrange
			int landUseId = 1;
			var landUse = new LandUse(1, "CPL", "COMMERCIAL");
			var landUseDto = new LandUseReadDto(1, "CPL", "COMMERCIAL");
			_unitOfWorkMock.Setup(x => x.LandUse.Get(landUseId)).ReturnsAsync(landUse);
			_mapperMock.Setup(x => x.Map<LandUseReadDto>(landUse)).Returns(landUseDto);

			// Act
			var result = await _landUseService.GetLandUseAsync(landUseId);

			// Assert
			Assert.Equal(landUseDto, result);
			_unitOfWorkMock.Verify(x => x.LandUse.Get(landUseId), Times.Once);
		}

		[Fact]
		public async Task GetLandUseAsync_WithValidString_ShouldReturnLandUse()
		{
			// Arrange
			string value = "test";
			var landUse = new LandUse(1, "CPL", "COMMERCIAL");
			var landUseDto = new LandUseReadDto(1, "CPL", "COMMERCIAL");
			_unitOfWorkMock.Setup(x => x.LandUse.Get(It.IsAny<Expression<Func<LandUse, bool>>>(), null)).ReturnsAsync(landUse);
			_mapperMock.Setup(x => x.Map<LandUseReadDto>(landUse)).Returns(landUseDto);

			// Act
			var result = await _landUseService.GetLandUseAsync(value);

			// Assert
			Assert.Equal(landUseDto, result);
			_unitOfWorkMock.Verify(x => x.LandUse.Get(It.IsAny<Expression<Func<LandUse, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateLandUseAsync_WithValidData_ShouldCreateLandUse()
		{
			// Arrange
			var createDto = new LandUseCreateDto
			(
				LandUseInitial : "TEST",
				LandUseName : "Test Land Use",
				CreatedBy : "testuser"
			);

			var landUse = LandUse.Create(0, createDto.LandUseInitial!, createDto.LandUseName!);
			var landUseDto = new LandUseReadDto(0, createDto.LandUseInitial!, createDto.LandUseName!);

			_unitOfWorkMock.Setup(x => x.LandUse.Get(It.IsAny<Expression<Func<LandUse, bool>>>(),null)).ReturnsAsync((LandUse)null!);
			_mapperMock.Setup(x => x.Map<LandUseReadDto>(It.IsAny<LandUse>())).Returns(landUseDto);

			// Act
			var result = await _landUseService.CreateLandUseAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUse.Insert(It.IsAny<LandUse>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateLandUseAsync_WithExistingInitial_ShouldReturnError()
		{
			// Arrange
			var createDto = new LandUseCreateDto
			(
				LandUseInitial : "TEST",
				LandUseName : "Test Land Use",
				CreatedBy : "testuser"
            );

			var existingLandUse = LandUse.Create(2, "TEST", "Existing Land Use");
			_unitOfWorkMock.Setup(x => x.LandUse.Get(It.IsAny<Expression<Func<LandUse, bool>>>(),null)).ReturnsAsync(existingLandUse);

			// Act
			var result = await _landUseService.CreateLandUseAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Land Use Initial already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateLandUseAsync_WithValidData_ShouldUpdateLandUse()
		{
			// Arrange
			var updateDto = new LandUseUpdateDto
			(
				LandUseId : 1,
				LandUseInitial : "TEST",
				LandUseName : "Updated Land Use",
				ModifiedBy : "testuser"
			);

			var existingLandUse = LandUse.Create(1, "OLD", "Old Land Use");
			var landUseDto = new LandUseReadDto(1, "OLD", "Old Land Use");

			_unitOfWorkMock.Setup(x => x.LandUse.Get(updateDto.LandUseId)).ReturnsAsync(existingLandUse);
			_mapperMock.Setup(x => x.Map<LandUseReadDto>(It.IsAny<LandUse>())).Returns(landUseDto);

			// Act
			var result = await _landUseService.UpdateLandUseAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUse.Update(It.IsAny<LandUse>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateLandUseAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new LandUseUpdateDto
			(
				LandUseId : 999,
				LandUseInitial : "TEST",
				LandUseName : "Test Land Use",
				ModifiedBy : "testuser"
			);

			_unitOfWorkMock.Setup(x => x.LandUse.Get(updateDto.LandUseId)).ReturnsAsync((LandUse)null!);

			// Act
			var result = await _landUseService.UpdateLandUseAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteLandUse_WithValidId_ShouldDeleteLandUse()
		{
			// Arrange
			int landUseId = 1;
			var existingLandUse = LandUse.Create(landUseId, "TEST", "Test Land Use");
			_unitOfWorkMock.Setup(x => x.LandUse.Get(landUseId)).ReturnsAsync(existingLandUse);

			// Act
			var result = await _landUseService.DeleteLandUse(landUseId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.LandUse.Delete(It.IsAny<LandUse>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteLandUse_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int landUseId = 999;
			_unitOfWorkMock.Setup(x => x.LandUse.Get(landUseId)).ReturnsAsync((LandUse)null!);

			// Act
			var result = await _landUseService.DeleteLandUse(landUseId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

