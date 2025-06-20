// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/ActivityTypeTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:40 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class ActivityTypeTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateActivityType()
		{
			// Arrange
			int activityId = 1;
			int activityTypeId = 1;
			string activityTypeName = "Property Inspection";
			string activityTypeDescription = "Regular property inspection and maintenance check";

			// Act
			var activityType = ActivityType.Create(activityId, activityTypeId, activityTypeName, activityTypeDescription);

			// Assert
			Assert.Equal(activityId, activityType.ActivityId);
			Assert.Equal(activityTypeId, activityType.ActivityTypeId);
			Assert.Equal(activityTypeName, activityType.ActivityTypeName);
			Assert.Equal(activityTypeDescription, activityType.ActivityTypeDescription);
		}

		[Fact]
		public void Create_WithNullDescription_ShouldCreateActivityType()
		{
			// Arrange
			int activityId = 1;
			int activityTypeId = 1;
			string activityTypeName = "Property Inspection";
			string? activityTypeDescription = null;

			// Act
			var activityType = ActivityType.Create(activityId, activityTypeId, activityTypeName, activityTypeDescription);

			// Assert
			Assert.Equal(activityId, activityType.ActivityId);
			Assert.Equal(activityTypeId, activityType.ActivityTypeId);
			Assert.Equal(activityTypeName, activityType.ActivityTypeName);
			Assert.Null(activityType.ActivityTypeDescription);
		}

		[Theory]
		[InlineData(-1, 1, "Property Inspection", "Description", "Activity Id must be greater than zero.")]
		[InlineData(1, -1, "Property Inspection", "Description", "Activity Type Id must be greater than zero.")]
		[InlineData(1, 1, "", "Description", "Activity Type Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, 1, null, "Description", "Activity Type Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, 1, "Property Inspection", "This description is way too long and exceeds the maximum allowed length of 250 characters,This description is way too long and exceeds the maximum allowed length of 250 characters," +
											     "This description is way too long and exceeds the maximum allowed length of 250 characters,This description is way too long and exceeds the maximum allowed length of 250 characters," +
												 "This description is way too long and exceeds the maximum allowed length of 250 characters",
			"Activity Type Description cannot exceed 250 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(int activityId, int activityTypeId, string activityTypeName, string activityTypeDescription, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				ActivityType.Create(activityId, activityTypeId, activityTypeName, activityTypeDescription));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateActivityType()
		{
			// Arrange
			var activityType = ActivityType.Create(1, 1, "Property Inspection", "Initial description");
			int newActivityId = 2;
			int newActivityTypeId = 2;
			string newActivityTypeName = "Maintenance";
			string newActivityTypeDescription = "Regular maintenance check";

			// Act
			activityType.Update(newActivityId, newActivityTypeId, newActivityTypeName, newActivityTypeDescription);

			// Assert
			Assert.Equal(newActivityId, activityType.ActivityId);
			Assert.Equal(newActivityTypeId, activityType.ActivityTypeId);
			Assert.Equal(newActivityTypeName, activityType.ActivityTypeName);
			Assert.Equal(newActivityTypeDescription, activityType.ActivityTypeDescription);
		}

		[Fact]
		public void Update_WithNullDescription_ShouldUpdateActivityType()
		{
			// Arrange
			var activityType = ActivityType.Create(1, 1, "Property Inspection", "Initial description");
			int newActivityId = 2;
			int newActivityTypeId = 2;
			string newActivityTypeName = "Maintenance";
			string? newActivityTypeDescription = null;

			// Act
			activityType.Update(newActivityId, newActivityTypeId, newActivityTypeName, newActivityTypeDescription);

			// Assert
			Assert.Equal(newActivityId, activityType.ActivityId);
			Assert.Equal(newActivityTypeId, activityType.ActivityTypeId);
			Assert.Equal(newActivityTypeName, activityType.ActivityTypeName);
			Assert.Null(activityType.ActivityTypeDescription);
		}

		[Theory]
		[InlineData(-1, 1, "Property Inspection", "Description", "Activity Id must be greater than zero.")]
		[InlineData(1, -1, "Property Inspection", "Description", "Activity Type Id must be greater than zero.")]
		[InlineData(1, 1, "", "Description", "Activity Type Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, 1, null, "Description", "Activity Type Name cannot be empty or exceed 50 characters.")]
        [InlineData(1, 1, "Property Inspection", "This description is way too long and exceeds the maximum allowed length of 250 characters,This description is way too long and exceeds the maximum allowed length of 250 characters," +
                                                 "This description is way too long and exceeds the maximum allowed length of 250 characters,This description is way too long and exceeds the maximum allowed length of 250 characters," +
                                                 "This description is way too long and exceeds the maximum allowed length of 250 characters",
            "Activity Type Description cannot exceed 250 characters.")]
        public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int activityId, int activityTypeId, string activityTypeName, string activityTypeDescription, string expectedMessage)
		{
			// Arrange
			var activityType = ActivityType.Create(1, 1, "Property Inspection", "Initial description");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				activityType.Update(activityId, activityTypeId, activityTypeName, activityTypeDescription));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

