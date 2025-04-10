using Xunit;
using FluentAssertions;
using Moq;
using AutoFixture;
using Modules.Estates.Application.UseCases.Management.Customer;
using Modules.Estates.Domain.Interfaces;
using Modules.Estates.Domain.Interfaces.DomainServices;
using Modules.Estates.Domain.Entities.Registration;
using Microsoft.Extensions.Logging;
using AutoMapper;
using Modules.Estates.Application.DTO.Management.Customer;
using Modules.Estates.Application.Interfaces.ModuleServices;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Events;
using System.Linq.Expressions;
using Modules.Estates.Domain;
using Modules.Estates.Application.Enums;
using Modules.Estates.UnitTest.InfrastructureLayer.Data;
using Modules.Estates.Domain.Entities.Management;

namespace Modules.Estates.UnitTest.ApplicationLayer.Services
{
    public class CustomerMasterServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly Mock<ICustomerDomainService> _domainServiceMock;
        private readonly Mock<IModuleCommunicationServices> _moduleCommsMock;
        private readonly Mock<ILogger<CustomerMasterService>> _loggerMock;
        private readonly Mock<IDomainEventDispatcher> _domainEventDispatcherMock;
        private readonly IFixture _fixture;
        private readonly CustomerMasterService _sut;

        public CustomerMasterServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _domainServiceMock = new Mock<ICustomerDomainService>();
            _moduleCommsMock = new Mock<IModuleCommunicationServices>();
            _loggerMock = new Mock<ILogger<CustomerMasterService>>();
            _domainEventDispatcherMock = new Mock<IDomainEventDispatcher>();
            _fixture = new Fixture();

