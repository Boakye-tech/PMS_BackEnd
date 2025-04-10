using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Modules.Estates.ApplicationLayer.Services;
using Modules.Estates.Domain.Entities;
using Modules.Estates.Domain.Enums;

namespace Modules.Estates.UnitTest.ApplicationLayer.Services
{
    public class CustomerMasterUpdateServiceTests
    {
        private readonly CustomerMasterUpdateService _service;
        private readonly Mock<IDomainService> _mockDomainService;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;

        public CustomerMasterUpdateServiceTests()
        {
            _mockDomainService = new Mock<IDomainService>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _service = new CustomerMasterUpdateService(_mockDomainService.Object, _mockUnitOfWork.Object);
        }

        [Fact]
        public async Task UpdateCustomer_WithValidProspectiveData_ShouldUpdateSuccessfully()
        {
            // Arrange
            var updateDto = new UpdateProspectiveCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.PROSPECTIVE, // Use enum value to ensure valid type
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = "PROS001",
                TitleId = 1,
                SurName = "Smith",
                OtherNames = "John",
                CompanyName = "",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "0244111222",
                SecondaryMobileNumber = "0244333444",
                OfficeNumber = "0302555666",
                WhatsAppNumber = "0244111222",
                EmailAddress = "john.smith@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "jsmith",
                Comments = "Potential customer",
                InterestExpressed = "3 bedroom apartment",
                ModifiedBy = "system"
            };

            var title = new Title { TitleId = 1, Titles = "Mr." };
            var existingCustomer = new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerCode = "PROS001",
                CustomerTypeId = (int)CustomerTypeEnum.PROSPECTIVE,
                TitleId = 1,
                SurName = "Smith",
                OtherNames = "John",
                PrimaryMobileNumber = "0244111222"
            };

            // Mock domain service validation
            _mockDomainService.Setup(d => d.ValidateCustomerType(It.IsAny<int>()))
                .Returns(true);
            _mockDomainService.Setup(d => d.ValidateResidentType(It.IsAny<int>()))
                .Returns(true);
            _mockDomainService.Setup(d => d.ValidateLocality(It.IsAny<int>()))
                .Returns(true);

            // Mock the UpdateProspectiveAsync method
            _mockUnitOfWork.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>()))
                .ReturnsAsync(existingCustomer);
            _mockUnitOfWork.Setup(u => u.Title.Get(It.IsAny<Expression<Func<Title, bool>>>()))
                .ReturnsAsync(title);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.UpdateCustomer(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("PROS001", result.SuccessResponse.CustomerCode);
            Assert.Contains("John Smith", result.SuccessResponse.FullName);
            Assert.Equal("0244111222", result.SuccessResponse.PhoneNumber);

            // Verify method calls
            _mockDomainService.Verify(d => d.ValidateCustomerType(It.IsAny<int>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }
    }
}