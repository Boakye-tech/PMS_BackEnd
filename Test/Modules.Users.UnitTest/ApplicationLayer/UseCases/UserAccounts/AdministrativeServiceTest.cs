using System;
using System.Linq.Expressions;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Enums;
using Modules.Users.Application.Interfaces;
using Modules.Users.Application.UseCases.UserAccounts;
using Modules.Users.Application.Validations;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces;
using Modules.Users.UnitTest.InfrastructureLayer.Data;
using Moq;
using Moq.Protected;
using static Modules.Users.UnitTest.InfrastructureLayer.Data.UserMasterTestData;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserAccounts
{
    public class AdministrationServiceTests
    {
        private readonly Mock<RoleManager<ApplicationIdentityRole>> _mockRoleManager;
        private readonly Mock<UserManager<ApplicationIdentityUser>> _mockUserManager;
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<ValidationService> _mockValidationService;
        private readonly Mock<ILogger<AdministrationService>> _mockLogger;
        private readonly Mock<INotificationServices> _mockNotificationService;
        private readonly AdministrationService _service;

        public AdministrationServiceTests()
        {
            var roleStore = new Mock<IRoleStore<ApplicationIdentityRole>>();

            _mockRoleManager = new Mock<RoleManager<ApplicationIdentityRole>>(
                roleStore.Object, default!, default!, default!, default!);

            var userStore = new Mock<IUserStore<ApplicationIdentityUser>>();
            _mockUserManager = new Mock<UserManager<ApplicationIdentityUser>>(
                userStore.Object, default!, default!, default!, default!, default!, default!, default!, default!);

            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockValidationService = new Mock<ValidationService>();
            _mockLogger = new Mock<ILogger<AdministrationService>>();
            _mockNotificationService = new Mock<INotificationServices>();

            _service = new AdministrationService(
                _mockRoleManager.Object,
                _mockUserManager.Object,
                _mockUnitOfWork.Object,
                _mockValidationService.Object,
                _mockLogger.Object,
                _mockNotificationService.Object
            );
        }

        [Fact]
        public async Task CreateUserRole_WithValidData_ShouldSucceed()
        {
            // Arrange
            var roleDto = new RolesCreateDto
            (
                RoleName : "TestRole",
                DepartmentId : 1,
                UnitId : 1,
                CreatedBy : "testUser"
            );

            _mockValidationService.Setup(x => x.Validate(roleDto))
                .Returns(new ValidationResult());

            _mockRoleManager.Setup(x => x.CreateAsync(It.IsAny<ApplicationIdentityRole>()))
                .ReturnsAsync(IdentityResult.Success);

            // Act
            var result = await _service.CreateUserRole(roleDto);

            // Assert
            Assert.NotNull(result);
            Assert.True(result.Succeeded);
        }

        [Fact]
        public async Task VerifyCustomerAccount_WithValidData_ShouldSucceed()
        {
            // Arrange
            var verifyDto = new VerifyUserAccountDto
            (
                UserId : "testUserId",
                verifiedBy : "staffId"
            );

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                UserType = (int)UserAccountType.Customer,
                Status = (int)RegistrationStatus.Pending,
                Email = "user@example.com"
            };

            var staff = new ApplicationIdentityUser
            {
                Id = "staffId",
                IdentificationNumber = "STAFF001"
            };

            _mockUserManager.Setup(x => x.FindByIdAsync(verifyDto.UserId))
                .ReturnsAsync(user);
            _mockUserManager.Setup(x => x.FindByIdAsync(verifyDto.verifiedBy))
                .ReturnsAsync(staff);

            // Act
            var result = await _service.VerifyCustomerAccount(verifyDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.StatusCode);
        }

        [Fact]
        public async Task ApproveUserAccount_WithValidData_ShouldSucceed()
        {
            // Arrange
            var approvalDto = new ApproveUserAccountDto
            (
                UserId : "testUserId",
                RoleId : "RoleOneId",
                ApprovedBy : "staffId"
            );

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                Email = "testUser@example.com",
                UserName = "testUser@example.com",
                FirstName = "Automated",
                MiddleName = "Test",
                LastName = "User",
                PhoneNumber = "02314567890",
                Status = (int)RegistrationStatus.Pending,
                IsFirstTime = false,
                UserType = (int)UserAccountType.Staff,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                DepartmentId = 1,
                UnitId = 1,
                ChannelId = 1,
                RegistrationDate = DateTime.UtcNow,
                RefreshToken = string.Empty,
                RefreshTokenExpires = DateTime.UtcNow,
                CreatedBy = "staffIdOne",
                ApprovedBy = string.Empty,
                ApprovedDate = DateTime.Now
            };


            var staff = new ApplicationIdentityUser
            {
                Id = "staffId",
                IdentificationNumber = "STAFF001"
            };

            _mockRoleManager.Setup(x => x.FindByIdAsync(It.IsAny<string>()))
                .ReturnsAsync((string roleId) => GetSampleRolesData().FirstOrDefault(r => r.Id == roleId));

            _mockUserManager.Setup(x => x.FindByIdAsync(approvalDto.UserId))
                .ReturnsAsync(user);
 
            _mockUserManager.Setup(x => x.FindByIdAsync(approvalDto.ApprovedBy))
                .ReturnsAsync(staff);

            _mockUserManager.Setup(x => x.UpdateAsync(It.IsAny<ApplicationIdentityUser>()))
                .ReturnsAsync(IdentityResult.Success);


            // Act
            var result = await _service.ApproveUserAccount(approvalDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.StatusCode);
        }

        //[Fact]
        //public async Task GetAdministrationStaff_ShouldReturnStaffList()
        //{
        //   // Arrange
        // var staffAccounts = new List<AdministrationStaffDto>
        //{
        //    new AdministrationStaffDto
        //    (
        //        UserId : "1231354512222222222",
        //        IdentificationNumber : "STAFF001",
        //        FirstName : "John",
        //        MiddleName: string.Empty,
        //        LastName : "Doe",
        //        DepartmentName : "IT",
        //        UnitName : "Development",
        //        EmailAddress : "john@example.com",
        //        PhoneNumber: "2332441234567",
        //        RoleName: "Developer",
        //        Status : "Activated",
        //        RegistrationDate: DateTime.Now
        //    )
        //};

        //    _mockUnitOfWork.Setup(u => u.StaffAccounts.GetAll(
        //            It.IsAny<Expression<Func<StaffAccounts, bool>>>(),
        //            It.IsAny<Func<IQueryable<StaffAccounts>, IOrderedQueryable<StaffAccounts>>>(),
        //            It.IsAny<List<string>>()
        //        ))
        //        .ReturnsAsync((IList<StaffAccounts>)staffAccounts);


        //    // Act
        //    var result = await _service.GetAdministrationStaff();

        //    // Assert
        //    Assert.NotNull(result);
        //    Assert.Single(result);
        //    Assert.Equal("STAFF001", result.First().IdentificationNumber);
        //}

        [Fact]
        public async Task ActivateUserAccount_WithValidData_ShouldSucceed()
        {
            // Arrange
            var activationDto = new ActivateUserAccountDto
            (
                UserId: "testUserId",
                activatedBy: "staffId"
            );

            var user = new ApplicationIdentityUser
            {
                Id = "testUserId",
                UserName = "ippo.makunouchi@example.com",
                Email = "ippo.makunouchi@example.com",
                FirstName = "Ippo",
                MiddleName = "",
                LastName = "Makunouchi",
                PhoneNumber = "0241234567",
                IdentificationNumber = "CUST001",
                DepartmentId = 1,
                UnitId = 1,
                ChannelId = 1,
                Status = (int)RegistrationStatus.Approved,
                UserType = (int)UserAccountType.Staff,
                EmailConfirmed = false,
                PhoneNumberConfirmed = false,
                IsFirstTime = true,
                RegistrationDate = DateTime.UtcNow,
                ProfilePicture = "profile.jpg",
                PassportPicture = "passport.jpg",
                CreatedDate = DateTime.UtcNow,
                ApprovedDate = DateTime.UtcNow,
                ApprovedBy = "approverUserId"
            };

            var staff = new ApplicationIdentityUser
            {
                Id = "staffId",
                UserName = "admin.user@example.com",
                Email = "admin.user@example.com",
                FirstName = "Admin",
                MiddleName = "",
                LastName = "User",
                PhoneNumber = "0241234568",
                IdentificationNumber = "STAFF001",
                DepartmentId = 1,
                UnitId = 1,
                ChannelId = 1,
                Status = (int)RegistrationStatus.Activated,
                UserType = (int)UserAccountType.Staff,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                IsFirstTime = false,
                RegistrationDate = DateTime.UtcNow.AddDays(-30),
                ProfilePicture = "admin-profile.jpg",
                CreatedDate = DateTime.UtcNow.AddDays(-30),
                ActivatedDate = DateTime.UtcNow.AddDays(-29),
                ActivatedBy = "superAdminId"
            };


            _mockNotificationService
                .Setup(x => x.SendTemporaryPasswordEmailNotification(It.IsAny<ApplicationIdentityUser>(), It.IsAny<string>()))
                .ReturnsAsync(true);

            _mockUserManager.Setup(x => x.FindByIdAsync(activationDto.UserId))
                .ReturnsAsync(user);
            _mockUserManager.Setup(x => x.FindByIdAsync(activationDto.activatedBy))
                .ReturnsAsync(staff);
            _mockUserManager.Setup(x => x.GeneratePasswordResetTokenAsync(user))
                .ReturnsAsync("resetToken");
            _mockUserManager.Setup(x => x.ResetPasswordAsync(user, "resetToken", It.IsAny<string>()))
                .ReturnsAsync(IdentityResult.Success);

            _mockUnitOfWork.Setup(x => x.Users.Update(It.IsAny<ApplicationIdentityUser>()))
                .Verifiable();
            _mockUnitOfWork.Setup(x => x.Complete())
                .ReturnsAsync(1);



            // Act
            var result = await _service.ActivateUserAccount(activationDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.StatusCode);

            // Verify user updates
            _mockUnitOfWork.Verify(x => x.Users.Update(It.Is<ApplicationIdentityUser>(u =>
                u.Status == (int)RegistrationStatus.Activated &&
                u.ActivatedBy == activationDto.activatedBy &&
                u.EmailConfirmed == true &&
                u.PhoneNumberConfirmed == true &&
                u.IsFirstTime == true)), Times.Once);

            _mockUnitOfWork.Verify(x => x.Complete(), Times.Once);

            // Verify password reset
            _mockUserManager.Verify(x => x.GeneratePasswordResetTokenAsync(user), Times.Once);
            _mockUserManager.Verify(x => x.ResetPasswordAsync(user, "resetToken", It.IsAny<string>()), Times.Once);
        }

        //[Fact]
        //public async Task GetUserRoles_ShouldReturnRolesList()
        //{
    //        // Arrange
    //        var roles = UserMasterTestData.GetSampleRolesData().AsQueryable();
    //        var departments = UserMasterTestData.GetSampleDepartmentData();
    //        var units = UserMasterTestData.GetSampleDepartmentUnitData();
    //        var users = UserMasterTestData.GetSampleApplicationUsersData();

    //        _mockRoleManager.Setup(x => x.Roles)
    //            .Returns(roles.AsQueryable());

    //        // Convert list to TestAsyncEnumerable
    //        var asyncRolesData = new TestAsyncEnumerable<ApplicationIdentityRole>(roles);


    //        _mockUnitOfWork.Setup(x => x.Department.Get(It.Is<int>(id => id == 1)))
    //            .ReturnsAsync(departments[0]);
    //        _mockUnitOfWork.Setup(x => x.Department.Get(It.Is<int>(id => id == 2)))
    //            .ReturnsAsync(departments[1]);

    //        _mockUnitOfWork.Setup(x => x.DepartmentUnit.Get(It.Is<int>(id => id == 1)))
    //            .ReturnsAsync(units[0]);
    //        _mockUnitOfWork.Setup(x => x.DepartmentUnit.Get(It.Is<int>(id => id == 2)))
    //            .ReturnsAsync(units[1]);

    //        _mockUserManager.Setup(x => x.Users)
    //            .Returns(users.AsQueryable());


    //        // Create a mock of IQueryable<ApplicationIdentityRole>
    //        var mockRoles = new Mock<IQueryable<ApplicationIdentityRole>>();

    //        mockRoles.As<IAsyncEnumerable<ApplicationIdentityRole>>()
    //            .Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>()))
    //            .Returns(new TestAsyncEnumerator<ApplicationIdentityRole>(roles.GetEnumerator()));

    //        mockRoles.As<IQueryable<ApplicationIdentityRole>>()
    //            .Setup(m => m.Provider)
    //            .Returns(new TestAsyncQueryProvider<ApplicationIdentityRole>(roles.Provider));

    //        mockRoles.As<IQueryable<ApplicationIdentityRole>>()
    //            .Setup(m => m.Expression)
    //            .Returns(roles.Expression);

    //        mockRoles.As<IQueryable<ApplicationIdentityRole>>()
    //            .Setup(m => m.ElementType)
    //            .Returns(roles.ElementType);

    //        mockRoles.As<IQueryable<ApplicationIdentityRole>>()
    //            .Setup(m => m.GetEnumerator())
    //            .Returns(roles.GetEnumerator());

    //        // Mock the RoleManager's Roles property
    //        _mockRoleManager.Setup(x => x.Roles).Returns(mockRoles.Object);

    //        // Mock ToListAsync()
    //        //_mockRoleManager.Setup(x => x.Roles.OrderByDescending(role => role.CreatedOn).ToListAsync(default))
    //            //.ReturnsAsync(roles.OrderByDescending(r => r.CreatedOn).ToList());

    //        _mockRoleManager
    //.Setup(x => x.Roles.ToListAsync(It.IsAny<CancellationToken>()))
    //.ReturnsAsync(GetSampleRolesData()); // Returns a precomputed list



    //        // Act
    //        var result = await _service.GetUserRoles();

    //        // Assert
    //        Assert.NotNull(result);
    //        Assert.Equal(4, result.Count);

    //        // Verify first role
    //        var firstRole = result[0];
    //        Assert.Equal("RoleOne", firstRole.RoleName);
    //        Assert.Equal(1, firstRole.DepartmentId);
    //        Assert.Equal("Finance", firstRole.Department);
    //        Assert.Equal(8, firstRole.UnitId);
    //        Assert.Equal("Revenue", firstRole.Unit);
    //        Assert.Equal("creator1", firstRole.CreatedBy.Trim());
    //        Assert.Equal("approver1", firstRole.ApprovedBy.Trim());
    //        Assert.Equal("Approved", firstRole.Status);

    //        // Verify second role
    //        var secondRole = result[2];
    //        Assert.Equal("RoleThree", secondRole.RoleName);
    //        Assert.Equal(2, secondRole.DepartmentId);
    //        Assert.Equal("Finance", secondRole.Department);
    //        Assert.Equal(7, secondRole.UnitId);
    //        Assert.Equal("Revenue", secondRole.Unit);
    //        Assert.Equal("creator2", secondRole.CreatedBy.Trim());
    //        Assert.Equal("approver2", secondRole.ApprovedBy.Trim());
    //        Assert.Equal("Approved", secondRole.Status);

    //        // Verify interactions
    //        _mockRoleManager.Verify(x => x.Roles, Times.Once);
    //        _mockUnitOfWork.Verify(x => x.Department.Get(It.IsAny<int>()), Times.Exactly(4));
    //        _mockUnitOfWork.Verify(x => x.DepartmentUnit.Get(It.IsAny<int>()), Times.Exactly(4));
        //}



    }
}

