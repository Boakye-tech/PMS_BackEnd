// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/LocalityTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:42 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class LocalityTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateLocality()
		{
			// Arrange
			int localityId = 1;
			string localityInitials = "C01";
			string localityName = "COMMUNITY ONE";
			string customerCode = "2AB";
			int customerCodeCounter = 01;

			// Act
			var locality = Locality.Create(localityId, localityInitials, localityName, customerCode, customerCodeCounter);

			// Assert
			Assert.Equal(localityId, locality.LocalityId);
			Assert.Equal(localityInitials, locality.LocalityInitial);
			Assert.Equal(localityName, locality.LocalityName);
			Assert.Equal(customerCode, locality.CustomerCode);
			Assert.Equal(customerCodeCounter, locality.CustomerCodeCounter);
		}

		[Theory]
		[InlineData(-1, "C01", "COMMUNITY ONE", "2AB", 01, "Locality Id must be greater than zero.")]
		[InlineData(0, "", "COMMUNITY ONE", "2AB", 01, "Locality Initial cannot be empty or exceed 10 characters.")]
		[InlineData(0, null, "COMMUNITY ONE", "2AB", 01, "Locality Initial cannot be empty or exceed 10 characters.")]
		[InlineData(0, "C01", "", "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(0, "C01", null, "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(0, "C01", "This locality name is way too long and exceeds the maximum allowed length of 20 characters", "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(0, "C01", "COMMUNITY ONE", "", 01, "Customer Code cannot be empty or exceed 5 characters.")]
		[InlineData(0, "C01", "COMMUNITY ONE", "", 010101, "Customer Code cannot be empty or exceed 5 characters.")]
		public void Create_WithInvalidParameters_ShouldThrowArgumentException(
			int localityId, string localityInitials, string localityName, string customerCode, int customerCodeCounter, string expectedMessage)
		{
			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => Locality.Create(localityId, localityInitials, localityName, customerCode, customerCodeCounter));

			Assert.Equal(expectedMessage, exception.Message);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateLocality()
		{
			// Arrange
			var locality = Locality.Create(1, "C01", "COMMUNITY ONE", "2AB", 01);
			string newLocalityInitials = "D01";
			string newLocalityName = "COMMUNITY-ONE(1)";
			string newCustomerCode = "22B";
			int newCustomerCodeCounter = 120;

			// Act
			locality.Update(1, newLocalityInitials, newLocalityName, newCustomerCode, newCustomerCodeCounter);

			// Assert
			Assert.Equal(newLocalityInitials, locality.LocalityInitial);
			Assert.Equal(newLocalityName, locality.LocalityName);
			Assert.Equal(newCustomerCode, locality.CustomerCode);
			Assert.Equal(newCustomerCodeCounter, locality.CustomerCodeCounter);
		}

		[Theory]
		[InlineData(-1, "C01", "COMMUNITY ONE", "2AB", 01, "Locality Id must be greater than zero.")]
		[InlineData(1, "", "COMMUNITY ONE", "2AB", 01, "Locality Initial cannot be empty or exceed 10 characters.")]
		[InlineData(1, null, "COMMUNITY ONE", "2AB", 01, "Locality Initial cannot be empty or exceed 10 characters.")]
		[InlineData(1, "C01", "", "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(1, "C01", null, "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(1, "C01", "This locality name is way too long and exceeds the maximum allowed length of 20 characters", "2AB", 01, "Locality Name cannot be empty or exceed 20 characters.")]
		[InlineData(1, "C01", "COMMUNITY ONE", "", 01, "Customer Code cannot be empty or exceed 5 characters.")]
		[InlineData(1, "C01", "COMMUNITY ONE", "", 010101, "Customer Code cannot be empty or exceed 5 characters.")]
		public void Update_WithInvalidParameters_ShouldThrowArgumentException(
			int localityId, string localityInitials, string localityName, string customerCode, int customerCodeCounter, string expectedMessage)
		{
			// Arrange
			var locality = Locality.Create(1, "C01", "COMMUNITY ONE", "2AB", 01);

			// Act & Assert
			var exception = Assert.Throws<ArgumentException>(() => locality.Update(localityId, localityInitials, localityName, customerCode, customerCodeCounter));
			Assert.Equal(expectedMessage, exception.Message);
		}
	}
}

