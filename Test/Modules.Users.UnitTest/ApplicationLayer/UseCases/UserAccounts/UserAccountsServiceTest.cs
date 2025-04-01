using System;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Application.Interfaces;
using Modules.Users.Application.Shared;
using Modules.Users.Application.UseCases.UserAccounts;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces.Entities;
using Moq;
using Newtonsoft.Json.Linq;
using System.Security.Claims;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Application.Enums;
using System.Linq.Expressions;
using Modules.Users.UnitTest.InfrastructureLayer.Data;
using Modules.Users.Application.Dtos.Entities.Permissions;
using System.Collections.Generic;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserAccounts
{
    public class UserAccountsServiceTests
    {
        private readonly Mock<UserManager<ApplicationIdentityUser>> _mockUserManager;
        private readonly Mock<SignInManager<ApplicationIdentityUser>> _mockSignInManager;
        private readonly Mock<ILogger<UserAccountsService>> _mockLogger;
        private readonly Mock<ITokenStoreRepository> _mockTokenService;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMenuService> _mockMenuService;
        private readonly Mock<IValidator<PartnerBankRegistrationRequestDto>> _mockPartnerValidator;
        private readonly Mock<IPasswordValidator<ApplicationIdentityUser>> _mockPasswordValidator;
        private readonly UserAccountsService _service;

        public UserAccountsServiceTests()
        {
            var userStore = new Mock<IUserStore<ApplicationIdentityUser>>();
            _mockUserManager = new Mock<UserManager<ApplicationIdentityUser>>(
                userStore.Object, default!, default!, default!, default!, default!, default!, default!, default!);

            _mockSignInManager = new Mock<SignInManager<ApplicationIdentityUser>>(
                _mockUserManager.Object,
                Mock.Of<IHttpContextAccessor>(),
                Mock.Of<IUserClaimsPrincipalFactory<ApplicationIdentityUser>>(),
                default!, default!, default!, default!);

            _mockLogger = new Mock<ILogger<UserAccountsService>>();
            _mockTokenService = new Mock<ITokenStoreRepository>();
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMenuService = new Mock<IMenuService>();
            _mockPartnerValidator = new Mock<IValidator<PartnerBankRegistrationRequestDto>>();
            _mockPasswordValidator = new Mock<IPasswordValidator<ApplicationIdentityUser>>();

            _service = new UserAccountsService(
                _mockUserManager.Object,
                _mockSignInManager.Object,
                _mockUnitOfWork.Object,
                _mockLogger.Object,
                _mockTokenService.Object,
                _mockPartnerValidator.Object,
                _mockMenuService.Object,
                _mockPasswordValidator.Object
            );
        }

        [Fact]
        public async Task ChangePassword_WithValidData_ShouldSucceed()
        {
            // Arrange
            var changePasswordDto = new ChangePasswordRequestDto
            {
                UserId = "testUserId",
                OldPassword = "OldPass123!",
                NewPassword = "NewPass123!",
                ConfirmNewPassword= "NewPass123!"
            };

            var user = new ApplicationIdentityUser { Id = "testUserId", IsFirstTime = true };

            _mockUserManager.Setup(x => x.FindByIdAsync(changePasswordDto.UserId))
                .ReturnsAsync(user);
            _mockPasswordValidator.Setup(x => x.ValidateAsync(_mockUserManager.Object, user, changePasswordDto.NewPassword))
                .ReturnsAsync(IdentityResult.Success);
            _mockUserManager.Setup(x => x.ChangePasswordAsync(user, changePasswordDto.OldPassword, changePasswordDto.NewPassword))
                .ReturnsAsync(IdentityResult.Success);
            _mockUserManager.Setup(x => x.UpdateAsync(user))
                .ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _service.ChangePassword(changePasswordDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.StatusCode);
            Assert.False(user.IsFirstTime);
        }

        [Fact]
        public async Task LoginWithEmailAddress_WithValidCredentials_ShouldSucceed()
        {
            // Arrange
            var loginDto = new LoginRequestDto
            {
                Phone_OR_Email = "test@example.com",
                Password = "Password123!"
            };

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                Email = "test@example.com",
                UserName = "test@example.com",
                FirstName = "John",
                LastName = "Doe",
                PhoneNumber = "1234567890",
                Status = (int)RegistrationStatus.Activated,
                IsFirstTime = false,
                UserType = (int)UserAccountType.Staff,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                DepartmentId = 1,
                UnitId = 1,
                ChannelId = 1,
                RegistrationDate = DateTime.UtcNow,
                RefreshToken = null,
                RefreshTokenExpires = DateTime.UtcNow
            };

            _mockUserManager.Setup(x => x.FindByEmailAsync(loginDto.Phone_OR_Email))
                .ReturnsAsync(user);
            _mockUserManager.Setup(x => x.GetRolesAsync(user))
                .ReturnsAsync(new List<string> { "User" });
            _mockPasswordValidator.Setup(x => x.ValidateAsync(_mockUserManager.Object, user, loginDto.Password))
                .ReturnsAsync(IdentityResult.Success);
            _mockSignInManager.Setup(x => x.PasswordSignInAsync(user, loginDto.Password, true, false))
                .ReturnsAsync(SignInResult.Success);
            _mockTokenService.Setup(x => x.GetJwToken(user, It.IsAny<int>()))
                .Returns(new JwTokenResponse { Token = "testToken", ExpiresAt = DateTime.UtcNow.AddHours(8) });
            _mockTokenService.Setup(x => x.GetJwRefreshToken())
                .Returns(new RefreshToken { Token = "refreshToken", Expires = DateTime.UtcNow.AddDays(7) });


            var jwtToken = new JwTokenResponse
            {
                Token = "testBearerToken",
                ExpiresAt = DateTime.UtcNow.AddHours(8)
            };

            var refreshToken = new RefreshToken
            {
                Token = "testRefreshToken",
                Expires = DateTime.UtcNow.AddDays(7)
            };

            _mockTokenService.Setup(x => x.GetJwToken(user, It.IsAny<int>()))
                .Returns(jwtToken);

            _mockTokenService.Setup(x => x.GetJwRefreshToken())
                .Returns(refreshToken);

            _mockUnitOfWork.Setup(x => x.Users.Update(It.IsAny<ApplicationIdentityUser>()))
                .Verifiable();

            _mockUnitOfWork.Setup(x => x.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.LoginWithEmailAddress(loginDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.LoginStatus);
            Assert.NotNull(result.successResponse);
            Assert.Equal("testUserId", result.successResponse.UserId);
            Assert.Equal("testBearerToken", result.successResponse.BearerToken);
            Assert.Equal("testRefreshToken", result.successResponse.RefreshToken);
            //Assert.Equal(jwtToken.ExpiresAt, result.successResponse.ExpiresAt);
            Assert.False(result.successResponse.IsFirstTime);

            // Verify that the user was updated with the new refresh token
            _mockUnitOfWork.Verify(x => x.Users.Update(It.Is<ApplicationIdentityUser>(u =>
                u.RefreshToken == refreshToken.Token &&
                u.RefreshTokenExpires == refreshToken.Expires)), Times.Once);
            _mockUnitOfWork.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task CustomerUserRegistration_WithValidData_ShouldSucceed()
        {
            // Arrange
            var registrationDto = new CustomerRegistrationRequestDto
            (
                CustomerCode : "CUST001",
                FirstName : "John",
                MiddleName: string.Empty,
                LastName : "Doe",
                PhoneNumber: "+233244123457",
                EmailAddress : "john.doe@example.com",
                LastReceiptNumber: "1234567890",
                LastReceiptImage: "/uploads/receipt/image.jpg",
                IdentificationTypeId: 1,
                IdentificationUniqueNumber: "9XX0001",
                IdentificationImage: "/uploads/id/front_image.jpg",
                IdentificationImageOne: "/uploads/id/back_image.jpg",
                SelfieImage: "/uploads/selfieimage.jpg",
                PassportPicture: "",
                ChannelId: 301,
                FirebaseId: "FB0191019208208_id"
            );

            var channel = new Channels(1, "TestChannel");

            _mockUnitOfWork.Setup(x => x.Channels.Get(registrationDto.ChannelId))
                .ReturnsAsync(channel);
            _mockUserManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationIdentityUser>()))
                .ReturnsAsync(IdentityResult.Success);
            _mockSignInManager.Setup(x => x.SignInAsync(It.IsAny<ApplicationIdentityUser>(), false, default))
                .Returns(Task.CompletedTask);

            // Act
            var result = await _service.CustomerUserRegistration(registrationDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.StatusCode);
        }

        [Fact]
        public async Task RefreshBearerToken_WithValidTokens_ShouldSucceed()
        {
            // Arrange
            var refreshTokenDto = new RefreshTokenRequestDto
            {
                BearerToken = "oldBearerToken",
                RefreshToken = "validRefreshToken"
            };

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                RefreshToken = "validRefreshToken",
                RefreshTokenExpires = DateTime.UtcNow.AddDays(1)
            };

            var principal = new ClaimsPrincipal(new ClaimsIdentity(new[]
            {
            new Claim(ClaimTypes.NameIdentifier, "testUserId")
        }));

            _mockTokenService.Setup(x => x.GetClaimsPrincipalFromExpiredBearerToken(refreshTokenDto.BearerToken))
                .Returns(principal);
            _mockUserManager.Setup(x => x.FindByIdAsync("testUserId"))
                .ReturnsAsync(user);
            _mockTokenService.Setup(x => x.GetJwToken(user, It.IsAny<int>()))
                .Returns(new JwTokenResponse { Token = "newBearerToken", ExpiresAt = DateTime.UtcNow.AddDays(5) });
            _mockTokenService.Setup(x => x.GetJwRefreshToken())
                .Returns(new RefreshToken { Token = "newRefreshToken", Expires = DateTime.UtcNow.AddDays(7) });

            // Act
            var result = await _service.RefreshBearerToken(refreshTokenDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.NotNull(result.SuccessResponse);
            Assert.Equal("newBearerToken", result.SuccessResponse.BearerToken);
            Assert.Equal("newRefreshToken", result.SuccessResponse.RefreshToken);
        }

        [Fact]
        public async Task UpdateAccountDetails_WithValidData_ShouldSucceed()
        {
            // Arrange
            var updateDto = new UpdateUserDto
            (
                UserId : "testUserId",
                PhoneNumber : "9876543210",
                ProfilePicture : "newPicture.jpg",
                MiddleName : "Middle"
            );

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                Email = "test@example.com",
                UserName = "test@example.com",
                FirstName = "John",
                MiddleName = "",
                LastName = "Doe",
                PhoneNumber = "1234567890",
                Status = (int)RegistrationStatus.Activated,
                IsFirstTime = false,
                UserType = (int)UserAccountType.Staff,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                DepartmentId = 1,
                UnitId = 1,
                ChannelId = 1,
                RegistrationDate = DateTime.UtcNow,
                RefreshToken = null,
                RefreshTokenExpires = DateTime.UtcNow
            };


            var rolesData = UserMasterTestData.GetSampleRolesData();
            _mockUnitOfWork.Setup(x => x.Roles.Get(It.IsAny<Expression<Func<ApplicationIdentityRole, bool>>>(), null))
                .ReturnsAsync((Expression<Func<ApplicationIdentityRole, bool>> predicate, object _) =>
                    rolesData.AsQueryable().FirstOrDefault(predicate));

            SetupRelatedEntityMocks();

            _mockUserManager.Setup(x => x.FindByIdAsync(updateDto.UserId))
                .ReturnsAsync(user);
            _mockUserManager.Setup(x => x.UpdateAsync(It.IsAny<ApplicationIdentityUser>()))
                .ReturnsAsync(IdentityResult.Success);

            // Mocking the GetRolesAsync method
            _mockUserManager.Setup(x => x.GetRolesAsync(user))
                .ReturnsAsync(new List<string> { "RoleOne" }); // Simulate roles for the user

            // Mocking the GetUserRolePermissions method
            _mockMenuService.Setup(x => x.GetUserRolePermissions(user.Id))
                .ReturnsAsync(new PermissionsAccessModulesReadDto(
                    string.Empty,
                    new List<PermissionAccessMenusWithActionsReadDto>
                    {
                        new PermissionAccessMenusWithActionsReadDto(1, "Menu1",new PermissionsActionsDto(false,true,true,true,true,true) ,default!)
                    }
                ));

            // Act
            var result = await _service.UpdateAccountDetails(updateDto);

            // Assert
            Assert.Null(result.error);
            Assert.NotNull(result.success);
        }

        private void SetupRelatedEntityMocks()
        {
            var channeltData = UserMasterTestData.GetSampleChannelsData();
            _mockUnitOfWork.Setup(x => x.Channels.Get(It.IsAny<Expression<Func<Channels, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Channels, bool>> predicate, object _) =>
                    channeltData.AsQueryable().FirstOrDefault(predicate));

            var departmentData = UserMasterTestData.GetSampleDepartmentData();
            _mockUnitOfWork.Setup(x => x.Department.Get(It.IsAny<Expression<Func<Department, bool>>>(), null))
                .ReturnsAsync((Expression<Func<Department, bool>> predicate, object _) =>
                    departmentData.AsQueryable().FirstOrDefault(predicate));

            var departmentUnitData = UserMasterTestData.GetSampleDepartmentUnitData();
            _mockUnitOfWork.Setup(x => x.DepartmentUnit.Get(It.IsAny<Expression<Func<DepartmentUnit, bool>>>(), null))
                .ReturnsAsync((Expression<Func<DepartmentUnit, bool>> predicate, object _) =>
                    departmentUnitData.AsQueryable().FirstOrDefault(predicate));
        }


    }
}

