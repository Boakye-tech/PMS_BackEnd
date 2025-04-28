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
    public class NatureOfComplaintTests
    {
        private readonly Mock<ICustomerDomainService> _mockCustomerDomainService;

        public NatureOfComplaintTests()
        {
            _mockCustomerDomainService = new Mock<ICustomerDomainService>();
        }

        #region Constructor Tests

        [Fact]
        public void Constructor_WithValidParameters_ShouldCreateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Billing Issue";

            // Act
            var natureOfComplaint = new NatureOfComplaint(complaintTypeId, natureOfComplaintId, natureOfComplaints);

            // Assert
            Assert.Equal(complaintTypeId, natureOfComplaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, natureOfComplaint.NatureOfComplaintId);
            Assert.Equal(natureOfComplaints, natureOfComplaint.NatureOfComplaints);
        }

        #endregion

        #region Create Tests

        [Fact]
        public async Task Create_WithValidParameters_ShouldCreateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Billing Issue";

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaintId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaints)).ReturnsAsync(false);

            // Act
            var natureOfComplaint = await NatureOfComplaint.Create(
                complaintTypeId,
                natureOfComplaintId,
                natureOfComplaints,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, natureOfComplaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, natureOfComplaint.NatureOfComplaintId);
            Assert.Equal(natureOfComplaints, natureOfComplaint.NatureOfComplaints);

            _mockCustomerDomainService.Verify(s => s.NatureOfComplaintExist(natureOfComplaintId), Times.Once);
            _mockCustomerDomainService.Verify(s => s.NatureOfComplaintExist(natureOfComplaints), Times.Once);
        }

        [Theory]
        [InlineData(-1, 1, "Billing Issue")]
        [InlineData(1, -1, "Billing Issue")]
        [InlineData(1, 1, "")]
        [InlineData(1, 1, null)]
        public async Task Create_WithInvalidParameters_ShouldThrowArgumentException(
            int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
        {
            // Arrange
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(It.IsAny<int>())).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(It.IsAny<string>())).ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Create(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Create_WithTooLongName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = new string('A', 76); // 76 characters, exceeds 75 limit

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaintId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaints)).ReturnsAsync(false);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Create(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Create_WithExistingId_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Billing Issue";

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaintId)).ReturnsAsync(true);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaints)).ReturnsAsync(false);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Create(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));

            Assert.Equal("Nature Of Complaint Id already exist", exception.Message);
        }

        [Fact]
        public async Task Create_WithExistingName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Billing Issue";

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaintId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaints)).ReturnsAsync(true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Create(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));

            Assert.Equal("Nature Of Complaint already exist", exception.Message);
        }

        #endregion

        #region Update Tests

        [Fact]
        public async Task Update_WithValidParameters_ShouldUpdateInstance()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Updated Billing Issue";

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(complaintTypeId)).ReturnsAsync(true);

            // Act
            var natureOfComplaint = await NatureOfComplaint.Update(
                complaintTypeId,
                natureOfComplaintId,
                natureOfComplaints,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, natureOfComplaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, natureOfComplaint.NatureOfComplaintId);
            Assert.Equal(natureOfComplaints, natureOfComplaint.NatureOfComplaints);

            _mockCustomerDomainService.Verify(s => s.NatureOfComplaintExist(complaintTypeId), Times.Once);
        }

        [Theory]
        [InlineData(-1, 1, "Billing Issue")]
        [InlineData(1, -1, "Billing Issue")]
        [InlineData(1, 1, "")]
        [InlineData(1, 1, null)]
        public async Task Update_WithInvalidParameters_ShouldThrowArgumentException(
            int complaintTypeId, int natureOfComplaintId, string natureOfComplaints)
        {
            // Arrange
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(It.IsAny<int>())).ReturnsAsync(true);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Update(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Update_WithTooLongName_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 1;
            int natureOfComplaintId = 2;
            string natureOfComplaints = new string('A', 76); // 76 characters, exceeds 75 limit

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(complaintTypeId)).ReturnsAsync(true);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Update(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
                    _mockCustomerDomainService.Object));
        }

        [Fact]
        public async Task Update_WithNonExistingComplaintTypeId_ShouldThrowArgumentException()
        {
            // Arrange
            int complaintTypeId = 999; // Non-existing ID
            int natureOfComplaintId = 2;
            string natureOfComplaints = "Billing Issue";

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(complaintTypeId)).ReturnsAsync(false);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<ArgumentException>(() =>
                NatureOfComplaint.Update(
                    complaintTypeId,
                    natureOfComplaintId,
                    natureOfComplaints,
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
            int natureOfComplaintId = 0; // Minimum valid value
            string natureOfComplaints = new string('A', 75); // Maximum valid length

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaintId)).ReturnsAsync(false);
            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(natureOfComplaints)).ReturnsAsync(false);

            // Act
            var natureOfComplaint = await NatureOfComplaint.Create(
                complaintTypeId,
                natureOfComplaintId,
                natureOfComplaints,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, natureOfComplaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, natureOfComplaint.NatureOfComplaintId);
            Assert.Equal(natureOfComplaints, natureOfComplaint.NatureOfComplaints);
        }

        [Fact]
        public async Task Update_WithBoundaryValues_ShouldUpdateInstance()
        {
            // Arrange
            int complaintTypeId = 0; // Minimum valid value
            int natureOfComplaintId = 0; // Minimum valid value
            string natureOfComplaints = new string('A', 75); // Maximum valid length

            _mockCustomerDomainService.Setup(s => s.NatureOfComplaintExist(complaintTypeId)).ReturnsAsync(true);

            // Act
            var natureOfComplaint = await NatureOfComplaint.Update(
                complaintTypeId,
                natureOfComplaintId,
                natureOfComplaints,
                _mockCustomerDomainService.Object);

            // Assert
            Assert.Equal(complaintTypeId, natureOfComplaint.ComplaintTypeId);
            Assert.Equal(natureOfComplaintId, natureOfComplaint.NatureOfComplaintId);
            Assert.Equal(natureOfComplaints, natureOfComplaint.NatureOfComplaints);
        }

        #endregion
    }
}

