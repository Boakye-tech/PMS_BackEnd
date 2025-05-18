// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/ActivityTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:38 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class ActivityTest
	{
		public ActivityTest()
		{
		}

		[Fact]
		public void Create_WithValidParameters_ShouldCreateActivity()
		{
			// Arrange
			int activityId = 1;
			string activityName = "Property Inspection";
			string activityDescription = "Regular property inspection and maintenance check";

			// Act
			var activity = Activity.Create(activityId, activityName, activityDescription);

			// Assert
			Assert.Equal(activityId, activity.ActivityId);
			Assert.Equal(activityName, activity.ActivityName);
			Assert.Equal(activityDescription, activity.ActivityDescription);
		}

		[Fact]
		public void Create_WithNullDescription_ShouldCreateActivity()
		{
			// Arrange
			int activityId = 1;
			string activityName = "Property Inspection";
			string? activityDescription = null;

			// Act
			var activity = Activity.Create(activityId, activityName, activityDescription);

			// Assert
			Assert.Equal(activityId, activity.ActivityId);
			Assert.Equal(activityName, activity.ActivityName);
			Assert.Null(activity.ActivityDescription);
		}

		[Theory]
		[InlineData(-1, "Property Inspection", "Description", "Activity Id must be greater than zero.")]
		[InlineData(1, "", "Description", "Activity Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, null, "Description", "Activity Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, "Property Inspection", "This description is way too long and exceeds the maximum allowed length of 50 characters", "Activity Description cannot exceed 50 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int activityId, string activityName, string activityDescription, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				Activity.Create(activityId, activityName, activityDescription));
			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateActivity()
		{
			// Arrange
			var activity = Activity.Create(1, "Property Inspection", "Initial description");
			int newActivityId = 2;
			string newActivityName = "Maintenance";
			string newActivityDescription = "Regular maintenance check";

			// Act
			activity.Update(newActivityId, newActivityName, newActivityDescription);

			// Assert
			Assert.Equal(newActivityId, activity.ActivityId);
			Assert.Equal(newActivityName, activity.ActivityName);
			Assert.Equal(newActivityDescription, activity.ActivityDescription);
		}

		[Fact]
		public void Update_WithNullDescription_ShouldUpdateActivity()
		{
			// Arrange
			var activity = Activity.Create(1, "Property Inspection", "Initial description");
			int newActivityId = 2;
			string newActivityName = "Maintenance";
			string? newActivityDescription = null;

			// Act
			activity.Update(newActivityId, newActivityName, newActivityDescription);

			// Assert
			Assert.Equal(newActivityId, activity.ActivityId);
			Assert.Equal(newActivityName, activity.ActivityName);
			Assert.Null(activity.ActivityDescription);
		}

		[Theory]
		[InlineData(-1, "Property Inspection", "Description", "Activity Id must be greater than zero.")]
		[InlineData(1, "", "Description", "Activity Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, null, "Description", "Activity Name cannot be empty or exceed 50 characters.")]
		[InlineData(1, "Property Inspection", "This description is way too long and exceeds the maximum allowed length of 50 characters", "Activity Description cannot exceed 50 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int activityId, string activityName, string activityDescription, string expectedMessage)
		{
			// Arrange
			var activity = Activity.Create(1, "Property Inspection", "Initial description");

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() =>
				activity.Update(activityId, activityName, activityDescription));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

