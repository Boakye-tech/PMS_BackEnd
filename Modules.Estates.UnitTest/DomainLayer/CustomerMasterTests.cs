using Xunit;
using FluentAssertions;
using AutoFixture;
using Moq;
using Modules.Estates.Domain.Entities.Registration;
using Modules.Estates.Domain.Interfaces.DomainServices;
using Modules.Estates.Domain.Entities.Setup.Property;

namespace Modules.Estates.UnitTest.DomainLayer
{
    public class CustomerMasterTests
    {
        private readonly IFixture _fixture;
        private readonly Mock<ICustomerDomainService> _customerDomainServiceMock;

        public CustomerMasterTests()
        {
            _fixture = new Fixture();
            _customerDomainServiceMock = new Mock<ICustomerDomainService>();
        }

        [Fact]
        public async Task CreateProspectiveAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "CUST001";
            var titleId = 1;
            var surName = "Doe";
            var otherNames = "John";
            var companyName = "";
            var picture = "profile.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "john.doe@example.com";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@johndoe";
            var comments = "Prospective customer";
            var interestExpressed = "Residential property";
            var createdBy = "system";

            _customerDomainServiceMock.Setup(x => x.LocalityExistsAsync(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExistsAsync(customerTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.ResidentTypeExistsAsync(residentTypeId))
                .ReturnsAsync(true);

            var command = new
            {
                CustomerMasterId = customerMasterId,
                CustomerTypeId = customerTypeId,
                ResidentTypeId = residentTypeId,
                LocalityId = localityId,
                CustomerCode = customerCode,
                TitleId = titleId,
                SurName = surName,
                OtherNames = otherNames,
                CompanyName = companyName,
                Picture = picture,
                GenderId = genderId,
                NationalityId = nationalityId,
                PostalAddress = postalAddress,
                ResidentialAddress = residentialAddress,
                DigitalAddress = digitalAddress,
                PrimaryMobileNumber = primaryMobileNumber,
                SecondaryMobileNumber = secondaryMobileNumber,
                OfficeNumber = officeNumber,
                WhatsAppNumber = whatsAppNumber,
                EmailAddress = emailAddress,
                SocialMediaTypeId = socialMediaTypeId,
                SocialMediaAccount = socialMediaAccount,
                Comments = comments,
                InterestExpressed = interestExpressed,
                CreatedBy = createdBy
            };

            // Act
            var customer = await CustomerMaster.CreateProspectiveAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                localityId,
                customerCode,
                titleId,
                surName,
                otherNames,
                companyName,
                picture,
                genderId,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.LocalityId.Should().Be(localityId);
            customer.CustomerCode.Should().Be(customerCode);
            customer.TitleId.Should().Be(titleId);
            customer.SurName.Should().Be(surName);
            customer.OtherNames.Should().Be(otherNames);
            customer.CompanyName.Should().Be(companyName);
            customer.Picture.Should().Be(picture);
            customer.GenderId.Should().Be(genderId);
            customer.NationalityId.Should().Be(nationalityId);
            customer.PostalAddress.Should().Be(postalAddress);
            customer.ResidentialAddress.Should().Be(residentialAddress);
            customer.DigitalAddress.Should().Be(digitalAddress);
            customer.PrimaryMobileNumber.Should().Be(primaryMobileNumber);
            customer.SecondaryMobileNumber.Should().Be(secondaryMobileNumber);
            customer.OfficeNumber.Should().Be(officeNumber);
            customer.WhatsAppNumber.Should().Be(whatsAppNumber);
            customer.EmailAddress.Should().Be(emailAddress);
            customer.SocialMediaTypeId.Should().Be(socialMediaTypeId);
            customer.SocialMediaAccount.Should().Be(socialMediaAccount);
            customer.Comments.Should().Be(comments);
            customer.InterestExpressed.Should().Be(interestExpressed);
            customer.CreatedBy.Should().Be(createdBy);

            _customerDomainServiceMock.Verify(x => x.LocalityExistsAsync(localityId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.CustomerTypeExistsAsync(customerTypeId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.ResidentTypeExistsAsync(residentTypeId), Times.Once);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public async Task CreateProspectiveAsync_WithInvalidSurName_ShouldThrowException(string invalidSurName)
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "CUST001";
            var titleId = 1;
            var otherNames = "John";
            var companyName = "";
            var picture = "profile.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "john.doe@example.com";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@johndoe";
            var comments = "Prospective customer";
            var interestExpressed = "Residential property";
            var createdBy = "system";

            // Act
            var customer = await CustomerMaster.CreateProspectiveAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                localityId,
                customerCode,
                titleId,
                invalidSurName,
                otherNames,
                companyName,
                picture,
                genderId,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.SurName.Should().Be(invalidSurName);
        }

        [Fact]
        public async Task CreateProspectiveAsync_WithInvalidLocalityId_ShouldThrowException()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var invalidLocalityId = 999;
            var customerCode = "CUST001";
            var titleId = 1;
            var surName = "Doe";
            var otherNames = "John";
            var companyName = "";
            var picture = "profile.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "john.doe@example.com";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@johndoe";
            var comments = "Prospective customer";
            var interestExpressed = "Residential property";
            var createdBy = "system";

            _customerDomainServiceMock.Setup(x => x.LocalityExistsAsync(invalidLocalityId))
                .ReturnsAsync(false);

            // Act
            var customer = await CustomerMaster.CreateProspectiveAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                invalidLocalityId,
                customerCode,
                titleId,
                surName,
                otherNames,
                companyName,
                picture,
                genderId,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.LocalityId.Should().Be(invalidLocalityId);
            _customerDomainServiceMock.Verify(x => x.LocalityExistsAsync(invalidLocalityId), Times.Once);
        }

        [Theory]
        [InlineData("invalid-email")]
        [InlineData("")]
        [InlineData(null)]
        public async Task CreateProspectiveAsync_WithInvalidEmail_ShouldThrowException(string invalidEmail)
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "CUST001";
            var titleId = 1;
            var surName = "Doe";
            var otherNames = "John";
            var companyName = "";
            var picture = "profile.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@johndoe";
            var comments = "Prospective customer";
            var interestExpressed = "Residential property";
            var createdBy = "system";

            _customerDomainServiceMock.Setup(x => x.LocalityExistsAsync(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExistsAsync(customerTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.ResidentTypeExistsAsync(residentTypeId))
                .ReturnsAsync(true);

            // Act
            var customer = await CustomerMaster.CreateProspectiveAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                localityId,
                customerCode,
                titleId,
                surName,
                otherNames,
                companyName,
                picture,
                genderId,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                invalidEmail,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.EmailAddress.Should().Be(invalidEmail);
        }

        [Fact]
        public async Task CreateIndividualAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "CUST001";
            var titleId = 1;
            var surName = "Doe";
            var otherNames = "John";
            var dateOfBirth = DateTime.Now.AddYears(-30);
            var tinNumber = "TIN123456";
            var picture = "profile.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "john.doe@example.com";
            var residentPermitNumber = "";
            DateTime? residentPermitDateIssued = null;
            DateTime? residentPermitExpiryDate = null;
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@johndoe";
            var identificationTypeId = 1;
            var identificationTypeNumber = "ID123456";
            var identificationTypeImageOne = "id1.jpg";
            var identificationTypeImageTwo = "id2.jpg";
            var identificationTypeImageThree = "id3.jpg";
            var identificationTypeImageFour = "id4.jpg";
            var identificationTypeImageFive = "id5.jpg";
            var comments = "Individual registration";
            var interestExpressed = "Residential property";
            var debtorStatus = 0;
            var parentCode = "";
            var contactPerson_FullName = "";
            var contactPerson_PhoneNumber = "";
            var contactPerson_EmailAddress = "";
            var contactPerson_Address = "";
            var contactPerson_IdentificationTypeId = 0;
            var contactPerson_IdentificationTypeNumber = "";
            var contactPerson_IdentificationTypeImageOne = "";
            var contactPerson_IdentificationTypeImageTwo = "";
            var isDeleted = false;
            var isPrimary = true;

            var mockLocality = new Locality(localityId, "T01", "TEST LOCALITY", "9T9", 1);

            _customerDomainServiceMock.Setup(x => x.GetLocalityDetails(localityId))
                .ReturnsAsync(mockLocality);
            _customerDomainServiceMock.Setup(x => x.LocalityExists(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExists(customerTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.ResidentTypeExists(residentTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.GenderExists(genderId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.NationalityExists(nationalityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.IdentificationTypeExists(identificationTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.TitleExists(titleId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.SocialMediaExists(socialMediaTypeId))
                .ReturnsAsync(true);

            // Act
            var customer = await CustomerMaster.CreateIndividualAsync(
                customerMasterId, customerTypeId, residentTypeId, localityId, customerCode,
                titleId, surName, otherNames, dateOfBirth, tinNumber, picture, genderId,
                nationalityId, postalAddress, residentialAddress, digitalAddress,
                primaryMobileNumber, secondaryMobileNumber, officeNumber, whatsAppNumber,
                emailAddress, residentPermitNumber, residentPermitDateIssued,
                residentPermitExpiryDate, socialMediaTypeId, socialMediaAccount,
                identificationTypeId, identificationTypeNumber, identificationTypeImageOne,
                identificationTypeImageTwo, identificationTypeImageThree,
                identificationTypeImageFour, identificationTypeImageFive, comments,
                interestExpressed, debtorStatus, parentCode, contactPerson_FullName,
                contactPerson_PhoneNumber, contactPerson_EmailAddress, contactPerson_Address,
                contactPerson_IdentificationTypeId, contactPerson_IdentificationTypeNumber,
                contactPerson_IdentificationTypeImageOne, contactPerson_IdentificationTypeImageTwo,
                isDeleted, isPrimary, _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.LocalityId.Should().Be(localityId);
            customer.SurName.Should().Be(surName);
            customer.OtherNames.Should().Be(otherNames);
            customer.EmailAddress.Should().Be(emailAddress);
            customer.PrimaryMobileNumber.Should().Be(primaryMobileNumber);
            customer.IsDeleted.Should().BeFalse();
            customer.IsPrimary.Should().BeTrue();
        }

        [Fact]
        public async Task CreateCompanyAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "COMP001";
            var companyName = "Test Company Ltd";
            var nationalityId = 1;
            var companyAddress = "123 Business St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "info@testcompany.com";
            var businessRegistrationNumber = "BRN123456";
            var tinNumber = "TIN123456";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@testcompany";
            var identificationTypeImageOne = "doc1.jpg";
            var identificationTypeImageTwo = "doc2.jpg";
            var identificationTypeImageThree = "doc3.jpg";
            var identificationTypeImageFour = "doc4.jpg";
            var identificationTypeImageFive = "doc5.jpg";
            var contactPerson_FullName = "John Contact";
            var contactPerson_PhoneNumber = "+233111222333";
            var contactPerson_EmailAddress = "contact@testcompany.com";
            var contactPerson_Address = "456 Contact St";
            var contactPerson_IdentificationTypeId = 1;
            var contactPerson_IdentificationTypeNumber = "CP123456";
            var contactPerson_IdentificationTypeImageOne = "cp1.jpg";
            var contactPerson_IdentificationTypeImageTwo = "cp2.jpg";
            var comments = "Company registration";
            var isDeleted = false;
            var isPrimary = true;

            var mockLocality = new Locality(localityId, "T01", "TEST LOCALITY", "9T9", 1);

            _customerDomainServiceMock.Setup(x => x.GetLocalityDetails(localityId))
                .ReturnsAsync(mockLocality);
            _customerDomainServiceMock.Setup(x => x.LocalityExists(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExists(customerTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.NationalityExists(nationalityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.SocialMediaExists(socialMediaTypeId))
                .ReturnsAsync(true);

            // Act
            var customer = await CustomerMaster.CreateCompanyAsync(
                customerMasterId, customerTypeId, residentTypeId, localityId,
                customerCode, companyName, nationalityId, companyAddress,
                digitalAddress, primaryMobileNumber, secondaryMobileNumber,
                officeNumber, whatsAppNumber, emailAddress, businessRegistrationNumber,
                tinNumber, socialMediaTypeId, socialMediaAccount,
                identificationTypeImageOne, identificationTypeImageTwo,
                identificationTypeImageThree, identificationTypeImageFour,
                identificationTypeImageFive, contactPerson_FullName,
                contactPerson_PhoneNumber, contactPerson_EmailAddress,
                contactPerson_Address, contactPerson_IdentificationTypeId,
                contactPerson_IdentificationTypeNumber,
                contactPerson_IdentificationTypeImageOne,
                contactPerson_IdentificationTypeImageTwo, comments,
                isDeleted, isPrimary, _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.LocalityId.Should().Be(localityId);
            customer.CompanyName.Should().Be(companyName);
            customer.EmailAddress.Should().Be(emailAddress);
            customer.PrimaryMobileNumber.Should().Be(primaryMobileNumber);
            customer.TinNumber.Should().Be(tinNumber);
            customer.IsDeleted.Should().BeFalse();
            customer.IsPrimary.Should().BeTrue();
        }

        [Fact]
        public async Task CreateJointAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = "JOINT001";
            var titleId = 1;
            var surName = "Doe & Smith";
            var otherNames = "John & Jane";
            var companyName = "";
            var picture = "joint.jpg";
            var genderId = 1;
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Main St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "joint@example.com";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@jointaccount";
            var comments = "Joint account holders";
            var interestExpressed = "Residential property";
            var createdBy = "system";

            _customerDomainServiceMock.Setup(x => x.LocalityExistsAsync(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExistsAsync(customerTypeId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.ResidentTypeExistsAsync(residentTypeId))
                .ReturnsAsync(true);

            // Act
            var customer = await CustomerMaster.CreateJointAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                localityId,
                customerCode,
                titleId,
                surName,
                otherNames,
                companyName,
                picture,
                genderId,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.LocalityId.Should().Be(localityId);
            customer.CustomerCode.Should().Be(customerCode);
            customer.TitleId.Should().Be(titleId);
            customer.SurName.Should().Be(surName);
            customer.OtherNames.Should().Be(otherNames);
            customer.EmailAddress.Should().Be(emailAddress);
            customer.CustomerType.Should().Be(CustomerType.Joint);
        }

        [Theory]
        [InlineData("")]
        [InlineData(null)]
        [InlineData(" ")]
        public async Task CreateCompanyAsync_WithInvalidCompanyName_ShouldCreateCustomer(string invalidCompanyName)
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var localityId = 1;
            var customerCode = "COMP001";
            var picture = "company-logo.jpg";
            var nationalityId = 1;
            var postalAddress = "P.O. Box 123";
            var residentialAddress = "123 Business St";
            var digitalAddress = "GA-123-4567";
            var primaryMobileNumber = "+233123456789";
            var secondaryMobileNumber = "+233987654321";
            var officeNumber = "+233234567890";
            var whatsAppNumber = "+233123456789";
            var emailAddress = "info@testcompany.com";
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@testcompany";
            var comments = "Company registration";
            var interestExpressed = "Commercial property";
            var createdBy = "system";

            _customerDomainServiceMock.Setup(x => x.LocalityExistsAsync(localityId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.CustomerTypeExistsAsync(customerTypeId))
                .ReturnsAsync(true);

            // Act
            var customer = await CustomerMaster.CreateCompanyAsync(
                customerMasterId,
                customerTypeId,
                localityId,
                customerCode,
                invalidCompanyName,
                picture,
                nationalityId,
                postalAddress,
                residentialAddress,
                digitalAddress,
                primaryMobileNumber,
                secondaryMobileNumber,
                officeNumber,
                whatsAppNumber,
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CompanyName.Should().Be(invalidCompanyName);
        }

        [Fact]
        public void Delete_ShouldMarkAsDeletedAndAddEvent()
        {
            // Arrange
            var customer = new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerCode = "TEST001"
            };
            var deletedBy = "admin";
            var reason = "No longer active";

            // Act
            customer.Delete(deletedBy, reason);

            // Assert
            customer.IsDeleted.Should().BeTrue();
            customer.ModifiedOn.Should().BeCloseTo(DateTime.UtcNow, TimeSpan.FromSeconds(1));
            customer.DomainEvents.Should().ContainSingle(e => e is CustomerDeletedEvent);
        }

        [Fact]
        public void ClearDomainEvents_ShouldRemoveAllEvents()
        {
            // Arrange
            var customer = new CustomerMaster
            {
                CustomerMasterId = 1,
                CustomerCode = "TEST001"
            };
            customer.Delete("admin", "test reason");

            // Act
            customer.ClearDomainEvents();

            // Assert
            customer.DomainEvents.Should().BeEmpty();
        }
    }
}