            _sut = new CustomerMasterService(
                _unitOfWorkMock.Object,
                _mapperMock.Object,
                _domainServiceMock.Object,
                _moduleCommsMock.Object,
                _loggerMock.Object,
                _domainEventDispatcherMock.Object
            );
        }

        [Fact]
        public async Task CreateCustomer_WithValidProspectiveData_ShouldCreateCustomerSuccessfully()
        {
            // Arrange
            var dto = new ProspectiveCustomerCreateDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.PROSPECTIVE,
                ResidentTypeId = 0,
                LocalityId = 1,
                CustomerCode = "CUST001",
                TitleId = 1,
                SurName = "Doe",
                OtherNames = "John",
                CompanyName = "Company",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "+233123456789",
                SecondaryMobileNumber = "+233987654321",
                OfficeNumber = "+233234567890",
                WhatsAppNumber = "+233123456789",
                EmailAddress = "john.doe@example.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@johndoe",
                Comments = "Test comment",
                InterestExpressed = "Residential property",
                CreatedBy = "system"
            };

            //various mock
            var mockLocality = new Locality(1, "T01", "TEST LOCALITY", "9T9", 1);
            var mockTitle = new Title(1,"Mr");
            var mockSocialMedia = new SocialMedia(1, "Facebook");

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()));

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<int>()))
                 .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null))
                .ReturnsAsync(mockSocialMedia);

            _domainServiceMock.Setup(x => x.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GetLocalityDetails(It.IsAny<int>()))
                .ReturnsAsync(mockLocality);
            _domainServiceMock.Setup(x => x.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);

            // Act
            var result = await _sut.CreateCustomer(dto);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.SuccessResponse.Should().NotBeNull();
            result.SuccessResponse.CustomerCode.Should().NotBeNullOrEmpty();

            _unitOfWorkMock.Verify(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task CreateCustomer_WithValidCompanyData_ShouldCreateCustomerSuccessfully()
        {
            // Arrange

            var dto = new CreateCompanyCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.COMPANY,
                ResidentTypeId = 0,
                LocalityId = 1,
                CustomerCode = string.Empty,
                CompanyName = "Test Company Ltd",
                NationalityId = 1,
                CompanyAddress = "123 Business St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "233123456789",
                SecondaryMobileNumber = "233987654321",
                OfficeNumber = "233234567890",
                WhatsAppNumber = "233123456789",
                EmailAddress = "info@testcompany.com",
                BusinessRegistrationNumber = "BRN123456",
                TinNumber = "TIN123456",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@testcompany",
                IdentificationImages = new string[] { "doc1.jpg" },
                Comments = "Test comment",
                CreatedBy = "system",
                ContactPerson = new CompanyContactPerson
                {
                    ContactPerson_FullName = "John Contact",
                    ContactPerson_PhoneNumber = "+233111222333",
                    ContactPerson_EmailAddress = "contact@testcompany.com",
                    ContactPerson_Address = "Contact Address",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationTypeNumber = "CP123456",
                    ContactPerson_IdentificationImages = new string[] { "cp1.jpg" }
                }
            };

            var mockLocality = new Locality(1, "T01", "TEST LOCALITY", "9T9", 1);


            _unitOfWorkMock.Setup(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()));

            _unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<int>()))
                 .ReturnsAsync(mockLocality);

            _domainServiceMock.Setup(x => x.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GetLocalityDetails(It.IsAny<int>()))
                .ReturnsAsync(mockLocality);

            _domainServiceMock.Setup(x => x.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);

            // Act
            var result = await _sut.CreateCustomer(dto);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.SuccessResponse.Should().NotBeNull();
            result.SuccessResponse.CustomerCode.Should().NotBeNullOrEmpty();

            _unitOfWorkMock.Verify(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteCustomerAsync_WithValidCustomerCode_ShouldDeleteSuccessfully()
        {
            // Arrange
            var request = new DeleteCustomerRequestDto("CUST001","admin");

            var customer = new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerCode = "CUST001"
            };


            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);


            // Act
            var result = await _sut.DeleteCustomerAsync(request);

            // Assert
            result.Should().Be(200);

            _unitOfWorkMock.Verify(x => x.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteCustomerAsync_WithInvalidCustomerCode_ShouldReturn404()
        {
            // Arrange
            var request = new DeleteCustomerRequestDto("INVALID001", "admin");

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync((CustomerMaster)null!);

            // Act
            var result = await _sut.DeleteCustomerAsync(request);

            // Assert
            result.Should().Be(404);

            _unitOfWorkMock.Verify(x => x.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Never);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Never);
        }

        [Fact]
        public async Task CreateCustomer_WithValidIndividualExpariateData_ShouldCreateCustomerSuccessfully()
        {
            // Arrange
            var dto = new IndividualResidentCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                ResidentTypeId = (int)ResidentTypeEnum.EXPATRIATE,
                LocalityId = 1,
                CustomerCode = "IND001",
                TitleId = 1,
                SurName = "Doe",
                OtherNames = "John",
                DateOfBirth = DateTime.Now.AddYears(-30),
                TinNumber = "TIN123456",
                Picture = "profile.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "+233123456789",
                SecondaryMobileNumber = "+233987654321",
                OfficeNumber = "+233234567890",
                WhatsAppNumber = "+233123456789",
                EmailAddress = "john.doe@example.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@johndoe",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "ID123456",
                IdentificationImages = new string[]
                {
                    "id1.jpg",
                    "id2.jpg",
                    "id3.jpg"
                },
                Comments = "Individual registration",
                CreatedBy = "system",
                Expatriate = new IndividualExpatriateCustomerDto
                {
                    ResidentPermitNumber = "RP123456",
                    ResidentPermitDateIssued = DateTime.Now.AddYears(-1),
                    ResidentPermitExpiryDate = DateTime.Now.AddYears(1)
                },
                NonResident = new IndividualNonResidentCustomerDto
                {
                    ContactPerson_FullName = string.Empty,
                    ContactPerson_PhoneNumber = string.Empty,
                    ContactPerson_EmailAddress = string.Empty,
                    ContactPerson_Address = string.Empty,
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationTypeNumber = string.Empty,
                    ContactPerson_IdentificationImages = new string[]
                    {
                        string.Empty
                    }
                }
            };

            //various mock
            var mockLocality = new Locality(1, "T01", "TEST LOCALITY", "9T9", 1);
            var mockTitle = new Title(1, "Mr");
            var mockSocialMedia = new SocialMedia(1, "Facebook");

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()));

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<int>()))
                 .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null))
                .ReturnsAsync(mockSocialMedia);

            _unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<int>()))
               .ReturnsAsync(mockLocality);


            _domainServiceMock.Setup(x => x.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GetLocalityDetails(It.IsAny<int>()))
                .ReturnsAsync(mockLocality);

            // Act
            var result = await _sut.CreateCustomer(dto);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.SuccessResponse.Should().NotBeNull();
            result.SuccessResponse.CustomerCode.Should().NotBeNullOrEmpty();
            result.SuccessResponse.FullName.Should().Be("Mr John Doe");
            result.SuccessResponse.PhoneNumber.Should().Be(dto.PrimaryMobileNumber);

            // Verify repository calls
            _unitOfWorkMock.Verify(x => x.CustomerMaster.Insert(It.Is<CustomerMaster>(c =>
                c.CustomerTypeId == dto.CustomerTypeId &&
                c.ResidentTypeId == dto.ResidentTypeId &&
                c.LocalityId == dto.LocalityId &&
                c.SurName == dto.SurName &&
                c.OtherNames == dto.OtherNames &&
                c.EmailAddress == dto.EmailAddress &&
                c.PrimaryMobileNumber == dto.PrimaryMobileNumber &&
                c.CreatedBy == dto.CreatedBy &&
                c.DebtorStatus == 1
            )), Times.Once);

            // Verify locality counter update
            _unitOfWorkMock.Verify(x => x.Locality.Update(It.Is<Locality>(l =>
                l.LocalityId == dto.LocalityId
            )), Times.Once);

            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);

            // Verify domain service validations
            _domainServiceMock.Verify(x => x.LocalityExists(dto.LocalityId), Times.Once);
            _domainServiceMock.Verify(x => x.CustomerTypeExists(dto.CustomerTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.ResidentTypeExists(dto.ResidentTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.GenderExists(dto.GenderId), Times.Once);
            _domainServiceMock.Verify(x => x.NationalityExists(dto.NationalityId), Times.Once);
            _domainServiceMock.Verify(x => x.IdentificationTypeExists(dto.IdentificationTypeId), Times.Once);
        }

        [Fact]
        public async Task CreateCustomer_WithValidIndividualResidentData_ShouldCreateCustomerSuccessfully()
        {
            // Arrange
            var dto = new IndividualResidentCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                ResidentTypeId = (int)ResidentTypeEnum.RESIDENT,
                LocalityId = 1,
                CustomerCode = "IND001",
                TitleId = 1,
                SurName = "Doe",
                OtherNames = "John",
                DateOfBirth = DateTime.Now.AddYears(-30),
                TinNumber = "TIN123456",
                Picture = "profile.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "+233123456789",
                SecondaryMobileNumber = "+233987654321",
                OfficeNumber = "+233234567890",
                WhatsAppNumber = "+233123456789",
                EmailAddress = "john.doe@example.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@johndoe",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "ID123456",
                IdentificationImages = new string[]
                {
                    "id1.jpg",
                    "id2.jpg",
                    "id3.jpg"
                },
                Comments = "Individual registration",
                CreatedBy = "system",
                Expatriate = new IndividualExpatriateCustomerDto
                {
                    ResidentPermitNumber = string.Empty,
                    ResidentPermitDateIssued = DateTime.Now,
                    ResidentPermitExpiryDate = DateTime.Now
                },
                NonResident = new IndividualNonResidentCustomerDto
                {
                    ContactPerson_FullName = string.Empty,
                    ContactPerson_PhoneNumber = string.Empty,
                    ContactPerson_EmailAddress = string.Empty,
                    ContactPerson_Address = string.Empty,
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationTypeNumber = string.Empty,
                    ContactPerson_IdentificationImages = new string[]
                    {
                        string.Empty
                    }
                }
            };

            //various mock
            var mockLocality = new Locality(1, "C01", "TEST LOCALITY", "2AA", 1);
            var mockTitle = new Title(1, "Mr");
            var mockSocialMedia = new SocialMedia(1, "Facebook");

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()));

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<int>()))
                 .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null))
                .ReturnsAsync(mockSocialMedia);

            _unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<int>()))
               .ReturnsAsync(mockLocality);

            _domainServiceMock.Setup(x => x.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GetLocalityDetails(It.IsAny<int>()))
                .ReturnsAsync(mockLocality);

            // Act
            var result = await _sut.CreateCustomer(dto);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.SuccessResponse.Should().NotBeNull();
            result.SuccessResponse.CustomerCode.Should().NotBeNullOrEmpty();
            result.SuccessResponse.FullName.Should().Be("Mr John Doe");
            result.SuccessResponse.PhoneNumber.Should().Be(dto.PrimaryMobileNumber);

            // Verify repository calls
            _unitOfWorkMock.Verify(x => x.CustomerMaster.Insert(It.Is<CustomerMaster>(c =>
                c.CustomerTypeId == dto.CustomerTypeId &&
                c.ResidentTypeId == dto.ResidentTypeId &&
                c.LocalityId == dto.LocalityId &&
                c.SurName == dto.SurName &&
                c.OtherNames == dto.OtherNames &&
                c.EmailAddress == dto.EmailAddress &&
                c.PrimaryMobileNumber == dto.PrimaryMobileNumber &&
                c.CreatedBy == dto.CreatedBy &&
                c.DebtorStatus == 1
            )), Times.Once);

            // Verify locality counter update
            _unitOfWorkMock.Verify(x => x.Locality.Update(It.Is<Locality>(l =>
                l.LocalityId == dto.LocalityId
            )), Times.Once);

            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);

            // Verify domain service validations
            _domainServiceMock.Verify(x => x.LocalityExists(dto.LocalityId), Times.Once);
            _domainServiceMock.Verify(x => x.CustomerTypeExists(dto.CustomerTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.ResidentTypeExists(dto.ResidentTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.GenderExists(dto.GenderId), Times.Once);
            _domainServiceMock.Verify(x => x.NationalityExists(dto.NationalityId), Times.Once);
            _domainServiceMock.Verify(x => x.IdentificationTypeExists(dto.IdentificationTypeId), Times.Once);
        }

        [Fact]
        public async Task CreateCustomer_WithValidIndividualNonResidentData_ShouldCreateCustomerSuccessfully()
        {
            // Arrange
            var dto = new IndividualResidentCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                ResidentTypeId = (int)ResidentTypeEnum.NON_RESIDENT,
                LocalityId = 1,
                CustomerCode = "IND001",
                TitleId = 1,
                SurName = "Doe",
                OtherNames = "John",
                DateOfBirth = DateTime.Now.AddYears(-30),
                TinNumber = "TIN123456",
                Picture = "profile.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "+233123456789",
                SecondaryMobileNumber = "+233987654321",
                OfficeNumber = "+233234567890",
                WhatsAppNumber = "+233123456789",
                EmailAddress = "john.doe@example.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@johndoe",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "ID123456",
                IdentificationImages = new string[]
                {
                    "id1.jpg",
                    "id2.jpg",
                    "id3.jpg"
                },
                Comments = "Individual registration",
                CreatedBy = "system",
                Expatriate = new IndividualExpatriateCustomerDto
                {
                    ResidentPermitNumber = string.Empty,
                    ResidentPermitDateIssued = DateTime.Now,
                    ResidentPermitExpiryDate = DateTime.Now
                },
                NonResident = new IndividualNonResidentCustomerDto
                {
                    ContactPerson_FullName = "Contact Person",
                    ContactPerson_PhoneNumber = "+233111222333",
                    ContactPerson_EmailAddress = "contact@example.com",
                    ContactPerson_Address = "Contact Address",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationTypeNumber = "CP123456",
                    ContactPerson_IdentificationImages = new string[]
                    {
                        "cp1.jpg",
                        "cp2.jpg"
                    }
                }
            };

            //various mock
            var mockLocality = new Locality(1, "T01", "TEST LOCALITY", "9T9", 1);
            var mockTitle = new Title(1, "Mr");
            var mockSocialMedia = new SocialMedia(1, "Facebook");

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Insert(It.IsAny<CustomerMaster>()));

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<int>()))
                 .ReturnsAsync(mockTitle);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync(mockTitle);

                _unitOfWorkMock.Setup(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null))
                    .ReturnsAsync(mockSocialMedia);

            _unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<int>()))
               .ReturnsAsync(mockLocality);


            _domainServiceMock.Setup(x => x.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(x => x.GetLocalityDetails(It.IsAny<int>()))
                .ReturnsAsync(mockLocality);

            // Act
            var result = await _sut.CreateCustomer(dto);

            // Assert
            result.Should().NotBeNull();
            result.IsSuccess.Should().BeTrue();
            result.SuccessResponse.Should().NotBeNull();
            result.SuccessResponse.CustomerCode.Should().NotBeNullOrEmpty();
            result.SuccessResponse.FullName.Should().Be("Mr John Doe");
            result.SuccessResponse.PhoneNumber.Should().Be(dto.PrimaryMobileNumber);

            // Verify repository calls
            _unitOfWorkMock.Verify(x => x.CustomerMaster.Insert(It.Is<CustomerMaster>(c =>
                c.CustomerTypeId == dto.CustomerTypeId &&
                c.ResidentTypeId == dto.ResidentTypeId &&
                c.LocalityId == dto.LocalityId &&
                c.SurName == dto.SurName &&
                c.OtherNames == dto.OtherNames &&
                c.EmailAddress == dto.EmailAddress &&
                c.PrimaryMobileNumber == dto.PrimaryMobileNumber &&
                c.CreatedBy == dto.CreatedBy &&
                c.DebtorStatus == 1
            )), Times.Once);

            // Verify locality counter update
            _unitOfWorkMock.Verify(x => x.Locality.Update(It.Is<Locality>(l =>
                l.LocalityId == dto.LocalityId
            )), Times.Once);

            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);

            // Verify domain service validations
            _domainServiceMock.Verify(x => x.LocalityExists(dto.LocalityId), Times.Once);
            _domainServiceMock.Verify(x => x.CustomerTypeExists(dto.CustomerTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.ResidentTypeExists(dto.ResidentTypeId), Times.Once);
            _domainServiceMock.Verify(x => x.GenderExists(dto.GenderId), Times.Once);
            _domainServiceMock.Verify(x => x.NationalityExists(dto.NationalityId), Times.Once);
            _domainServiceMock.Verify(x => x.IdentificationTypeExists(dto.IdentificationTypeId), Times.Once);
        }

        [Fact]
        public async Task GetIndividualCustomerDetails_WithValidCustomerCode_ReturnsCustomerDetails()
        {
            // Arrange
            var customerCode = "IND001";

            var expectedResponse = new IndividualResidentCustomerResponseDto
            {
                CustomerMasterId = 3,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                CustomerType = "Individual",
                ResidentTypeId = (int)ResidentTypeEnum.RESIDENT,
                ResidentType = "Resident",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 5,
                Title = "Col.",
                SurName = "Mensah",
                OtherNames = "Kwame",
                DateOfBirth = new DateTime(1978, 12, 15),
                TinNumber = "TIN789123456",
                Picture = "uploads/pictures/mensah_kwame.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 1,
                Nationality = "Ghanaian",
                PostalAddress = "PMB 15, Legon",
                ResidentialAddress = "24 University Avenue, East Legon",
                DigitalAddress = "GA-987-6543",
                PrimaryMobileNumber = "0244999888",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302444555",
                WhatsAppNumber = "0244999888",
                EmailAddress = "dr.mensah@email.com",
                SocialMediaTypeId = 1,
                SocialMediaPlatform = "LinkedIn",
                SocialMediaAccount = "drmensah",
                IdentificationTypeId = 1,
                IdentificationType = "National ID",
                IdentificationTypeNumber = "GHA-741852963-0",
                IdentificationImages = new string[] { "uploads/ids/mensah_id_front.jpg", "uploads/ids/mensah_id_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Medical professional",
                NonResident = new IndividualNonResidentCustomerResponseDto(),
                Expatriate = new IndividualExpatriateCustomerResponseDto()
            };


            var customer = CustomerMasterTestData.GetIndividualCustomer();

            // Setup repository mocks
            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            // Setup related entity mocks
            SetupRelatedEntityMocks(customer);
            
            // Act
            var result = await _sut.GetIndividualCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse, options =>
                options.Excluding(x => x.NonResident)
                       .Excluding(x => x.Expatriate));

            VerifyRepositoryCalls();
        }

        [Fact]
        public async Task GetIndividualCustomerDetails_WithInvalidCustomerCode_ReturnsNull()
        {
            // Arrange
            var invalidCustomerCode = "INVALID001";

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync((CustomerMaster)null!);

            // Act & Assert
            await Assert.ThrowsAsync<Exception>(() =>
                _sut.GetIndividualCustomerDetails(invalidCustomerCode))
                .ContinueWith(task =>
                {
                    task.Result.Message.Should().Be("Customer not found");
                });

            // Verify that only the initial customer lookup was performed
            _unitOfWorkMock.Verify(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null), Times.Once);
            //VerifyNoOtherRepositoryCalls();

            // Verify that no other repository methods were called
            _unitOfWorkMock.Verify(x => x.CustomerType.Get(It.IsAny<Expression<Func<CustomerType, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.ResidentType.Get(It.IsAny<Expression<Func<ResidentType, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.Gender.Get(It.IsAny<Expression<Func<Gender, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.Nationality.Get(It.IsAny<Expression<Func<Nationality, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.IdentificationType.Get(It.IsAny<Expression<Func<IdentificationType, bool>>>(), null), Times.Never);
            _unitOfWorkMock.Verify(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null), Times.Never);
        }

        [Fact]
        public async Task GetIndividualCustomerDetails_WithNonResidentType_ReturnsCustomerDetails()
        {
            // Arrange
            var customerCode = "IEXP002";

            var expectedResponse = new IndividualResidentCustomerResponseDto
            {
                CustomerMasterId = 5,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                CustomerType = "Individual",
                ResidentTypeId = (int)ResidentTypeEnum.NON_RESIDENT,
                ResidentType = "Non-Resident",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 3,
                Title = "Mrs.",
                SurName = "Zhang",
                OtherNames = "Wei",
                DateOfBirth = new DateTime(1982, 5, 18),
                TinNumber = "NRTIN123456",
                Picture = "uploads/pictures/zhang_wei.jpg",
                GenderId = 2,
                Gender = "Female",
                NationalityId = 2,
                Nationality = "Chinese",
                PostalAddress = "123 Huangpu Road, Shanghai",
                ResidentialAddress = "Unit 45, Tower B, Century Plaza, Shanghai",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+8613912345678",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = "+862161234567",
                WhatsAppNumber = "+8613912345678",
                EmailAddress = "wei.zhang@email.com",
                SocialMediaTypeId = 2,
                SocialMediaPlatform = "Facebook",
                SocialMediaAccount = "weizhang888",
                IdentificationTypeId = 2,
                IdentificationType = "Passport",
                IdentificationTypeNumber = "E12345678",
                IdentificationImages = new string[] { "uploads/ids/zhang_passport_front.jpg", "uploads/ids/zhang_passport_back.jpg" },
                DebtorStatus = "Active",
                Comments = "International investor",
                NonResident = new IndividualNonResidentCustomerResponseDto
                { 
                    ContactPerson_FullName = "John Owusu",
                    ContactPerson_PhoneNumber = "0244123456",
                    ContactPerson_EmailAddress = "j.owusu@email.com",
                    ContactPerson_Address = "15 Airport Road, Accra",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationType = "National ID",
                    ContactPerson_IdentificationTypeNumber = "GHA-123456789-0",
                    ContactPerson_IdentificationImages = new string[] { "uploads/ids/owusu_id_front.jpg", "uploads/ids/owusu_id_back.jpg" }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto()
            };


            var customer = CustomerMasterTestData.GetIndividualNonResidentCustomer();

            // Setup repository mocks
            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            // Setup related entity mocks
            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetIndividualCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse, options =>
                options.Excluding(x => x.NonResident)
                       .Excluding(x => x.Expatriate));

            VerifyRepositoryCalls();
        }

        [Fact]
        public async Task GetIndividualCustomerDetails_WithExpatriateType_ReturnsCustomerDetails()
        {
            // Arrange
            var customerCode = "IEXP003";
            var permitDateIssued = new DateTime(2023, 1, 15);
            var permitExpiryDate = new DateTime(2025, 1, 14);

            var expectedResponse = new IndividualResidentCustomerResponseDto
            {
                CustomerMasterId = 6,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                CustomerType = "Individual",
                ResidentTypeId = (int)ResidentTypeEnum.EXPATRIATE,
                ResidentType = "Expatriate",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 1, 
                Title = "Mr.",
                SurName = "Smith",
                OtherNames = "David James",
                DateOfBirth = new DateTime(1975, 8, 25),
                TinNumber = "EXPTIN789012",
                Picture = "uploads/pictures/smith_david.jpg",
                GenderId = 1, 
                Gender = "Male",
                NationalityId = 3,
                Nationality = "British",
                PostalAddress = "PMB KA 123, Airport",
                ResidentialAddress = "Villa 7, Cantonments",
                DigitalAddress = "GA-145-7890",
                PrimaryMobileNumber = "0244555666",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302789012",
                WhatsAppNumber = "0244555666",
                EmailAddress = "d.smith@email.com",
                SocialMediaTypeId = 1, 
                SocialMediaPlatform = "LinkedIn",
                SocialMediaAccount = "davidjsmith",
                IdentificationTypeId = 2, 
                IdentificationType = "Passport",
                IdentificationTypeNumber = "GBR123456",
                IdentificationImages = new string[] { "uploads/ids/smith_passport_front.jpg", "uploads/ids/smith_passport_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Technical Director at Global Mining Corp",
                NonResident = new IndividualNonResidentCustomerResponseDto(),
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = "GHA-RP-2023-123456",
                    ResidentPermitDateIssued = permitDateIssued,
                    ResidentPermitExpiryDate = permitExpiryDate
                },
            };


            var customer = CustomerMasterTestData.GetIndividualExpatriateCustomer();

            // Setup repository mocks
            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            // Setup related entity mocks
            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetIndividualCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse, options =>
                options.Excluding(x => x.NonResident)
                       .Excluding(x => x.Expatriate));

            VerifyRepositoryCalls();
        }


        [Fact]
        public async Task GetJointCustomerDetails_WithNonResidentType_ReturnsWithContactPerson()
        {
            // Arrange
            var customerCode = "JNTR001";
            var expectedResponse = new JointOwnershipCustomerResponseDto
            {
                CustomerMasterId = 7,
                CustomerTypeId = (int)CustomerTypeEnum.JOINT_OWNERSHIP,
                CustomerType = "Joint Ownership",
                ResidentTypeId = (int)ResidentTypeEnum.NON_RESIDENT,
                ResidentType = "Non-Resident",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 4,
                Title = "Mr. & Mrs.",
                SurName = "Kumar",
                OtherNames = "Raj & Priya",
                DateOfBirth = new DateTime(1980, 3, 15),
                TinNumber = "NRTIN456789",
                Picture = "uploads/pictures/kumar_family.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 4,
                Nationality = "Indian",
                PostalAddress = "45 MG Road, Mumbai 400001",
                ResidentialAddress = "Palm Grove Heights, Flat 2301, Mumbai",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+919876543210",
                SecondaryMobileNumber = "+919876543211",
                OfficeNumber = "+912222443355",
                WhatsAppNumber = "+919876543210",
                EmailAddress = "raj.kumar@email.com",
                SocialMediaTypeId = 2,
                SocialMediaPlatform = "Facebook",
                SocialMediaAccount = "rajkumar_family",
                IdentificationTypeId = 2,
                IdentificationType = "Passport",
                IdentificationTypeNumber = "Z12345678",
                IdentificationImages = new string[] { "uploads/ids/raj_passport_front.jpg", "uploads/ids/raj_passport_back.jpg"}, //, "uploads/ids/priya_passport_front.jpg", "uploads/ids/priya_passport_back.jpg" 
                DebtorStatus = "Active",
                Comments = "Non-resident investment couple",
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2005, 11, 23),
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = "Kwame Mensah",
                    ContactPerson_PhoneNumber = "0244789012",
                    ContactPerson_EmailAddress = "k.mensah@email.com",
                    ContactPerson_Address = "25 Independence Avenue, Accra",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationType = "National ID",
                    ContactPerson_IdentificationTypeNumber = "GHA-987654321-0",
                    ContactPerson_IdentificationImages = new string[] { "uploads/ids/mensah_id_front.jpg", "uploads/ids/mensah_id_back.jpg" }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = null,
                    ResidentPermitDateIssued = null,
                    ResidentPermitExpiryDate = null,
                }
            };

            var customer = CustomerMasterTestData.GetJointNonResidentCustomer();

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetJointCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse);
            VerifyRepositoryCalls();
        }

        [Fact]
        public async Task GetJointCustomerDetails_WithExpatriateType_ReturnsWithPermitDetails()
        {
            // Arrange
            var customerCode = "JNTE001";
            var permitDateIssued = new DateTime(2023, 3, 1);
            var permitExpiryDate = new DateTime(2025, 2, 28);

            var expectedResponse = new JointOwnershipCustomerResponseDto
            {
                CustomerMasterId = 8,
                CustomerTypeId = (int)CustomerTypeEnum.JOINT_OWNERSHIP,
                CustomerType = "Joint Ownership",
                ResidentTypeId = (int)ResidentTypeEnum.EXPATRIATE,
                ResidentType = "Expatriate",
                LocalityId = 2,
                Locality = "Test Locality One",
                CustomerCode = customerCode,
                TitleId = 4,
                Title = "Mr. & Mrs.",
                SurName = "Anderson",
                OtherNames = "Michael & Sarah",
                DateOfBirth = new DateTime(1978, 7, 12),
                TinNumber = "EXPTIN234567",
                Picture = "uploads/pictures/anderson_family.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 5,
                Nationality = "American",
                PostalAddress = "PMB CT 456, Cantonments",
                ResidentialAddress = "No. 8 Second Circular Road, Cantonments",
                DigitalAddress = "GA-567-8901",
                PrimaryMobileNumber = "0244111222",
                SecondaryMobileNumber = "0244333444",
                OfficeNumber = "0302456789",
                WhatsAppNumber = "0244111222",
                EmailAddress = "m.anderson@email.com",
                SocialMediaTypeId = 1,
                SocialMediaPlatform = "LinkedIn",
                SocialMediaAccount = "andersonfamily",
                IdentificationTypeId = 2,
                IdentificationType = "Passport",
                IdentificationTypeNumber = "USA123456789",
                IdentificationImages = new string[] { "uploads/ids/michael_passport_front.jpg", "uploads/ids/michael_passport_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Expatriate couple working in diplomatic mission",
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2008, 6, 14),
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = null,
                    ContactPerson_PhoneNumber = null,
                    ContactPerson_EmailAddress = null,
                    ContactPerson_Address = null,
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationType = string.Empty,
                    ContactPerson_IdentificationTypeNumber = null,
                    ContactPerson_IdentificationImages = new string[] {null!, null! }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = "GHA-RP-2023-789012",
                    ResidentPermitDateIssued = permitDateIssued,
                    ResidentPermitExpiryDate = permitExpiryDate
                }
            };

            var customer = CustomerMasterTestData.GetJointExpatriateCustomer();

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetJointCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse);
            VerifyRepositoryCalls();
        }


        [Fact]
        public async Task GetMultiCustomerDetails_WithValidCustomerCode_ReturnsMultiCustomerDetails()
        {
            // Arrange
            var customerCode = "MCU1001";
            var expectedResponse = new MultiOwnershipCustomerResponseDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.MULTI_OWNERSHIP,
                CustomerType = "Multi Ownership",
                ResidentTypeId = (int)ResidentTypeEnum.RESIDENT,
                ResidentType = "Resident",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 1,
                Title = "Mr.",
                SurName = "Smith",
                OtherNames = "John William",
                DateOfBirth = new DateTime(1980, 5, 15),
                TinNumber = "TIN123456789",
                Picture = "uploads/pictures/smith_john.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 1,
                Nationality = "Ghanaian",
                PostalAddress = "P.O. Box 1234, Accra",
                ResidentialAddress = "15 Independence Avenue, Airport Residential",
                DigitalAddress = "GA-145-2022",
                PrimaryMobileNumber = "0244123456",
                SecondaryMobileNumber = "0201234567",
                OfficeNumber = "0302123456",
                WhatsAppNumber = "0244123456",
                EmailAddress = "john.smith@email.com",
                SocialMediaTypeId = 1,
                SocialMediaPlatform = "LinkedIn",
                SocialMediaAccount = "johnsmith",
                IdentificationTypeId = 1,
                IdentificationType = "National ID",
                IdentificationTypeNumber = "GHA-123456789-0",
                IdentificationImages = new string[] { "uploads/ids/smith_front.jpg", "uploads/ids/smith_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Primary owner of the property",
                MaritalStatus = "Single",
                DateOfMarriage = null,
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = string.Empty,
                    ContactPerson_PhoneNumber = string.Empty,
                    ContactPerson_EmailAddress = string.Empty,
                    ContactPerson_Address = string.Empty,
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationType = string.Empty,
                    ContactPerson_IdentificationTypeNumber = string.Empty,
                    ContactPerson_IdentificationImages = new string[] { string.Empty, string.Empty }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = string.Empty,
                    ResidentPermitDateIssued = null,
                    ResidentPermitExpiryDate = null
                }
            };

            var customer = CustomerMasterTestData.GetPrimaryMultiOwnerCustomer();

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetMultiCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse);
           
            VerifyRepositoryCalls();
        }

        [Fact]
        public async Task GetMultiCustomerDetails_WithNonResidentType_ReturnsWithContactPerson()
        {
            // Arrange
            var customerCode = "MCU1003-02";
            var expectedResponse = new MultiOwnershipCustomerResponseDto
            {
                CustomerMasterId = 3,
                CustomerTypeId = (int)CustomerTypeEnum.MULTI_OWNERSHIP,
                CustomerType = "Multi Ownership",
                ResidentTypeId = (int)ResidentTypeEnum.NON_RESIDENT,
                ResidentType = "Non-Resident",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 1,
                Title = "Mr.",
                SurName = "Johnson",
                OtherNames = "Robert",
                DateOfBirth = new DateTime(1982, 3, 10),
                TinNumber = "TIN456789123",
                Picture = "uploads/pictures/johnson_robert.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 3,
                Nationality = "British",
                PostalAddress = "123 Oxford Street, London, UK",
                ResidentialAddress = "123 Oxford Street, London, UK",
                DigitalAddress = string.Empty,
                PrimaryMobileNumber = "+447123456789",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = string.Empty,
                WhatsAppNumber = "+447123456789",
                EmailAddress = "robert.johnson@email.com",
                SocialMediaTypeId = 1,
                SocialMediaPlatform = "LinkedIn",
                SocialMediaAccount = "robertjohnson",
                IdentificationTypeId = 2,
                IdentificationType = "Passport",
                IdentificationTypeNumber = "PP-GBR-789123",
                IdentificationImages = new string[] { "uploads/ids/johnson_passport_front.jpg", "uploads/ids/johnson_passport_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Non-resident co-owner",
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2015, 9, 15),
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = "James Wilson",
                    ContactPerson_PhoneNumber = "0244555666",
                    ContactPerson_EmailAddress = "james.wilson@email.com",
                    ContactPerson_Address = "10 High Street, East Legon",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationType = "National ID",
                    ContactPerson_IdentificationTypeNumber = "GHA-987654321-0",
                    ContactPerson_IdentificationImages = new string[] { "uploads/ids/wilson_id_front.jpg", "uploads/ids/wilson_id_back.jpg" }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = string.Empty,
                    ResidentPermitDateIssued = null,
                    ResidentPermitExpiryDate = null
                }
            };

            var customer = CustomerMasterTestData.GetMultiNonResidentCustomer();

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetMultiCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse);
            result.NonResident.Should().NotBeNull();

            VerifyRepositoryCalls();
        }

        [Fact]
        public async Task GetMultiCustomerDetails_WithExpatriateType_ReturnsWithPermitDetails()
        {
            // Arrange
            var customerCode = "MCU1002-01";
            var permitDateIssued = new DateTime(2023, 1, 1);
            var permitExpiryDate = new DateTime(2025, 12, 31);

            var expectedResponse = new MultiOwnershipCustomerResponseDto
            {
                CustomerMasterId = 2,
                CustomerTypeId = (int)CustomerTypeEnum.MULTI_OWNERSHIP,
                CustomerType = "Multi Ownership",
                ResidentTypeId = (int)ResidentTypeEnum.EXPATRIATE,
                ResidentType = "Expatriate",
                LocalityId = 1,
                Locality = "Test Locality",
                CustomerCode = customerCode,
                TitleId = 2,
                Title = "Dr.",
                SurName = "Chen",
                OtherNames = "Wei",
                DateOfBirth = new DateTime(1975, 8, 22),
                TinNumber = "TIN987654321",
                Picture = "uploads/pictures/chen_wei.jpg",
                GenderId = 1,
                Gender = "Male",
                NationalityId = 2,
                Nationality = "Chinese",
                PostalAddress = "PMB 45, Cantonments",
                ResidentialAddress = "25 Cantonments Road",
                DigitalAddress = "GA-167-3344",
                PrimaryMobileNumber = "0244987654",
                SecondaryMobileNumber = string.Empty,
                OfficeNumber = "0302987654",
                WhatsAppNumber = "0244987654",
                EmailAddress = "wei.chen@email.com",
                SocialMediaTypeId = 2,
                SocialMediaPlatform = "Facebook",
                SocialMediaAccount = "weichen",
                IdentificationTypeId = 2,
                IdentificationType = "Passport",
                IdentificationTypeNumber = "PP-CHN-G123456",
                IdentificationImages = new string[] { "uploads/ids/chen_passport_front.jpg", "uploads/ids/chen_passport_back.jpg" },
                DebtorStatus = "Active",
                Comments = "Expatriate co-owner",
                MaritalStatus = "Single",
                DateOfMarriage = new DateTime(2000, 12, 31),
                NonResident = new IndividualNonResidentCustomerResponseDto
                {
                    ContactPerson_FullName = string.Empty,
                    ContactPerson_PhoneNumber = string.Empty,
                    ContactPerson_EmailAddress = string.Empty,
                    ContactPerson_Address = string.Empty,
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationType = string.Empty,
                    ContactPerson_IdentificationTypeNumber = string.Empty,
                    ContactPerson_IdentificationImages = new string[] { string.Empty, string.Empty }
                },
                Expatriate = new IndividualExpatriateCustomerResponseDto
                {
                    ResidentPermitNumber = "RP2023001",
                    ResidentPermitDateIssued = permitDateIssued,
                    ResidentPermitExpiryDate = permitExpiryDate
                },
            };

            var customer = CustomerMasterTestData.GetMultiExpatriateCustomer();

            _unitOfWorkMock.Setup(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            SetupRelatedEntityMocks(customer);

            // Act
            var result = await _sut.GetMultiCustomerDetails(customerCode);

            // Assert
            result.Should().NotBeNull();
            result.Should().BeEquivalentTo(expectedResponse);
            result.Expatriate.Should().NotBeNull();

            VerifyRepositoryCalls();
        }



        private void SetupRelatedEntityMocks(CustomerMaster customer)
        {
            var customerTypeData = CustomerMasterTestData.GetSampleCustomerTypeData();
            _unitOfWorkMock.Setup(x => x.CustomerType.Get(It.IsAny<Expression<Func<CustomerType, bool>>>(), null))
                .ReturnsAsync((Expression<Func<CustomerType, bool>> predicate, object _) =>
                    customerTypeData.AsQueryable().FirstOrDefault(predicate));

            var titleData = CustomerMasterTestData.GetSampleTitleData();
            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Title, bool>> predicate, object _) =>
                    titleData.AsQueryable().FirstOrDefault(predicate));

            var residentTypeData = CustomerMasterTestData.GetSampleResidentTypeData();
            _unitOfWorkMock.Setup(x => x.ResidentType.Get(It.IsAny<Expression<Func<ResidentType, bool>>>(), null))
                .ReturnsAsync((Expression<Func<ResidentType, bool>> predicate, object _) =>
                    residentTypeData.AsQueryable().FirstOrDefault(predicate));

            var localityData = CustomerMasterTestData.GetSampleLocalityData();
            _unitOfWorkMock.Setup(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Locality, bool>> predicate, object _) =>
                    localityData.AsQueryable().FirstOrDefault(predicate));

            var genderData = CustomerMasterTestData.GetSampleGenderData();
            _unitOfWorkMock.Setup(x => x.Gender.Get(It.IsAny<Expression<Func<Gender, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Gender, bool>> predicate, object _) =>
                    genderData.AsQueryable().FirstOrDefault(predicate));

            var nationalityData = CustomerMasterTestData.GetSampleNationalityData();
            _unitOfWorkMock.Setup(x => x.Nationality.Get(It.IsAny<Expression<Func<Nationality, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Nationality, bool>> predicate, object _) =>
                    nationalityData.AsQueryable().FirstOrDefault(predicate));

            var identificationData = CustomerMasterTestData.GetSampleIdentificationTypeData();
            _unitOfWorkMock.Setup(x => x.IdentificationType.Get(It.IsAny<Expression<Func<IdentificationType, bool>>>(), null))
                .ReturnsAsync((Expression<Func<IdentificationType, bool>> predicate, object _) =>
                    identificationData.AsQueryable().FirstOrDefault(predicate));

            var socialMediaData = CustomerMasterTestData.GetSampleSocialMediaData();
            _unitOfWorkMock.Setup(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>(), null))
                .ReturnsAsync((Expression<Func<SocialMedia, bool>> predicate, object _) =>
                    socialMediaData.AsQueryable().FirstOrDefault(predicate));
        }

        private void VerifyRepositoryCalls()
        {
            _unitOfWorkMock.Verify(x => x.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.CustomerType.Get(It.IsAny<Expression<Func<CustomerType, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.ResidentType.Get(It.IsAny<Expression<Func<ResidentType, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.Gender.Get(It.IsAny<Expression<Func<Gender, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.Nationality.Get(It.IsAny<Expression<Func<Nationality, bool>>>(), null), Times.AtLeastOnce);
            _unitOfWorkMock.Verify(x => x.IdentificationType.Get(It.IsAny<Expression<Func<IdentificationType, bool>>>(), null), Times.AtLeastOnce);
        }

        //private void VerifyNoOtherRepositoryCalls()
        //{
        //    _unitOfWorkMock.Verify(x => x.CustomerType.Get(It.IsAny<Expression<Func<CustomerType, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.ResidentType.Get(It.IsAny<Expression<Func<ResidentType, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.Locality.Get(It.IsAny<Expression<Func<Locality, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.Gender.Get(It.IsAny<Expression<Func<Gender, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.Nationality.Get(It.IsAny<Expression<Func<Nationality, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.IdentificationType.Get(It.IsAny<Expression<Func<IdentificationType, bool>>>()), Times.Never);
        //    _unitOfWorkMock.Verify(x => x.SocialMedia.Get(It.IsAny<Expression<Func<SocialMedia, bool>>>()), Times.Never);
        //}



        [Fact]
        public async Task UpdateCustomer_WithValidProspectiveData_ShouldUpdateSuccessfully()
        {
            var updateDto = new UpdateProspectiveCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.PROSPECTIVE,
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = "PROS001",
                TitleId = 2,
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

            var titleData = CustomerMasterTestData.GetSampleTitleData();
            var existingCustomer = CustomerMasterTestData.GetProspectiveCustomer();

            // Mock domain service validation
            _domainServiceMock.Setup(d => d.CustomerExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);


            // Mock the UpdateProspectiveAsync method
            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(existingCustomer);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Title, bool>> predicate, object _) =>
                    titleData.AsQueryable().FirstOrDefault(predicate));

            _unitOfWorkMock.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _sut.UpdateCustomer(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("PROS001", result.SuccessResponse.CustomerCode);
            Assert.Contains("John Smith", result.SuccessResponse.FullName);
            Assert.Equal("0244111222", result.SuccessResponse.PhoneNumber);

            // Verify method calls
            //_domainServiceMock.Verify(d => d.CustomerExists(It.IsAny<int>()), Times.AtLeastOnce);
            _domainServiceMock.Verify(d => d.CustomerTypeExists(It.IsAny<int>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task UpdateCustomer_WithValidCompanyData_ShouldUpdateSuccessfully()
        {
            // Arrange
            var updateDto = new UpdateCompanyCustomerDto
            {
                CustomerMasterId = 2,
                CustomerTypeId = (int)CustomerTypeEnum.COMPANY,
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = "COMP001",
                CompanyName = "Global Tech Ltd",
                CompanyAddress = "123 Tech Street",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "0244111222",
                SecondaryMobileNumber = "0244333444",
                OfficeNumber = "0302555666",
                WhatsAppNumber = "0244111222",
                EmailAddress = "info@globaltech.com",
                BusinessRegistrationNumber = "BUS123456789",
                TinNumber = "TIN987654321",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "globaltechgh",
                NationalityId = 1,
                Comments = "Tech company update",
                IdentificationImages = new string[] { "cert_incorporation.jpg", "cert_commence.jpg" },
                ContactPerson = new CompanyContactPerson
                {
                    ContactPerson_FullName = "John Contact",
                    ContactPerson_PhoneNumber = "0244777888",
                    ContactPerson_EmailAddress = "john@globaltech.com",
                    ContactPerson_Address = "123 Tech Street",
                    ContactPerson_IdentificationTypeId = 1,
                    ContactPerson_IdentificationTypeNumber = "GHA-123456789",
                    ContactPerson_IdentificationImages = new string[] { "contact_id_front.jpg", "contact_id_back.jpg" }
                },
                ModifiedBy = "system"
            };

            var existingCustomer = CustomerMasterTestData.GetCompanyCustomer();


            // Mock domain service validation
            _domainServiceMock.Setup(d => d.CustomerExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);



            // Mock the repository methods
            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(existingCustomer);


            _unitOfWorkMock.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Mock event dispatcher
            //_mockEventDispatcher.Setup(d => d.DispatchAsync(It.IsAny<IDomainEvent>()))
            //    .Returns(Task.CompletedTask);

            // Act
            var result = await _sut.UpdateCustomer(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("COMP001", result.SuccessResponse.CustomerCode);
            Assert.Equal("Global Tech Ltd", result.SuccessResponse.FullName!.Trim());
            Assert.Equal("0244111222", result.SuccessResponse.PhoneNumber);

            // Verify method calls
            _domainServiceMock.Verify(d => d.CustomerTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.ResidentTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.LocalityExists(It.IsAny<int>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.Complete(), Times.Once);
            //_mockEventDispatcher.Verify(d => d.DispatchAsync(It.IsAny<IDomainEvent>()), Times.AtLeastOnce);
        }

       

        [Fact]
        public async Task UpdateCustomer_WithValidIndividualResidentData_ShouldUpdateSuccessfully()
        {
            // Arrange
            var updateDto = new UpdateIndividualResidentCustomerDto
            {
                CustomerMasterId = 3,
                CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL,
                ResidentTypeId = 3,
                LocalityId = 1,
                CustomerCode = "IND001",
                TitleId = 1,
                SurName = "Johnson",
                OtherNames = "Peter",
                DateOfBirth = new DateTime(1980, 1, 1),
                TinNumber = "TIN789012",
                Picture = "profile.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box 123",
                ResidentialAddress = "15 Independence Ave",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "0244555666",
                SecondaryMobileNumber = "0244777888",
                OfficeNumber = "0302999000",
                WhatsAppNumber = "0244555666",
                EmailAddress = "peter.johnson@email.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "pjohnson",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "GHA-123456789-0",
                IdentificationImages = new string[] { "id_front.jpg", "id_back.jpg" },
                Comments = "Individual resident update",

                // Expatriate details (if applicable)
                Expatriate = new IndividualExpatriateCustomerDto
                {
                    ResidentPermitNumber = "",
                    ResidentPermitDateIssued = DateTime.MinValue,
                    ResidentPermitExpiryDate = DateTime.MinValue
                },

                // Non-resident details (if applicable)
                NonResident = new IndividualNonResidentCustomerDto
                {
                    ContactPerson_FullName = "",
                    ContactPerson_PhoneNumber = "",
                    ContactPerson_EmailAddress = "",
                    ContactPerson_Address = "",
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationTypeNumber = "",
                    ContactPerson_IdentificationImages = new string[] { }
                },

                ModifiedBy = "system"
            };

            var titleData = CustomerMasterTestData.GetSampleTitleData();
            var existingCustomer = CustomerMasterTestData.GetIndividualCustomer();


            // Mock domain service validation
            _domainServiceMock.Setup(d => d.CustomerExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);

            // Mock repository methods
            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(existingCustomer);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Title, bool>> predicate, object _) =>
                    titleData.AsQueryable().FirstOrDefault(predicate));

            _unitOfWorkMock.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Mock event dispatcher
            //_mockEventDispatcher.Setup(d => d.DispatchAsync(It.IsAny<IDomainEvent>()))
            //    .Returns(Task.CompletedTask);

            // Act
            var result = await _sut.UpdateCustomer(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("IND001", result.SuccessResponse.CustomerCode);
            Assert.Contains("Peter Johnson", result.SuccessResponse.FullName);
            Assert.Equal("0244555666", result.SuccessResponse.PhoneNumber);

            // Verify method calls
            _domainServiceMock.Verify(d => d.CustomerTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.ResidentTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.LocalityExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.TitleExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.IdentificationTypeExists(It.IsAny<int>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.Complete(), Times.Once);
            //_mockEventDispatcher.Verify(d => d.DispatchAsync(It.IsAny<IDomainEvent>()), Times.AtLeastOnce);
        }

        [Fact]
        public async Task UpdateCustomer_WithValidJointOwnershipData_ShouldUpdateSuccessfully()
        {
            // Arrange
            var updateDto = new UpdateJointOwnershipCustomerDto
            {
                CustomerMasterId = 1,
                CustomerTypeId = (int)CustomerTypeEnum.JOINT_OWNERSHIP,
                ResidentTypeId = (int)ResidentTypeEnum.RESIDENT,
                LocalityId = 1,
                CustomerCode = "JNT001",
                TitleId = 4, // Mr. & Mrs.
                SurName = "Addo-Mensah",
                OtherNames = "Mary & Samuel",
                DateOfBirth = new DateTime(1980, 1, 1),
                TinNumber = "TIN456123789",
                Picture = "uploads/pictures/addo_family.jpg",
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box AN 7890, Accra North",
                ResidentialAddress = "15 Palm Street, Dzorwulu",
                DigitalAddress = "GS-432-8765",
                PrimaryMobileNumber = "0244777666",
                SecondaryMobileNumber = "0244888999",
                OfficeNumber = "0244888999",
                WhatsAppNumber = "0244777666",
                EmailAddress = "addo.family@email.com",
                SocialMediaTypeId = 2,
                SocialMediaAccount = "addofamily",
                IdentificationTypeId = 1,
                IdentificationTypeNumber = "GHA-123456789-0",
                IdentificationImages = new string[]{ "uploads/ids/addo_mary_id_front.jpg", "uploads/ids/addo_mary_id_bank.jpg", },
                MaritalStatus = "Married",
                DateOfMarriage = new DateTime(2010, 6, 15),
                Comments = "Joint ownership update",

                // Expatriate details (if applicable)
                Expatriate = new IndividualExpatriateCustomerDto
                {
                    ResidentPermitNumber = "",
                    ResidentPermitDateIssued = null,
                    ResidentPermitExpiryDate = null
                },

                // Non-resident details (if applicable)
                NonResident = new IndividualNonResidentCustomerDto
                {
                    ContactPerson_FullName = "",
                    ContactPerson_PhoneNumber = "",
                    ContactPerson_EmailAddress = "",
                    ContactPerson_Address = "",
                    ContactPerson_IdentificationTypeId = 0,
                    ContactPerson_IdentificationTypeNumber = "",
                    ContactPerson_IdentificationImages = new string[] { }
                },

                ModifiedBy = "system"
            };

            var titleData = CustomerMasterTestData.GetSampleTitleData();
            var existingCustomer = CustomerMasterTestData.GetJointCustomer();

            // Mock domain service validation
            _domainServiceMock.Setup(d => d.CustomerExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.CustomerTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.ResidentTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.LocalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.TitleExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.GenderExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.NationalityExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.IdentificationTypeExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            _domainServiceMock.Setup(d => d.SocialMediaExists(It.IsAny<int>()))
                .ReturnsAsync(true);
            

            // Mock repository methods
            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(existingCustomer);

            _unitOfWorkMock.Setup(x => x.Title.Get(It.IsAny<Expression<Func<Title, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Title, bool>> predicate, object _) =>
                    titleData.AsQueryable().FirstOrDefault(predicate));

            _unitOfWorkMock.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Mock event dispatcher
            //_mockEventDispatcher.Setup(d => d.DispatchAsync(It.IsAny<IDomainEvent>()))
            //    .Returns(Task.CompletedTask);

            // Act
            var result = await _sut.UpdateCustomer(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("JNT001", result.SuccessResponse.CustomerCode);
            Assert.NotEqual("Samuel & Mary Addo", result.SuccessResponse.FullName);
            Assert.Equal("Mr. & Mrs. Mary & Samuel Addo-Mensah", result.SuccessResponse.FullName);
            Assert.NotEqual("0244999888", result.SuccessResponse.PhoneNumber);

            // Verify method calls
            _domainServiceMock.Verify(d => d.CustomerTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.ResidentTypeExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.LocalityExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.TitleExists(It.IsAny<int>()), Times.Once);
            _domainServiceMock.Verify(d => d.IdentificationTypeExists(It.IsAny<int>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.Complete(), Times.Once);
            //_mockEventDispatcher.Verify(d => d.DispatchAsync(It.IsAny<IDomainEvent>()), Times.AtLeastOnce);
        }

        [Fact]
        public async Task StopCustomerDebitAsync_WithValidData_ShouldUpdateSuccessfully()
        {
            // Arrange
            var stopDebitDto = new StopDebitRequestDto
            {
                CustomerCode = "IND001",
                PropertyNumber = "PROP001",
                DebtorStatus = 90,
                Reasons = "Unit Testing Stop Debit Request",
                ActionBy = "system"
            };

            var customer = CustomerMasterTestData.GetIndividualCustomer();
            //customer.CustomerCode = "IND001";

            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync(customer);

            _unitOfWorkMock.Setup(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()));
            _unitOfWorkMock.Setup(u => u.StopDebit.Insert(It.IsAny<StopDebit>()));

            _unitOfWorkMock.Setup(u => u.Complete()).ReturnsAsync(1);

            // Act
            var result = await _sut.StopCustomerDebitAsync(stopDebitDto);

            // Assert
            Assert.Equal(200, result);
            _unitOfWorkMock.Verify(u => u.CustomerMaster.Update(It.IsAny<CustomerMaster>()), Times.Once);
            _unitOfWorkMock.Verify(u => u.StopDebit.Insert(It.IsAny<StopDebit>()), Times.Once);

        }

        [Fact]
        public async Task StopCustomerDebitAsync_WithNullRequest_ShouldReturn400()
        {
            // Act
            var result = await _sut.StopCustomerDebitAsync(null!);

            // Assert
            Assert.Equal(400, result);
        }

        [Fact]
        public async Task StopCustomerDebitAsync_WithInvalidCustomerCode_ShouldReturn404()
        {
            // Arrange
            var stopDebitDto = new StopDebitRequestDto
            {
                CustomerCode = "INVALID001",
                PropertyNumber = "PROP001",
                DebtorStatus = 90,
                Reasons = "Unit Testing invalid stop debit request",
                ActionBy = "system"
            };

            _unitOfWorkMock.Setup(u => u.CustomerMaster.Get(It.IsAny<Expression<Func<CustomerMaster, bool>>>(), null))
                .ReturnsAsync((CustomerMaster)null!);

            // Act
            var result = await _sut.StopCustomerDebitAsync(stopDebitDto);

            // Assert
            Assert.Equal(404, result);
        }


    }
}