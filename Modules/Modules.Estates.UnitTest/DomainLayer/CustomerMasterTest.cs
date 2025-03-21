using Xunit;
using FluentAssertions;
using AutoFixture;
using Moq;
using Modules.Estates.Domain.Entities.Registration;
using Modules.Estates.Domain.Interfaces.DomainServices;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Customer;
using Modules.Estates.Application.Enums;

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
            string customerCode = string.Empty;
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
            var createdBy = "32ea339b-75f2-4f57-8153-915f127a9612";
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
            _customerDomainServiceMock.Setup(x => x.TitleExists(titleId))
                .ReturnsAsync(true);
            _customerDomainServiceMock.Setup(x => x.SocialMediaExists(socialMediaTypeId))
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
                emailAddress,
                socialMediaTypeId,
                socialMediaAccount,
                comments,
                interestExpressed,
                createdBy,
                _customerDomainServiceMock.Object
            );

            // Assert

            Assert.NotEmpty(customer.CustomerCode!); // Ensures a CustomerCode is generated
            Assert.StartsWith("T01", customer.CustomerCode); // Checks expected format

            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.LocalityId.Should().Be(localityId);
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

            _customerDomainServiceMock.Verify(x => x.LocalityExists(localityId), Times.AtLeastOnce);
            _customerDomainServiceMock.Verify(x => x.CustomerTypeExists(customerTypeId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.ResidentTypeExists(residentTypeId), Times.Once);

            _customerDomainServiceMock.Verify(x => x.GenderExists(genderId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.NationalityExists(nationalityId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.TitleExists(titleId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.SocialMediaExists(genderId), Times.Once);
        }


        [Fact]
        public async Task CreateIndividualAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = (int)CustomerTypeEnum.INDIVIDUAL;
            var residentTypeId = (int)ResidentTypeEnum.RESIDENT;
            var localityId = 1;
            var customerCode = string.Empty;
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

            var mockLocality = new Locality(localityId, "C02", "TEST LOCALITY", "4L4", 1);

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
            Assert.NotEmpty(customer.CustomerCode!); // Ensures a CustomerCode is generated
            Assert.StartsWith("4L4", customer.CustomerCode); // Checks expected format


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
            var customerTypeId = (int)CustomerTypeEnum.INDIVIDUAL;
            var residentTypeId = 0;
            var localityId = 1;
            var customerCode = string.Empty;
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

            var mockLocality = new Locality(localityId, "C01", "COMPANY LOCALITY", "3C3", 1);

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
            Assert.NotEmpty(customer.CustomerCode!); // Ensures a CustomerCode is generated
            Assert.StartsWith("3C3", customer.CustomerCode); // Checks expected format

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
            customer.ContactPerson_FullName.Should().Be(contactPerson_FullName);
        }


        [Fact]
        public async Task CreateJointAsync_WithValidData_ShouldCreateCustomer()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = 1;
            var residentTypeId = 1;
            var localityId = 1;
            var customerCode = string.Empty;
            var titleId = 1;
            var surName = "Doe & Smith";
            var otherNames = "John & Jane";
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
            var emailAddress = "joint@example.com";
            var residentPermitNumber = "RP000000101";
            DateTime? residentPermitDateIssued = null;
            DateTime? residentPermitExpiryDate = null;
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@jointaccount";
            var identificationTypeId = 1;
            var identificationTypeNumber = "ID123456";
            var identificationTypeImageOne = "id1.jpg";
            var identificationTypeImageTwo = "id2.jpg";
            var identificationTypeImageThree = "id3.jpg";
            var identificationTypeImageFour = "id4.jpg";
            var identificationTypeImageFive = "id5.jpg";
            var comments = "Joint account registration";
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
            var maritalStatus = "Married";
            var dateOfMarriage = DateTime.Now.AddYears(-5);

            var mockLocality = new Locality(localityId, "C03", "JOINT LOCALITY", "5J5", 1);

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
            var customer = await CustomerMaster.CreateJointAsync(
                customerMasterId,
                customerTypeId,
                residentTypeId,
                localityId,
                customerCode,
                titleId,
                surName,
                otherNames,
                dateOfBirth,
                tinNumber,
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
                residentPermitNumber,
                residentPermitDateIssued,
                residentPermitExpiryDate,
                socialMediaTypeId,
                socialMediaAccount,
                identificationTypeId,
                identificationTypeNumber,
                identificationTypeImageOne,
                identificationTypeImageTwo,
                identificationTypeImageThree,
                identificationTypeImageFour,
                identificationTypeImageFive,
                comments,
                interestExpressed,
                debtorStatus,
                parentCode,
                contactPerson_FullName,
                contactPerson_PhoneNumber,
                contactPerson_EmailAddress,
                contactPerson_Address,
                contactPerson_IdentificationTypeId,
                contactPerson_IdentificationTypeNumber,
                contactPerson_IdentificationTypeImageOne,
                contactPerson_IdentificationTypeImageTwo,
                isDeleted,
                isPrimary,
                maritalStatus,
                dateOfMarriage,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.CustomerMasterId.Should().Be(customerMasterId);
            customer.CustomerTypeId.Should().Be(customerTypeId);
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.LocalityId.Should().Be(localityId);
            customer.CustomerCode.Should().StartWith("5J5"); // Based on locality code
            customer.TitleId.Should().Be(titleId);
            customer.SurName.Should().Be(surName);
            customer.OtherNames.Should().Be(otherNames);
            customer.DateOfBirth.Should().Be(dateOfBirth);
            customer.TinNumber.Should().Be(tinNumber);
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
            customer.IdentificationTypeId.Should().Be(identificationTypeId);
            customer.IdentificationTypeNumber.Should().Be(identificationTypeNumber);
            customer.Comments.Should().Be(comments);
            customer.InterestExpressed.Should().Be(interestExpressed);
            customer.IsDeleted.Should().BeFalse();
            customer.IsPrimary.Should().BeTrue();
            customer.MaritalStatus.Should().Be(maritalStatus);
            customer.DateOfMarriage.Should().Be(dateOfMarriage);

            // Verify domain service calls
            _customerDomainServiceMock.Verify(x => x.LocalityExists(localityId), Times.AtLeastOnce);
            _customerDomainServiceMock.Verify(x => x.CustomerTypeExists(customerTypeId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.ResidentTypeExists(residentTypeId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.GenderExists(genderId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.NationalityExists(nationalityId), Times.Once);
            _customerDomainServiceMock.Verify(x => x.IdentificationTypeExists(identificationTypeId), Times.Once);
        }

        [Fact]
        public async Task CreateJointAsync_WithNonResidentType_ShouldRequireContactPerson()
        {
            // Arrange
            var customerMasterId = 1;
            var customerTypeId = (int)CustomerTypeEnum.JOINT_OWNERSHIP;
            var residentTypeId = (int)ResidentTypeEnum.NON_RESIDENT; // Non-resident type
            var localityId = 1;
            var customerCode = string.Empty;
            var titleId = 1;
            var surName = "Doe & Smith";
            var otherNames = "John & Jane";
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
            var emailAddress = "joint@example.com";
            var residentPermitNumber = "";
            DateTime? residentPermitDateIssued = null;
            DateTime? residentPermitExpiryDate = null;
            var socialMediaTypeId = 1;
            var socialMediaAccount = "@jointaccount";
            var identificationTypeId = 1;
            var identificationTypeNumber = "ID123456";
            var identificationTypeImageOne = "id1.jpg";
            var identificationTypeImageTwo = "id2.jpg";
            var identificationTypeImageThree = "id3.jpg";
            var identificationTypeImageFour = "id4.jpg";
            var identificationTypeImageFive = "id5.jpg";
            var comments = "Joint account registration";
            var interestExpressed = "Residential property";
            var debtorStatus = 0;
            var parentCode = "";
            var contactPerson_FullName = "Contact Person";
            var contactPerson_PhoneNumber = "+233111222333";
            var contactPerson_EmailAddress = "contact@example.com";
            var contactPerson_Address = "Contact Address";
            var contactPerson_IdentificationTypeId = 1;
            var contactPerson_IdentificationTypeNumber = "CP123456";
            var contactPerson_IdentificationTypeImageOne = "cp1.jpg";
            var contactPerson_IdentificationTypeImageTwo = "cp2.jpg";
            var isDeleted = false;
            var isPrimary = true;
            var maritalStatus = "Married";
            var dateOfMarriage = DateTime.Now.AddYears(-5);

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
            var customer = await CustomerMaster.CreateJointAsync(
                customerMasterId, customerTypeId, residentTypeId, localityId,
                customerCode, titleId, surName, otherNames, dateOfBirth,
                tinNumber, picture, genderId, nationalityId, postalAddress,
                residentialAddress, digitalAddress, primaryMobileNumber,
                secondaryMobileNumber, officeNumber, whatsAppNumber,
                emailAddress, residentPermitNumber, residentPermitDateIssued,
                residentPermitExpiryDate, socialMediaTypeId, socialMediaAccount,
                identificationTypeId, identificationTypeNumber,
                identificationTypeImageOne, identificationTypeImageTwo,
                identificationTypeImageThree, identificationTypeImageFour,
                identificationTypeImageFive, comments, interestExpressed,
                debtorStatus, parentCode, contactPerson_FullName,
                contactPerson_PhoneNumber, contactPerson_EmailAddress,
                contactPerson_Address, contactPerson_IdentificationTypeId,
                contactPerson_IdentificationTypeNumber,
                contactPerson_IdentificationTypeImageOne,
                contactPerson_IdentificationTypeImageTwo, isDeleted,
                isPrimary, maritalStatus, dateOfMarriage,
                _customerDomainServiceMock.Object
            );

            // Assert
            customer.Should().NotBeNull();
            customer.ResidentTypeId.Should().Be(residentTypeId);
            customer.ContactPerson_FullName.Should().Be(contactPerson_FullName);
            customer.ContactPerson_PhoneNumber.Should().Be(contactPerson_PhoneNumber);
            customer.ContactPerson_EmailAddress.Should().Be(contactPerson_EmailAddress);
            customer.ContactPerson_Address.Should().Be(contactPerson_Address);
            customer.ContactPerson_IdentificationTypeId.Should().Be(contactPerson_IdentificationTypeId);
            customer.ContactPerson_IdentificationTypeNumber.Should().Be(contactPerson_IdentificationTypeNumber);
        }

    }
}