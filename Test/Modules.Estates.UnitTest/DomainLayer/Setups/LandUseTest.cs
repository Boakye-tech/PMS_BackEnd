// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/LandUseTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 9:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
	public class LandUseTest
	{
        private readonly LandUse _landUse;

        public LandUseTest()
        {
            // Initialize with valid test data
            _landUse = LandUse.Create(1, "RPL", "RESIDENTIAL");
        }

        [Fact]
        public void Create_WithValidData_ShouldCreateLandUse()
        {
            // Arrange
            int landUseId = 1;
            string landUseInitial = "RPL";
            string landUseName = "RESIDENTIAL";

            // Act
            var result = LandUse.Create(landUseId, landUseInitial, landUseName);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(landUseId, result.LandUseId);
            Assert.Equal(landUseInitial, result.LandUseInitial);
            Assert.Equal(landUseName, result.LandUseName);
        }

        [Theory]
        [InlineData(-1, "RPL", "RESIDENTIAL")]
        [InlineData(1, "", "RESIDENTIAL")]
        [InlineData(1, null, "RESIDENTIAL")]
        [InlineData(1, "RPL", "")]
        [InlineData(1, "RPL", null)]
        public void Create_WithInvalidData_ShouldThrowArgumentException(int landUseId, string landUseInitial, string landUseName)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                LandUse.Create(landUseId, landUseInitial, landUseName));
        }

        [Fact]
        public void Update_WithValidData_ShouldUpdateLandUse()
        {
            // Arrange
            int landUseId = 1;
            string newLandUseInitial = "COM";
            string newLandUseName = "COMMERCIAL";

            // Act
            _landUse.Update(landUseId, newLandUseInitial, newLandUseName);

            // Assert
            Assert.Equal(newLandUseInitial, _landUse.LandUseInitial);
            Assert.Equal(newLandUseName, _landUse.LandUseName);
        }

        [Theory]
        [InlineData(-1, "COM", "COMMERCIAL")]
        [InlineData(1, "", "COMMERCIAL")]
        [InlineData(1, null, "COMMERCIAL")]
        [InlineData(1, "COM", "")]
        [InlineData(1, "COM", null)]
        public void Update_WithInvalidData_ShouldThrowArgumentException(int landUseId, string landUseInitial, string landUseName)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                _landUse.Update(landUseId, landUseInitial, landUseName));
        }

        [Theory]
        [InlineData("ABCDEF")] // 6 characters
        [InlineData("ABCDEFG")] // 7 characters
        public void LandUseInitial_ShouldNotExceedFiveCharacters(string landUseInitial)
        {
            // Arrange
            int landUseId = 1;
            string landUseName = "RESIDENTIAL";

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                LandUse.Create(landUseId, landUseInitial, landUseName));
        }

        [Fact]
        public void LandUseName_ShouldNotExceedThirtyCharacters()
        {
            // Arrange
            int landUseId = 1;
            string landUseInitial = "RPL";
            string landUseName = new string('A', 31); // 31 characters

            // Act & Assert
            Assert.Throws<ArgumentException>(() =>
                LandUse.Create(landUseId, landUseInitial, landUseName));
        }

        [Fact]
        public void LandUseId_ShouldBeReadOnly()
        {
            // Arrange
            var landUse = LandUse.Create(1, "RPL", "RESIDENTIAL");
            var propertyInfo = typeof(LandUse).GetProperty("LandUseId");

            // Assert
            Assert.True(propertyInfo.CanWrite);
        }

        [Fact]
        public void LandUseInitial_ShouldBeReadOnly()
        {
            // Arrange
            var landUse = LandUse.Create(1, "RPL", "RESIDENTIAL");
            var propertyInfo = typeof(LandUse).GetProperty("LandUseInitial");

            // Assert
            Assert.True(propertyInfo.CanWrite);
        }

        [Fact]
        public void LandUseName_ShouldBeReadOnly()
        {
            // Arrange
            var landUse = LandUse.Create(1, "RPL", "RESIDENTIAL");
            var propertyInfo = typeof(LandUse).GetProperty("LandUseName");

            // Assert
            Assert.True(propertyInfo.CanWrite);
        }

        

    }
}



