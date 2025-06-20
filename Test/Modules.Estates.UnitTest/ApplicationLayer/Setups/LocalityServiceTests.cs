// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/LocalityServiceTests.cs
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
	public class LocalityServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly LocalityService _localityService;

		public LocalityServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_localityService = new LocalityService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetLocalityAsync_ShouldReturnAllLocalities()
		{
			// Arrange
			var localities = new List<Locality>();
			var localityDtos = new List<LocalityReadDto>();
			_unitOfWorkMock.Setup(x => x.Locality.GetAll()).ReturnsAsync(localities);
			_mapperMock.Setup(x => x.Map<IEnumerable<LocalityReadDto>>(localities)).Returns(localityDtos);

			// Act
			var result = await _localityService.GetLocalityAsync();

			// Assert
			Assert.Equal(localityDtos, result);
			_unitOfWorkMock.Verify(x => x.Locality.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetLocalityAsync_WithValidId_ShouldReturnLocality()
		{
			// Arrange
			int localityId = 1;
			var locality = new Locality(localityId,"TCM","TEST COMMUNITY NAME","999",150);
			var localityDto = new LocalityReadDto(localityId, "TCM", "TEST COMMUNITY NAME", "999", 150);
			_unitOfWorkMock.Setup(x => x.Locality.Get(localityId)).ReturnsAsync(locality);
			_mapperMock.Setup(x => x.Map<LocalityReadDto>(locality)).Returns(localityDto);

			// Act
			var result = await _localityService.GetLocalityAsync(localityId);

			// Assert
			Assert.Equal(localityDto, result);
			_unitOfWorkMock.Verify(x => x.Locality.Get(localityId), Times.Once);
		}

		[Fact]
		public async Task GetLocalityAsync_WithValidString_ShouldReturnLocality()
		{
			// Arrange
			string value = "test";
			var locality = new Locality(0, "TCM", "TEST COMMUNITY NAME", "999", 150);
			var localityDto = new LocalityReadDto(0, "TCM", "TEST COMMUNITY NAME", "999", 150);
			_unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null)).ReturnsAsync(locality);
			_mapperMock.Setup(x => x.Map<LocalityReadDto>(locality)).Returns(localityDto);

			// Act
			var result = await _localityService.GetLocalityAsync(value);

			// Assert
			Assert.Equal(localityDto, result);
			_unitOfWorkMock.Verify(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(),null), Times.Once);
		}

		[Fact]
		public async Task CreateLocalityAsync_WithValidData_ShouldCreateLocality()
		{
			// Arrange
			var createDto = new LocalityCreateDto
			(
				LocalityInitial : "TEST",
				LocalityName : "Test Locality",
				CustomerCode : "C001",
				CustomerCodeCounter : 1,
				CreatedBy : "testuser"
			);

			var locality = Locality.Create(0, createDto.LocalityInitial!, createDto.LocalityName!, createDto.CustomerCode, createDto.CustomerCodeCounter);
			var localityDto = new LocalityReadDto(0, createDto.LocalityInitial!, createDto.LocalityName!, createDto.CustomerCode, createDto.CustomerCodeCounter);

			_unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null)).ReturnsAsync((Locality)null!);
			_mapperMock.Setup(x => x.Map<LocalityReadDto>(It.IsAny<Locality>())).Returns(localityDto);

			// Act
			var result = await _localityService.CreateLocalityAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Locality.Insert(It.IsAny<Locality>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateLocalityAsync_WithExistingLocality_ShouldReturnError()
		{
			// Arrange
			var createDto = new LocalityCreateDto
			(
				LocalityInitial : "TEST",
				LocalityName : "Test Locality",
				CustomerCode : "C001",
				CustomerCodeCounter : 1,
				CreatedBy : "testuser"
			);

			var existingLocality = Locality.Create(2, "TEST", "Existing Locality", "C002", 2);
			_unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null)).ReturnsAsync(existingLocality);

			// Act
			var result = await _localityService.CreateLocalityAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Locality already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateLocalityAsync_WithValidData_ShouldUpdateLocality()
		{
			// Arrange
			var updateDto = new LocalityUpdateDto
			(
				LocalityId : 1,
				LocalityInitial : "TEST",
				LocalityName : "Updated Locality",
				CustomerCode : "C001",
				CustomerCodeCounter : 2,
				ModifiedBy : "testuser"
			);

			var existingLocality = Locality.Create(1, "OLD", "Old Locality", "C000", 1);
			var localityDto = new LocalityReadDto(1, "OLD", "Old Locality", "C000", 1);

			_unitOfWorkMock.Setup(x => x.Locality.Get(updateDto.LocalityId)).ReturnsAsync(existingLocality);
			_mapperMock.Setup(x => x.Map<LocalityReadDto>(It.IsAny<Locality>())).Returns(localityDto);

			// Act
			var result = await _localityService.UpdateLocalityAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Locality.Update(It.IsAny<Locality>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateLocalityAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new LocalityUpdateDto
			(
				LocalityId : 999,
				LocalityInitial : "TEST",
				LocalityName : "Test Locality",
				CustomerCode : "C001",
				CustomerCodeCounter : 1,
				ModifiedBy : "testuser"
            );

			_unitOfWorkMock.Setup(x => x.Locality.Get(updateDto.LocalityId)).ReturnsAsync((Locality)null!);

			// Act
			var result = await _localityService.UpdateLocalityAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteLocality_WithValidId_ShouldDeleteLocality()
		{
			// Arrange
			int localityId = 1;
			var existingLocality = Locality.Create(localityId, "TEST", "Test Locality", "C001", 1);
			_unitOfWorkMock.Setup(x => x.Locality.Get(localityId)).ReturnsAsync(existingLocality);

			// Act
			var result = await _localityService.DeleteLocality(localityId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Locality.Delete(It.IsAny<Locality>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteLocality_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int localityId = 999;
			_unitOfWorkMock.Setup(x => x.Locality.Get(localityId)).ReturnsAsync((Locality)null!);

			// Act
			var result = await _localityService.DeleteLocality(localityId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

