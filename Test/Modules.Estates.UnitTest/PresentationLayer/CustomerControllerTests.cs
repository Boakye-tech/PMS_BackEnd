// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Mvc;
using Moq;
using FluentAssertions;
using Xunit;
using Modules.Common.Infrastructure.Authentication;
using Modules.Estates.Application.DTO.Management.Customer;
using Modules.Estates.Application.DTO.Setup.Customer;
using Modules.Estates.Application.Interfaces.Entities.Setup.Customer;
using Modules.Estates.Application.Interfaces.Management.Customer;
using Modules.Estates.Presentation.Controllers.v1;
using Modules.Estates.Application.DTO.Management;
using Modules.Estates.Presentation.Constants;
using Modules.Estates.Application.Enums;
using Modules.Estates.Application.Interfaces.Management.Complaints;

namespace Modules.Estates.UnitTest.PresentationLayer
{
    public class CustomerControllerTests
    {
        private readonly Mock<ICustomerTypeService> _customerTypeServiceMock;
        private readonly Mock<IGenderService> _genderServiceMock;
        private readonly Mock<IIdentificationTypeService> _identificationTypeServiceMock;
        private readonly Mock<INationalityService> _nationalityServiceMock;
        private readonly Mock<IResidentTypeService> _residentTypeServiceMock;
        private readonly Mock<ISocialMediaService> _socialMediaServiceMock;
        private readonly Mock<ITitleService> _titleServiceMock;
        private readonly Mock<IOwnershipTypeService> _ownershipTypeServiceMock;
        private readonly Mock<ICustomerMasterService> _customerMasterServiceMock;
        private readonly Mock<IUserContextService> _userContextServiceMock;
        private readonly Mock<IInterestExpressedService> _interestContextServiceMock;
        
        private readonly CustomerController _controller;

        private readonly Mock<IComplaintTypeService> _complaintTypeServiceMock;
        private readonly Mock<INatureOfComplaintService> _natureOfComplaintMock;
        private readonly Mock<IComplaintMasterService> _complaintMasterMock;

        private readonly Mock<IComplaintStatusesService> _complaintStatusesMock;

        public CustomerControllerTests()
        {
            _customerTypeServiceMock = new Mock<ICustomerTypeService>();
            _genderServiceMock = new Mock<IGenderService>();
            _identificationTypeServiceMock = new Mock<IIdentificationTypeService>();
            _nationalityServiceMock = new Mock<INationalityService>();
            _residentTypeServiceMock = new Mock<IResidentTypeService>();
            _socialMediaServiceMock = new Mock<ISocialMediaService>();
            _titleServiceMock = new Mock<ITitleService>();
            _ownershipTypeServiceMock = new Mock<IOwnershipTypeService>();
            _customerMasterServiceMock = new Mock<ICustomerMasterService>();
            _userContextServiceMock = new Mock<IUserContextService>();
            _interestContextServiceMock = new Mock<IInterestExpressedService>();

            _complaintTypeServiceMock = new Mock<IComplaintTypeService>();
            _natureOfComplaintMock = new Mock<INatureOfComplaintService>();
            _complaintMasterMock = new Mock<IComplaintMasterService>();
            _complaintStatusesMock = new Mock<IComplaintStatusesService>();

            _controller = new CustomerController(
                _customerTypeServiceMock.Object,
                _genderServiceMock.Object,
                _identificationTypeServiceMock.Object,
                _nationalityServiceMock.Object,
                _residentTypeServiceMock.Object,
                _socialMediaServiceMock.Object,
                _titleServiceMock.Object,
                _customerMasterServiceMock.Object,
                _ownershipTypeServiceMock.Object,
                _userContextServiceMock.Object,
                _interestContextServiceMock.Object,
                _complaintTypeServiceMock.Object,
                _natureOfComplaintMock.Object,
                _complaintStatusesMock.Object,
                _complaintMasterMock.Object
            );
        }

