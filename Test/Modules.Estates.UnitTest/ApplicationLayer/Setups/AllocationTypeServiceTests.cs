// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/AllocationTypeServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:29 PM
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
	public class AllocationTypeServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly AllocationTypeService _allocationTypeService;

		public AllocationTypeServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_allocationTypeService = new AllocationTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetAllocationTypeAsync_ShouldReturnAllAllocationTypes()
		{
			// Arrange
			var allocationTypes = new List<AllocationType>();
			var allocationTypeDtos = new List<AllocationTypeReadDto>();
			_unitOfWorkMock.Setup(x => x.AllocationType.GetAll()).ReturnsAsync(allocationTypes);
			_mapperMock.Setup(x => x.Map<IEnumerable<AllocationTypeReadDto>>(allocationTypes)).Returns(allocationTypeDtos);

			// Act
			var result = await _allocationTypeService.GetAllocationTypeAsync();

			// Assert
			Assert.Equal(allocationTypeDtos, result);
			_unitOfWorkMock.Verify(x => x.AllocationType.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetAllocationTypeAsync_WithValidId_ShouldReturnAllocationType()
		{
			// Arrange
			int allocationTypeId = 1;
			var allocationType = new AllocationType(allocationTypeId,"DTA","DIRECT TRANSFER ALLOCATION");
			var allocationTypeDto = new AllocationTypeReadDto(allocationTypeId, "DTA", "DIRECT TRANSFER ALLOCATION");
			_unitOfWorkMock.Setup(x => x.AllocationType.Get(allocationTypeId)).ReturnsAsync(allocationType);
			_mapperMock.Setup(x => x.Map<AllocationTypeReadDto>(allocationType)).Returns(allocationTypeDto);

			// Act
			var result = await _allocationTypeService.GetAllocationTypeAsync(allocationTypeId);

			// Assert
			Assert.Equal(allocationTypeDto, result);
			_unitOfWorkMock.Verify(x => x.AllocationType.Get(allocationTypeId), Times.Once);
		}

		[Fact]
		public async Task GetAllocationTypeAsync_WithValidString_ShouldReturnAllocationType()
		{
			// Arrange
			string value = "test";
			var allocationType = new AllocationType(1, "DTA", "DIRECT TRANSFER ALLOCATION");
			var allocationTypeDto = new AllocationTypeReadDto(1, "DTA", "DIRECT TRANSFER ALLOCATION");
			_unitOfWorkMock.Setup(x => x.AllocationType.Get(It.IsAny<Expression<Func<AllocationType, bool>>>(), null)).ReturnsAsync(allocationType);
			_mapperMock.Setup(x => x.Map<AllocationTypeReadDto>(allocationType)).Returns(allocationTypeDto);

			// Act
			var result = await _allocationTypeService.GetAllocationTypeAsync(value);

			// Assert
			Assert.Equal(allocationTypeDto, result);
			_unitOfWorkMock.Verify(x => x.AllocationType.Get(It.IsAny<Expression<Func<AllocationType, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateAllocationTypeAsync_WithValidData_ShouldCreateAllocationType()
		{
			// Arrange
			var createDto = new AllocationTypeCreateDto
			(
				AllocationTypeInitial : "TEST",
				AllocationTypes : "Test Allocation Type",
				CreatedBy : "testuser"
            );

			var allocationType = AllocationType.Create(0, createDto.AllocationTypeInitial!, createDto.AllocationTypes!);
			var allocationTypeDto = new AllocationTypeReadDto(0, createDto.AllocationTypeInitial!, createDto.AllocationTypes!);

			_unitOfWorkMock.Setup(x => x.AllocationType.Get(It.IsAny<Expression<Func<AllocationType, bool>>>(), null)).ReturnsAsync((AllocationType)null!);
			_mapperMock.Setup(x => x.Map<AllocationTypeReadDto>(It.IsAny<AllocationType>())).Returns(allocationTypeDto);

			// Act
			var result = await _allocationTypeService.CreateAllocationTypeAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.AllocationType.Insert(It.IsAny<AllocationType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateAllocationTypeAsync_WithExistingInitial_ShouldReturnError()
		{
            // Arrange
            var createDto = new AllocationTypeCreateDto
            (
                AllocationTypeInitial: "TEST",
                AllocationTypes: "Test Allocation Type",
                CreatedBy: "testuser"
            );

            var existingAllocationType = AllocationType.Create(2, "TEST", "Existing Allocation Type");
			_unitOfWorkMock.Setup(x => x.AllocationType.Get(It.IsAny<Expression<Func<AllocationType, bool>>>(),null)).ReturnsAsync(existingAllocationType);

			// Act
			var result = await _allocationTypeService.CreateAllocationTypeAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Allocation Type Initial already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateAllocationTypeAsync_WithValidData_ShouldUpdateAllocationType()
		{
			// Arrange
			var updateDto = new AllocationTypeUpdateDto
			(
				AllocationTypeId : 1,
				AllocationTypeInitial : "TEST",
				AllocationTypes : "Updated Allocation Type",
				ModifiedBy : "testuser"
			);

			var existingAllocationType = AllocationType.Create(1, "OLD", "Old Allocation Type");
			var allocationTypeDto = new AllocationTypeReadDto(1, "OLD", "Old Allocation Type");

			_unitOfWorkMock.Setup(x => x.AllocationType.Get(updateDto.AllocationTypeId)).ReturnsAsync(existingAllocationType);
			_mapperMock.Setup(x => x.Map<AllocationTypeReadDto>(It.IsAny<AllocationType>())).Returns(allocationTypeDto);

			// Act
			var result = await _allocationTypeService.UpdateAllocationTypeAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.AllocationType.Update(It.IsAny<AllocationType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateAllocationTypeAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new AllocationTypeUpdateDto
			(
				AllocationTypeId : 999,
				AllocationTypeInitial : "TEST",
				AllocationTypes : "Test Allocation Type",
				ModifiedBy : "testuser"
			);

			_unitOfWorkMock.Setup(x => x.AllocationType.Get(updateDto.AllocationTypeId)).ReturnsAsync((AllocationType)null!);

			// Act
			var result = await _allocationTypeService.UpdateAllocationTypeAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteAllocationType_WithValidId_ShouldDeleteAllocationType()
		{
			// Arrange
			int allocationTypeId = 1;
			var existingAllocationType = AllocationType.Create(allocationTypeId, "TEST", "Test Allocation Type");
			_unitOfWorkMock.Setup(x => x.AllocationType.Get(allocationTypeId)).ReturnsAsync(existingAllocationType);

			// Act
			var result = await _allocationTypeService.DeleteAllocationType(allocationTypeId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.AllocationType.Delete(It.IsAny<AllocationType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteAllocationType_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int allocationTypeId = 999;
			_unitOfWorkMock.Setup(x => x.AllocationType.Get(allocationTypeId)).ReturnsAsync((AllocationType)null!);

			// Act
			var result = await _allocationTypeService.DeleteAllocationType(allocationTypeId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

