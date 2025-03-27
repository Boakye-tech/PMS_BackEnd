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
                DebtorStatus = 1,
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




    }
}