        // Customer Type Tests
        [Fact]
        public async Task GetCustomerTypes_ReturnsOkResult()
        {
            // Arrange
            var expectedTypes = new List<CustomerTypeReadDto>
            {
                new CustomerTypeReadDto(customerTypeId: 1, customerTypes: "RESIDENT")
            };
            _customerTypeServiceMock.Setup(x => x.GetCustomerTypeAsync())
                .ReturnsAsync(expectedTypes);

            // Act
            var result = await _controller.GetCustomerTypes();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<CustomerTypeReadDto>>(okResult.Value);
            Assert.Single(returnValue);
        }

        [Fact]
        public async Task CreateCustomerType_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var userId = "testUser";
            var createDto = new CustomerTypeCreateDto
            {
                customerTypeId = 0,
                customerTypes = "RESIDENT",
                createdBy= userId
            };

            var expectedResponse = new CustomerTypeReadDto
            (
                customerTypeId: 1,
                customerTypes: "RESIDENT"
            );

            _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);
            _customerTypeServiceMock.Setup(x => x.AddCustomerTypeAsync(createDto))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.CreateCustomerType(createDto);

            // Assert
            var okResult = Assert.IsType<ObjectResult>(result.Result);
            var returnValue = Assert.IsType<CustomerTypeReadDto>(okResult.Value);
            Assert.Equal(expectedResponse.customerTypeId, returnValue.customerTypeId);
        }

        // Gender Tests
        [Fact]
        public async Task GetGenders_ReturnsOkResult()
        {
            // Arrange
            var expectedGenders = new List<GenderReadDto>
            {
                new GenderReadDto(genderId: 1, genderType: "MALE" )
            };
            _genderServiceMock.Setup(x => x.GetGenderAsync())
                .ReturnsAsync(expectedGenders);

            // Act
            var result = await _controller.GetGender();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<GenderReadDto>>(okResult.Value);
            Assert.Single(returnValue);
        }

        // Identification Type Tests
        [Fact]
        public async Task CreateIdentificationType_WithUnauthorizedUser_ReturnsUnauthorized()
        {
            // Arrange
            var userId = "testUser";
            var createDto = new IdentificationTypeCreateDto
            (
                identificationTypeId: 1,
                identificationTypes: "GHANA CARD",
                createdBy: "differentUser"
            );

            _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);

            // Act
            var result = await _controller.CreateIdentificationType(createDto);

            // Assert
            Assert.IsType<UnauthorizedResult>(result.Result);
        }

        // Nationality Tests
        [Fact]
        public async Task UpdateNationality_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var userId = "testUser";
            var updateDto = new NationalityUpdateDto
            (
                nationalityId: 1,
                nationalities: "GHANAIAN",
                modifiedby: userId
            );

            var expectedResponse = new NationalityReadDto
            (
                nationalityId: 1,
                nationalities: "GHANAIAN"
            );

            _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);
            _nationalityServiceMock.Setup(x => x.UpdateNationalityAsync(updateDto))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.UpdateNationality(updateDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<NationalityReadDto>(okResult.Value);
            Assert.Equal(expectedResponse.nationalityId, returnValue.nationalityId);
        }

        // Title Tests
        [Fact]
        public async Task DeleteTitle_ReturnsOkResult()
        {
            // Arrange
            var titleId = 1;
            var expectedResponse = "Deleted successfully";
            _titleServiceMock.Setup(x => x.DeleteTitleAsync(titleId))
                .ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.DeleteTitle(titleId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.Equal(expectedResponse, okResult.Value);
        }

        // Customer List Tests
        [Fact]
        public async Task GetCustomerList_ReturnsOkResult()
        {
            // Arrange
            var expectedCustomers = new List<CustomerListDto>
            {
                new CustomerListDto { CustomerCode = "2AA001" }
            };
            _customerMasterServiceMock.Setup(x => x.GetCustomerListAsync(default!, default!))
                .ReturnsAsync(expectedCustomers);

            // Act
            var result = await _controller.GetCustomerList(default!, default!);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<CustomerListDto>>(okResult.Value);
            Assert.Single(returnValue);
        }

        // Marital Status Tests
        [Fact]
        public void MaritalStatus_ReturnsOkResultWithEnumValues()
        {
            // Act
            var result = _controller.MaritalStatus();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }



        [Fact]
        public async Task AddProspectiveCustomer_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var userId = "testUser";
            var dto = new ProspectiveCustomerCreateDto
            {

                CustomerMasterId = 1,
                CustomerTypeId = 1,
                ResidentTypeId = 1,
                LocalityId = 1,
                CustomerCode = string.Empty,
                TitleId = 1,
                SurName = "Jaegger",
                OtherNames = "Erin",
                CompanyName = string.Empty,
                GenderId = 1,
                NationalityId = 1,
                PostalAddress = "P.O. Box AN123",
                ResidentialAddress = "123 Main St",
                DigitalAddress = "GA-123-4567",
                PrimaryMobileNumber = "233123456789",
                SecondaryMobileNumber = "233987654321",
                OfficeNumber = "233234567890",
                WhatsAppNumber = "233123456789",
                EmailAddress = "erin.jeagger@example.com",
                SocialMediaTypeId = 1,
                SocialMediaAccount = "@erin",
                Comments = "Prospective customer",
                InterestExpressed = "Residential property",
                CreatedBy = userId
            };

            var expectedResponse = new CustomerRegistrationResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new CustomerRegistrationSuccessResponseDto
                {
                    CustomerCode = "2AA001",
                    FullName = "Customer registered successfully",
                    PhoneNumber = "233123456789"
                },
                ErrorResponse = null
            };

            _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);
            _customerMasterServiceMock.Setup(x => x.CreateCustomer(dto)).ReturnsAsync(expectedResponse);

            // Act
            var result = await _controller.AddProspectiveCustomer(dto);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult?.Value.Should().Be(expectedResponse.SuccessResponse);
        }

        //[Fact]
        //public async Task AddProspectiveCustomer_WithUnauthorizedUser_ReturnsUnauthorized()
        //{
        //    // Arrange
        //    var userId = "testUser";
        //    var dto = new ProspectiveCustomerDto { CreatedBy = "differentUser" };

        //    _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);

        //    // Act
        //    var result = await _controller.AddProspectiveCustomer(dto);

        //    // Assert
        //    result.Should().BeOfType<UnauthorizedResult>();
        //}

        //[Fact]
        //public async Task GetCustomer_WithValidCustomerCode_ReturnsOkResult()
        //{
        //    // Arrange
        //    var customerCode = "2AA001";
        //    var customerDetails = new CustomerMasterDto { CustomerCode = customerCode, CustomerTypeId = (int)CustomerTypeEnum.INDIVIDUAL };

        //    _customerMasterServiceMock.Setup(x => x.GetCustomer(customerCode)).ReturnsAsync(customerDetails);
        //    _customerMasterServiceMock.Setup(x => x.GetIndividualCustomerDetails(customerCode)).ReturnsAsync(new IndividualCustomerDetailsDto());

        //    // Act
        //    var result = await _controller.GetCustomer(customerCode);

        //    // Assert
        //    result.Should().BeOfType<OkObjectResult>();
        //}

        [Fact]
        public async Task GetCustomer_WithInvalidCustomerCode_ReturnsNotFound()
        {
            // Arrange
            var customerCode = "INVALID";
            _customerMasterServiceMock.Setup(x => x.GetCustomer(customerCode)).ReturnsAsync((CustomerMasterDto)null!);

            // Act
            var result = await _controller.GetCustomer(customerCode);

            // Assert
            result.Should().BeOfType<NotFoundObjectResult>();
        }

        [Fact]
        public async Task DeleteCustomer_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var customerCode = "2AA001";
            var deletedBy = "testUser";
            var dto = new DeleteCustomerRequestDto(customerCode, deletedBy);

            _customerMasterServiceMock.Setup(x => x.DeleteCustomerAsync(dto)).ReturnsAsync(200);

            // Act
            var result = await _controller.DeleteCustomer(customerCode, deletedBy);

            // Assert
            result.Should().BeOfType<OkObjectResult>();
            var okResult = result as OkObjectResult;
            okResult?.Value.Should().Be("Deleted successfully.");
        }

        //[Fact]
        //public async Task UpdateIndividualCustomer_WithValidData_ReturnsOkResult()
        //{
        //    // Arrange
        //    var userId = "testUser";
        //    var dto = new UpdateIndividualResidentCustomerDto
        //    {
        //        ModifiedBy = userId,
        //        ResidentTypeId = (int)ResidentTypeEnum.RESIDENT
        //    };

        //    _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);
        //    _customerMasterServiceMock.Setup(x => x.UpdateCustomer(dto)).ReturnsAsync(new ServiceResponse<string> { IsSuccess = true });

        //    // Act
        //    var result = await _controller.UpdateIndividualCustomer(dto);

        //    // Assert
        //    result.Should().BeOfType<OkObjectResult>();
        //}

        //[Fact]
        //public async Task StopCustomerDebit_WithValidData_ReturnsOkResult()
        //{
        //    // Arrange
        //    var userId = "testUser";
        //    var dto = new StopDebitRequestDto { ActionBy = userId, CustomerCode = "CUST001" };

        //    _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);
        //    _customerServiceMock.Setup(x => x.StopCustomerDebitAsync(dto)).ReturnsAsync(200);

        //    // Act
        //    var result = await _controller.StopCustomerDebit(dto);

        //    // Assert
        //    result.Should().BeOfType<OkObjectResult>();
        //    var okResult = result as OkObjectResult;
        //    okResult?.Value.Should().Be("success");
        //}

        //[Fact]
        //public async Task UpdateJointCustomer_WithExpatriateValidation_ReturnsBadRequest()
        //{
        //    // Arrange
        //    var userId = "testUser";
        //    var dto = new UpdateJointOwnershipCustomerDto
        //    {
        //        ModifiedBy = userId,
        //        ResidentTypeId = (int)ResidentTypeEnum.EXPATRIATE,
        //        Expatriate = null
        //    };

        //    _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);

        //    // Act
        //    var result = await _controller.UpdateJointCustomer(dto);

        //    // Assert
        //    result.Should().BeOfType<BadRequestObjectResult>();
        //    var badRequestResult = result as BadRequestObjectResult;
        //    badRequestResult?.Value.Should().Be(CustomerConstants.ErrorExpatriateNull);
        //}

        //[Fact]
        //public async Task UpdateMultiCustomer_WithNonResidentValidation_ReturnsBadRequest()
        //{
        //    // Arrange
        //    var userId = "testUser";
        //    var dto = new UpdateMultiOwnershipCustomerDto
        //    {
        //        ModifiedBy = userId,
        //        ResidentTypeId = (int)ResidentTypeEnum.NON_RESIDENT,
        //        NonResident = new IndividualNonResidentCustomerDto
        //        {
        //            ContactPerson_FullName = "",
        //            ContactPerson_EmailAddress = "email@test.com",
        //            ContactPerson_PhoneNumber = "1234567890"
        //        }
        //    };

        //    _userContextServiceMock.Setup(x => x.GetUserId()).Returns(userId);

        //    // Act
        //    var result = await _controller.UpdateMultiCustomer(dto);

        //    // Assert
        //    result.Should().BeOfType<BadRequestObjectResult>();
        //    var badRequestResult = result as BadRequestObjectResult;
        //    badRequestResult?.Value.Should().Be(CustomerConstants.ErrorContactFullNameNull);
        //}

    }
}