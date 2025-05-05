// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Interfaces.DomainServices;
using Moq;

namespace Modules.Estates.UnitTest.DomainLayer.Setups
{
    public class ComplaintTypeTests
    {
        private readonly Mock<ICustomerDomainService> _mockCustomerDomainService;

        public ComplaintTypeTests()
        {
            _mockCustomerDomainService = new Mock<ICustomerDomainService>();
        }

        #region Constructor Tests

        [Fact]
        public void Constructor_WithValidParameters_ShouldCreateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = "Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            // Act
            var complaintType = new ComplaintType(complaintTypeId, complaintTypes, departmentId, departmentUnitId);

            // Assert
            Assert.Equal(complaintTypeId, complaintType.ComplaintTypeId);
            Assert.Equal(complaintTypes, complaintType.ComplaintTypes);
            Assert.Equal(departmentId, complaintType.DepartmentId);
            Assert.Equal(departmentUnitId, complaintType.DepartmentUnitId);
        }

        #endregion

        #region Create Tests

        [Fact]
        public async Task Create_WithValidParameters_ShouldCreateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = "Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypes)).ReturnsAsync(false);

            // Act
            var complaintType = await ComplaintType.Create(
                complaintTypeId,
                complaintTypes,
                departmentId,
                departmentUnitId,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, complaintType.ComplaintTypeId);
            Assert.Equal(complaintTypes, complaintType.ComplaintTypes);
            Assert.Equal(departmentId, complaintType.DepartmentId);
            Assert.Equal(departmentUnitId, complaintType.DepartmentUnitId);

            _mockCustomerDomainService.Verify(s => s.ComplaintTypeExist(complaintTypeId), Times.Once);
            _mockCustomerDomainService.Verify(s => s.ComplaintTypeExist(complaintTypes), Times.Once);
        }

        [Theory]
        [InlineData(-1, "Billing Complaint", 1, 1)]
        [InlineData(1, "", 1, 1)]
        [InlineData(1, null, 1, 1)]
        [InlineData(1, "Billing Complaint", 0, 1)]
        public async Task Create_WithInvalidParameters_ShouldThrowArgumentException(
            int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            // Arrange
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(It.IsAny<int>())).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(It.IsAny<string>())).ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Create(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Create_WithTooLongName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = new string('A', 121); // 121 characters, exceeds 120 limit
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypes)).ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Create(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Create_WithExistingId_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = "Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(true);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypes)).ReturnsAsync(false);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Create(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));

            Assert.Equal("Complaint Type Id already exist", exception.Message);
        }

        [Fact]
        public async Task Create_WithExistingName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = "Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypes)).ReturnsAsync(true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Create(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));

            Assert.Equal("Complaint Type already exist", exception.Message);
        }

        #endregion

        #region Update Tests

        [Fact]
        public async Task Update_WithValidParameters_ShouldUpdateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = "Updated Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(true);

            // Act
            var complaintType = await ComplaintType.Update(
                complaintTypeId,
                complaintTypes,
                departmentId,
                departmentUnitId,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, complaintType.ComplaintTypeId);
            Assert.Equal(complaintTypes, complaintType.ComplaintTypes);
            Assert.Equal(departmentId, complaintType.DepartmentId);
            Assert.Equal(departmentUnitId, complaintType.DepartmentUnitId);

            _mockCustomerDomainService.Verify(s => s.ComplaintTypeExist(complaintTypeId), Times.Once);
        }

        [Theory]
        [InlineData(-1, "Billing Complaint", 1, 1)]
        [InlineData(1, "", 1, 1)]
        [InlineData(1, null, 1, 1)]
        [InlineData(1, "Billing Complaint", 0, 1)]
        public async Task Update_WithInvalidParameters_ShouldThrowArgumentException(
            int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId)
        {
            // Arrange
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(It.IsAny<int>())).ReturnsAsync(true);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Update(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Update_WithTooLongName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            string complaintTypes = new string('A', 121); // 121 characters, exceeds 120 limit
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(true);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Update(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Update_WithNonExistingComplaintTypeId_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 999; // Non-existing ID
            string complaintTypes = "Billing Complaint";
            int departmentId = 1;
            int departmentUnitId = 2;

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(false);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                ComplaintType.Update(
                    complaintTypeId,
                    complaintTypes,
                    departmentId,
                    departmentUnitId,
                    _mockCustomerDomainService.Object));

            Assert.Equal("Complaint Type Id supplied does not exist.", exception.Message);
        }

        #endregion

        #region Boundary Tests

        [Fact]
        public async Task Create_WithBoundaryValues_ShouldCreateInstance()
        {
            // Arrange
            int complaintTypeId = 0; // Minimum valid value
            string complaintTypes = new string('A', 120); // Maximum valid length
            int departmentId = 1; // Minimum valid value
            int departmentUnitId = 0; // Minimum valid value

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypes)).ReturnsAsync(false);

            // Act
            var complaintType = await ComplaintType.Create(
                complaintTypeId,
                complaintTypes,
                departmentId,
                departmentUnitId,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, complaintType.ComplaintTypeId);
            Assert.Equal(complaintTypes, complaintType.ComplaintTypes);
            Assert.Equal(departmentId, complaintType.DepartmentId);
            Assert.Equal(departmentUnitId, complaintType.DepartmentUnitId);
        }

        [Fact]
        public async Task Update_WithBoundaryValues_ShouldUpdateInstance()
        {
            // Arrange
            int complaintTypeId = 0; // Minimum valid value
            string complaintTypes = new string('A', 120); // Maximum valid length
            int departmentId = 1; // Minimum valid value
            int departmentUnitId = 0; // Minimum valid value

            _mockCustomerDomainService.Setup(s => s.ComplaintTypeExist(complaintTypeId)).ReturnsAsync(true);

            // Act
            var complaintType = await ComplaintType.Update(
                complaintTypeId,
                complaintTypes,
                departmentId,
                departmentUnitId,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, complaintType.ComplaintTypeId);
            Assert.Equal(complaintTypes, complaintType.ComplaintTypes);
            Assert.Equal(departmentId, complaintType.DepartmentId);
            Assert.Equal(departmentUnitId, complaintType.DepartmentUnitId);
        }

        #endregion
    }
}

