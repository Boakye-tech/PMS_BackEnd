// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.UnitTest
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Test/Modules.Estates.UnitTest/DomainLayer/Setups/AllocationTypeTest.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 13/05/2025 11:28 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
    public class AllocationTypeTest
    {
        [Fact]
        public void Create_WithValidParameters_ShouldCreateAllocationType()
        {
            // Arrange
            int allocationTypeId = 1;
            string allocationTypeInitial = "RENT";
            string allocationTypes = "Rental";

            // Act
            var allocationType = AllocationType.Create(allocationTypeId, allocationTypeInitial, allocationTypes);

            // Assert
            Assert.Equal(allocationTypeId, allocationType.AllocationTypeId);
            Assert.Equal(allocationTypeInitial, allocationType.AllocationTypeInitial);
            Assert.Equal(allocationTypes, allocationType.AllocationTypes);
        }

        [Theory]
        [InlineData(-1, "RENT", "Rental", "Allocation Type Id must be greater than zero.")]
        [InlineData(1, "", "Rental", "Allocation Type Initial cannot be empty or exceed 5 characters.")]
        [InlineData(1, null, "Rental", "Allocation Type Initial cannot be empty or exceed 5 characters.")]
        [InlineData(1, "RENT", "", "Allocation Type cannot be empty or exceed 30 characters.")]
        [InlineData(1, "RENT", null, "Allocation Type cannot be empty or exceed 30 characters.")]
        public void Create_WithInvalidParameters_ShouldThrowArgumentException(
            int allocationTypeId, string allocationTypeInitial, string allocationTypes, string expectedMessage)
        {
            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() =>
                AllocationType.Create(allocationTypeId, allocationTypeInitial, allocationTypes));
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void Update_WithValidParameters_ShouldUpdateAllocationType()
        {
            // Arrange
            var allocationType = AllocationType.Create(1, "RENT", "Rental");
            int newAllocationTypeId = 2;
            string newAllocationTypeInitial = "SALE";
            string newAllocationTypes = "Sale";

            // Act
            allocationType.Update(newAllocationTypeId, newAllocationTypeInitial, newAllocationTypes);

            // Assert
            Assert.Equal(newAllocationTypeId, allocationType.AllocationTypeId);
            Assert.Equal(newAllocationTypeInitial, allocationType.AllocationTypeInitial);
            Assert.Equal(newAllocationTypes, allocationType.AllocationTypes);
        }

        [Theory]
        [InlineData(-1, "RENT", "Rental", "Allocation Type Id must be greater than zero.")]
        [InlineData(1, "", "Rental", "Allocation Type Initial cannot be empty or exceed 5 characters.")]
        [InlineData(1, null, "Rental", "Allocation Type Initial cannot be empty or exceed 5 characters.")]
        [InlineData(1, "RENT", "", "Allocation Type cannot be empty or exceed 30 characters.")]
        [InlineData(1, "RENT", null, "Allocation Type cannot be empty or exceed 30 characters.")]
        public void Update_WithInvalidParameters_ShouldThrowArgumentException(
            int allocationTypeId, string allocationTypeInitial, string allocationTypes, string expectedMessage)
        {
            // Arrange
            var allocationType = AllocationType.Create(1, "RENT", "Rental");

            // Act & Assert
            var exception = Assert.Throws<ArgumentException>(() =>
                allocationType.Update(allocationTypeId, allocationTypeInitial, allocationTypes));
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
