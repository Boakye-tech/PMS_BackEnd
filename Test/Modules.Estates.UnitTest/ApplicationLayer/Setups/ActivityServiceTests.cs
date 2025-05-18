// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/ApplicationLayer/Setups/ActivityServiceTests.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 4:18 PM
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
	public class ActivityServiceTests
	{
		private readonly Mock<IUnitOfWork> _unitOfWorkMock;
		private readonly Mock<IMapper> _mapperMock;
		private readonly ActivityService _activityService;

		public ActivityServiceTests()
		{
			_unitOfWorkMock = new Mock<IUnitOfWork>();
			_mapperMock = new Mock<IMapper>();
			_activityService = new ActivityService(_unitOfWorkMock.Object, _mapperMock.Object);
		}

		[Fact]
		public async Task GetActivityAsync_ShouldReturnAllActivities()
		{
			// Arrange
			var activities = new List<Activity>();
			var activityDtos = new List<ActivityReadDto>();
			_unitOfWorkMock.Setup(x => x.Activity.GetAll()).ReturnsAsync(activities);
			_mapperMock.Setup(x => x.Map<IEnumerable<ActivityReadDto>>(activities)).Returns(activityDtos);

			// Act
			var result = await _activityService.GetActivitiesAsync();

			// Assert
			Assert.Equal(activityDtos, result);
			_unitOfWorkMock.Verify(x => x.Activity.GetAll(), Times.Once);
		}

		[Fact]
		public async Task GetActivityAsync_WithValidId_ShouldReturnActivity()
		{
			// Arrange
			int activityId = 1;
			var activity = new Activity(activityId, "ACT", "ACTIVITY");
			var activityDto = new ActivityReadDto(activityId, "ACT", "ACTIVITY");
			_unitOfWorkMock.Setup(x => x.Activity.Get(activityId)).ReturnsAsync(activity);
			_mapperMock.Setup(x => x.Map<ActivityReadDto>(activity)).Returns(activityDto);

			// Act
			var result = await _activityService.GetActivityAsync(activityId);

			// Assert
			Assert.Equal(activityDto, result);
			_unitOfWorkMock.Verify(x => x.Activity.Get(activityId), Times.Once);
		}

		[Fact]
		public async Task GetActivityAsync_WithValidString_ShouldReturnActivity()
		{
			// Arrange
			string value = "test";
			var activity = new Activity(1, "ACT", "ACTIVITY");
			var activityDto = new ActivityReadDto(1, "ACT", "ACTIVITY");
			_unitOfWorkMock.Setup(x => x.Activity.Get(It.IsAny<Expression<Func<Activity, bool>>>(), null)).ReturnsAsync(activity);
			_mapperMock.Setup(x => x.Map<ActivityReadDto>(activity)).Returns(activityDto);

			// Act
			var result = await _activityService.GetActivityAsync(value);

			// Assert
			Assert.Equal(activityDto, result);
			_unitOfWorkMock.Verify(x => x.Activity.Get(It.IsAny<Expression<Func<Activity, bool>>>(), null), Times.Once);
		}

		[Fact]
		public async Task CreateActivityAsync_WithValidData_ShouldCreateActivity()
		{
			// Arrange
			var createDto = new ActivityCreateDto
			(
				ActivityName: "TEST",
				ActivityDescription: "Test Activity",
				CreatedBy: "testuser"
			);

			var activity = Activity.Create(0, createDto.ActivityName!, createDto.ActivityDescription!);
			var activityDto = new ActivityReadDto(0, createDto.ActivityName!, createDto.ActivityDescription!);

			_unitOfWorkMock.Setup(x => x.Activity.Get(It.IsAny<Expression<Func<Activity, bool>>>(), null)).ReturnsAsync((Activity)null!);
			_mapperMock.Setup(x => x.Map<ActivityReadDto>(It.IsAny<Activity>())).Returns(activityDto);

			// Act
			var result = await _activityService.CreateActivityAsync(createDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Activity.Insert(It.IsAny<Activity>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task CreateActivityAsync_WithExistingInitial_ShouldReturnError()
		{
			// Arrange
			var createDto = new ActivityCreateDto
			(
				ActivityName: "Test Activity",
				ActivityDescription: "Testing Activities",
				CreatedBy: "testuser"
			);

			var existingActivity = Activity.Create(2, "TEST", "Existing Activity");
			_unitOfWorkMock.Setup(x => x.Activity.Get(It.IsAny<Expression<Func<Activity, bool>>>(), null)).ReturnsAsync(existingActivity);

			// Act
			var result = await _activityService.CreateActivityAsync(createDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
			Assert.Equal("Activity Name already exists.", result.ErrorResponse.Message);
		}

		[Fact]
		public async Task UpdateActivityAsync_WithValidData_ShouldUpdateActivity()
		{
			// Arrange
			var updateDto = new ActivityUpdateDto
			(
				ActivityId: 1,
				ActivityName: "Updated Activity",
				ActivityDescription: "Updated Activity Description",
				ModifiedBy: "testuser"
			);

			var existingActivity = Activity.Create(1, "OLD", "Old Activity");
			var activityDto = new ActivityReadDto(1, "OLD", "Old Activity");

			_unitOfWorkMock.Setup(x => x.Activity.Get(updateDto.ActivityId)).ReturnsAsync(existingActivity);
			_mapperMock.Setup(x => x.Map<ActivityReadDto>(It.IsAny<Activity>())).Returns(activityDto);

			// Act
			var result = await _activityService.UpdateActivityAsync(updateDto);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Activity.Update(It.IsAny<Activity>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task UpdateActivityAsync_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			var updateDto = new ActivityUpdateDto
			(
				ActivityId: 999,
				ActivityName: "Test Activity",
				ActivityDescription: "Testing Activities",
				ModifiedBy: "testuser"
			);

			_unitOfWorkMock.Setup(x => x.Activity.Get(updateDto.ActivityId)).ReturnsAsync((Activity)null!);

			// Act
			var result = await _activityService.UpdateActivityAsync(updateDto);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status500InternalServerError, result.ErrorResponse!.Code);
		}

		[Fact]
		public async Task DeleteActivity_WithValidId_ShouldDeleteActivity()
		{
			// Arrange
			int activityId = 1;
			var existingActivity = Activity.Create(activityId, "TEST", "Test Activity");
			_unitOfWorkMock.Setup(x => x.Activity.Get(activityId)).ReturnsAsync(existingActivity);

			// Act
			var result = await _activityService.DeleteActivity(activityId);

			// Assert
			Assert.True(result.IsSuccess);
			Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
			_unitOfWorkMock.Verify(x => x.Activity.Delete(It.IsAny<Activity>()), Times.Once);
			_unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
		}

		[Fact]
		public async Task DeleteActivity_WithNonExistentId_ShouldReturnError()
		{
			// Arrange
			int activityId = 999;
			_unitOfWorkMock.Setup(x => x.Activity.Get(activityId)).ReturnsAsync((Activity)null!);

			// Act
			var result = await _activityService.DeleteActivity(activityId);

			// Assert
			Assert.False(result.IsSuccess);
			Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
		}
	}
}

