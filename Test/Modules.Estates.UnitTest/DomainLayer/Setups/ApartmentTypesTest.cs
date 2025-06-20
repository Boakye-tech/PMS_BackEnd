// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/ApartmentTypesTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:41 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Xunit;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class ApartmentTypesTest
	{
		[Fact]
		public void Create_WithValidParameters_ShouldCreateApartmentTypes()
		{
			// Arrange
			int apartmentTypeId = 1;
			string apartmentTypeName = "2 Bedroom Apartment";
			float sellingPrice = 150000.00f;
			int currencyId = 1;
			double floorArea = 120.5;
			string[] images = { "https://images.com",string.Empty, string.Empty, string.Empty, string.Empty };

            // Act	
            var apartmentType = ApartmentTypes.Create(1 ,apartmentTypeId, apartmentTypeName, sellingPrice, currencyId, floorArea, images);

			// Assert
			Assert.Equal(apartmentTypeId, apartmentType.ApartmentTypeId);
			Assert.Equal(apartmentTypeName, apartmentType.ApartmentType);
			Assert.Equal(sellingPrice, apartmentType.SellingPrice);
		}

		[Fact]
		public void Update_WithValidParameters_ShouldUpdateApartmentTypes()
		{
            string[] images = { "https://images.com", string.Empty, string.Empty, string.Empty, string.Empty };

            // Arrange		
            var apartmentType = ApartmentTypes.Create(1, 1, "2 Bedroom Apartment", 150000.00f, 1, 120.5, images);

			int newApartmentTypeId = 1;
			string newApartmentTypeName = "3 Bedroom Apartment";
			float newSellingPrice = 180000.00f;
			int newCurrencyId = 1;
			double newFloorArea = 150.0;
            string[] newImages = { "https://images.com", "https://images1.com", string.Empty, string.Empty, string.Empty };

            // Act
            apartmentType.Update(1,newApartmentTypeId, newApartmentTypeName, newSellingPrice, newCurrencyId, newFloorArea, newImages);

			// Assert
			Assert.Equal(newApartmentTypeId, apartmentType.ApartmentTypeId);

		}
	}
}



