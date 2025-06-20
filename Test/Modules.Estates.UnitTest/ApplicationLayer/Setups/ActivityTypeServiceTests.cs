// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/ActivityTypeServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:18 PM
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
using Modules.Estates.Application.Interfaces.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
	public class ActivityTypeServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly ActivityTypeService _activityTypeService;

		public ActivityTypeServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_activityTypeService = new ActivityTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetActivityTypeAsync_ShouldReturnAllActivityTypes()
		{
			// Arrange
			var activityTypes = new List<ActivityType>();
			var activityTypeDtos = new List<ActivityTypeReadDto>();
			_unitOfWorkMock.Setup(x => x.ActivityType.GetAll()).ReturnsAsync(activityTypes);
			_mapperMock.Setup(x => x.Map<IEnumerable<ActivityTypeReadDto>>(activityTypes)).Returns(activityTypeDtos);

			// Act
			var result = await _activityTypeService.GetActivityTypeAsync();

			// Assert
			Assert.Equal(activityTypeDtos, result);
			_unitOfWorkMock.Verify(x => x.ActivityType.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetActivityTypeAsync_WithValidId_ShouldReturnActivityType()
		{
			// Arrange
			int activityTypeId = 1;
			var activityType = new ActivityType(activityTypeId, 1, "ACT", "ACTIVITY TYPE");
			var activityTypeDto = new ActivityTypeReadDto(activityTypeId, 1, "ACT", "ACTIVITY TYPE");
			_unitOfWorkMock.Setup(x => x.ActivityType.Get(activityTypeId)).ReturnsAsync(activityType);
			_mapperMock.Setup(x => x.Map<ActivityTypeReadDto>(activityType)).Returns(activityTypeDto);

			// Act
			var result = await _activityTypeService.GetActivityTypeAsync(activityTypeId);

			// Assert
			Assert.Equal(activityTypeDto, result);
			_unitOfWorkMock.Verify(x => x.ActivityType.Get(activityTypeId), Times.Once);
		}

		[Fact]
		public async Task GetActivityTypeAsync_WithValidString_ShouldReturnActivityType()
		{
			// Arrange
			string value = "test";
			var activityType = new ActivityType(1, 1, "ACT", "ACTIVITY TYPE");
			var activityTypeDto = new ActivityTypeReadDto(1, 1, "ACT", "ACTIVITY TYPE");
			_unitOfWorkMock.Setup(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null)).ReturnsAsync(activityType);
			_mapperMock.Setup(x => x.Map<ActivityTypeReadDto>(activityType)).Returns(activityTypeDto);

			// Act
			var result = await _activityTypeService.GetActivityTypeAsync(value);

			// Assert
			Assert.Equal(activityTypeDto, result);
			_unitOfWorkMock.Verify(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateActivityTypeAsync_WithValidData_ShouldCreateActivityType()
		{
			// Arrange
			var createDto = new ActivityTypeCreateDto
			(
				ActivityId: 2,
				ActivityTypeName: "TEST",
				ActivityTypeDescription: "Test Activity Type",
				CreatedBy: "testuser"
			);

			var activityType = ActivityType.Create(createDto.ActivityId, 0, createDto.ActivityTypeName!, createDto.ActivityTypeDescription!);
			var activityTypeDto = new ActivityTypeReadDto(createDto.ActivityId, 0, createDto.ActivityTypeName!, createDto.ActivityTypeDescription!);

			_unitOfWorkMock.Setup(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null)).ReturnsAsync((ActivityType)null!);
			_mapperMock.Setup(x => x.Map<ActivityTypeReadDto>(It.IsAny<ActivityType>())).Returns(activityTypeDto);

			// Act
			var result = await _activityTypeService.CreateActivityTypeAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ActivityType.Insert(It.IsAny<ActivityType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateActivityTypeAsync_WithExistingInitial_ShouldReturnError()
		{
			// Arrange
			var createDto = new ActivityTypeCreateDto
			(
				ActivityId: 1,
				ActivityTypeName: "Test Activity Type",
				ActivityTypeDescription: "Testing Activities",
				CreatedBy: "testuser"
			);

			var existingActivityType = ActivityType.Create(1, 2, "Test Activity Type", "Testing Activities");
			_unitOfWorkMock.Setup(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null)).ReturnsAsync(existingActivityType);

			// Act
			var result = await _activityTypeService.CreateActivityTypeAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Activity Type Name already exists.", result.ErrorResponse.Message);
		}

        [Fact]
        public async Task CreateActivityTypeAsync_WithActivityTypeLong_ShouldReturnError()
        {
            // Arrange
            // Assuming a max length of 55 for Activity Type for this test example
            string _activityTypeName = new string('A', 55);
            var createDto = new ActivityTypeCreateDto
            (
                ActivityId: 1,
                ActivityTypeName: _activityTypeName,
                ActivityTypeDescription: "Testing Activities",
                CreatedBy: "testuser"
            );

            _unitOfWorkMock.Setup(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null))
                           .ReturnsAsync((ActivityType)null!); // Ensure it's not an "already exists" error

            // Act
            var result = await _activityTypeService.CreateActivityTypeAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.ErrorResponse);
            Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
            Assert.False(string.IsNullOrEmpty(result.ErrorResponse.Message), "Activity Type cannot be empty or exceed 50 characters.");

            _unitOfWorkMock.Verify(x => x.ActivityType.Insert(It.IsAny<ActivityType>()), Times.Never);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
        }

        [Fact]
        public async Task CreateActivityTypeAsync_WithActivityTypeDescriptionLong_ShouldReturnError()
        {
            // Arrange
            // Assuming a max length of 255 for Activity Type Decription for this test example
            string _activityTypeDescription = new string('A', 255);
            var createDto = new ActivityTypeCreateDto
            (
                ActivityId: 1,
                ActivityTypeName: "Testing Activities",
                ActivityTypeDescription: _activityTypeDescription, 
                CreatedBy: "testuser"
            );

            _unitOfWorkMock.Setup(x => x.ActivityType.Get(It.IsAny<Expression<Func<ActivityType, bool>>>(), null))
                           .ReturnsAsync((ActivityType)null!); // Ensure it's not an "already exists" error

            // Act
            var result = await _activityTypeService.CreateActivityTypeAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.NotNull(result.ErrorResponse);
            Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
            Assert.False(string.IsNullOrEmpty(result.ErrorResponse.Message), "Activity Type Description cannot be empty or exceed 250 characters.");

            _unitOfWorkMock.Verify(x => x.ActivityType.Insert(It.IsAny<ActivityType>()), Times.Never);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
        }


        [Fact]
		public async Task UpdateActivityTypeAsync_WithValidData_ShouldUpdateActivityType()
		{
			// Arrange
			var updateDto = new ActivityTypeUpdateDto
			(
				ActivityId: 1,
				ActivityTypeId: 2,
				ActivityTypeName: "Updated Activity Type",
				ActivityTypeDescription: "Updated Activity Type Description",
				ModifiedBy: "testuser"
			);

			var existingActivityType = ActivityType.Create(1, 2, "Old Activity Type", "Old Activity Type Description");
			var activityTypeDto = new ActivityTypeReadDto(1, 2, "Old Activity Type", "Old Activity Type Description");

			_unitOfWorkMock.Setup(x => x.ActivityType.Get(updateDto.ActivityTypeId)).ReturnsAsync(existingActivityType);
			_mapperMock.Setup(x => x.Map<ActivityTypeReadDto>(It.IsAny<ActivityType>())).Returns(activityTypeDto);

			// Act
			var result = await _activityTypeService.UpdateActivityTypeAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ActivityType.Update(It.IsAny<ActivityType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateActivityTypeAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new ActivityTypeUpdateDto
			(
				ActivityId: 1,
				ActivityTypeId: 999,
				ActivityTypeName: "Test Activity Type",
				ActivityTypeDescription: "Testing Activities",
				ModifiedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.ActivityType.Get(updateDto.ActivityTypeId)).ReturnsAsync((ActivityType)null!);

			// Act
			var result = await _activityTypeService.UpdateActivityTypeAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteActivityType_WithValidId_ShouldDeleteActivityType()
		{
			// Arrange
			int activityTypeId = 1;
			var existingActivityType = ActivityType.Create(activityTypeId, activityTypeId, "Test Activity Type", "Testing Activities");
			_unitOfWorkMock.Setup(x => x.ActivityType.Get(activityTypeId)).ReturnsAsync(existingActivityType);

			// Act
			var result = await _activityTypeService.DeleteActivityType(activityTypeId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.ActivityType.Delete(It.IsAny<ActivityType>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteActivityType_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int activityTypeId = 999;
			_unitOfWorkMock.Setup(x => x.ActivityType.Get(activityTypeId)).ReturnsAsync((ActivityType)null!);

			// Act
			var result = await _activityTypeService.DeleteActivityType(activityTypeId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

