using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;
using Modules.Users.Application.Interfaces.UserAccounts;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Presentation.Controllers.v1;
using Modules.Users.Domain.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Shared;
using Microsoft.AspNetCore.Http;

namespace Modules.Users.UnitTest.PresentationLayer
{
    public class AccountControllerTests
    {
        private readonly Mock<IUserAccountsService> _mockUserAccountsService;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly AccountController _controller;

        public AccountControllerTests()
        {
            _mockUserAccountsService = new Mock<IUserAccountsService>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _controller = new AccountController(_mockUserAccountsService.Object, _mockUnitOfWork.Object);
        }

        [Fact]
        public async Task GetIdentificationTypes_ShouldReturnListOfIdentificationTypes()
        {
            // Arrange
            var identificationTypes = new List<IdentificationType>
            {
                new IdentificationType(1, "National ID"),
                new IdentificationType(2, "Passport")
            };

            _mockUnitOfWork.Setup(x => x.IdentificationType.GetAll())
                .ReturnsAsync(identificationTypes);

            // Act
            var result = await _controller.GetIdentificationTypes();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsType<List<IdentificationType>>(okResult.Value);
            Assert.Equal(2, returnValue.Count);
        }

        [Fact]
        public async Task GetChannels_ShouldReturnListOfChannels()
        {
            // Arrange
            var channels = new List<Channels>
            {
                new Channels(1, "Web"),
                new Channels(2, "Mobile")
            };

            _mockUnitOfWork.Setup(x => x.Channels.GetAll())
                .ReturnsAsync(channels);

            // Act
            var result = await _controller.GetChannels();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<ChannelReadDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count());
        }

        [Fact]
        public async Task Register_Customer_WithValidData_ShouldReturnCreated()
        {
            // Arrange
            var customerDto = new CustomerRegistrationRequestDto
            (
                "CUST001",
                "Methodman",
                "Redman",
                "Raekwom",
                "0241234567",
                "meth@example.com",
                "A00000000012",
                "uploads/profile/profile.png",
                1,
                "GHA-000000-0000",
                "uploads/id/front.png",
                "uploads/id/back.png",
                "uploads/selfie/selfie.png",
                "uploads/passport/passport.png",
                1,
                "FB0101910920190_id"
            );

            var successResponse = new RegistrationResponse
            {
                IsSuccess = true,
                SuccessResponse = new RegistrationSuccessResponse
                {
                    StatusCode = StatusCodes.Status201Created,
                    StatusMessage = "Success",
                    UserId = "CUST001",
                    UserEmailAddress = "meth@example.com"
                }
            };

            _mockUserAccountsService.Setup(x => x.CustomerUserRegistration(customerDto))
                .ReturnsAsync(successResponse);

            // Act
            var result = await _controller.Register(customerDto);

            // Assert
            var createdResult = Assert.IsType<ObjectResult>(result);
            Assert.Equal(StatusCodes.Status201Created, createdResult.StatusCode);
        }

        [Fact]
        public async Task Login_WithValidEmailCredentials_ShouldReturnOk()
        {
            // Arrange
            var loginDto = new LoginRequestDto
            {
                Phone_OR_Email = "test@example.com",
                Password = "Password123!"
            };

            var loginResponse = new LoginResponseDto
            {
                LoginStatus = true,
                successResponse = new LoginSucessResponseDto
                {
                    UserId = "testUserId",
                    BearerToken = "testToken",
                    RefreshToken = "refreshToken",
                    IsFirstTime = false
                }
            };

            _mockUserAccountsService.Setup(x => x.LoginWithEmailAddress(loginDto))
                .ReturnsAsync(loginResponse);

            // Act
            var result = await _controller.UserLogin(loginDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var returnValue = Assert.IsType<LoginResponseDto>(okResult.Value);
            Assert.True(returnValue.LoginStatus);
        }

        [Fact]
        public async Task RefreshToken_WithValidTokens_ShouldReturnOk()
        {
            // Arrange
            var refreshRequest = new RefreshTokenRequestDto
            {
                BearerToken = "oldToken",
                RefreshToken = "validRefreshToken"
            };

            var refreshResponse = new RefreshTokenResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new RefreshTokenSuccessResponseDto
                {
                    UserId = "testUserId",
                    BearerToken = "newToken",
                    RefreshToken = "newRefreshToken",
                    ExpiresAt = DateTime.UtcNow.AddHours(1)
                }
            };

            _mockUserAccountsService.Setup(x => x.RefreshBearerToken(refreshRequest))
                .ReturnsAsync(refreshResponse);

            // Act
            var result = await _controller.RefreshToken(refreshRequest);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task UserDetails_WithValidUserId_ShouldReturnOk()
        {
            // Arrange
            string userId = "testUserId";
            var user = new ApplicationIdentityUser { Id = userId, Email = "test@example.com" };
            var userInfo = new StaffUserInformationDto(user, "IT", "Development", "Web", "Staff", "Active", new List<string> { "User" }, null!);

            _mockUnitOfWork.Setup(x => x.Users.Get(It.IsAny<Expression<Func<ApplicationIdentityUser, bool>>>(), null))
                .ReturnsAsync(user);

            _mockUserAccountsService.Setup(x => x.UserDetails(userId))
                .ReturnsAsync(userInfo);

            // Act
            var result = await _controller.UserDetails(userId);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task SendOTPToken_WithValidEmail_ShouldReturnOk()
        {
            // Arrange
            var tokenRequest = new TokenRequestParameterDto
            (
                "test@example.com"
            );

            _mockUnitOfWork.Setup(x => x.TokenStore.GetToken(tokenRequest.phone_OR_email, 5))
                .ReturnsAsync("123456");

            // Act
            var result = await _controller.SendOTPToken(tokenRequest);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            var responseDto = Assert.IsType<TokenResponseDto>(okResult.Value);
            Assert.Equal("123456", responseDto.response);
        }

        [Fact]
        public async Task VerifyOTPToken_WithValidToken_ShouldReturnOk()
        {
            // Arrange
            var verifyRequest = new VerifyTokenRequestDto
            (
                "test@example.com",
                "123456"
            );

            _mockUnitOfWork.Setup(x => x.TokenStore.VerifyToken(verifyRequest.phone_OR_email, verifyRequest.token))
                .ReturnsAsync("Verified");

            // Act
            var result = await _controller.VerifyOTPToken(verifyRequest);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task UpdateUserAccount_WithValidData_ShouldReturnOk()
        {
            // Arrange
            var updateRequest = new UpdateUserDto
            (
                "testUserId",
                "0241234567",
                "newPicture.jpg",
                "Middle"
            );

            var updateResponse = new UpdateAccountDetailsResponseDto
            {
                success = new StaffUserInformationDto(
                    new ApplicationIdentityUser { Id = "testUserId" },
                    "IT",
                    "Development",
                    "Web",
                    "Staff",
                    "Active",
                    new List<string> { "User" },
                    null!
                ),
                error = null
            };

            _mockUserAccountsService.Setup(x => x.UpdateAccountDetails(updateRequest))
                .ReturnsAsync(updateResponse);

            // Act
            var result = await _controller.UpdateUserAccount(updateRequest);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }
    }
}