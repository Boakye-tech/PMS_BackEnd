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
using Microsoft.AspNetCore.Http;
using Modules.Users.Application.Interfaces.UserAccounts;
using Modules.Users.Application.Interfaces;
using Modules.Common.Infrastructure.Authentication;
using Modules.Users.Presentation.Controllers.v1;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Shared;


namespace Modules.Users.UnitTest.PresentationLayer
{
    public class AdministrationControllerTests
    {
        private readonly Mock<IAdministrationService> _mockAdminService;
        private readonly Mock<IMenuService> _mockMenuService;
        private readonly Mock<IDepartmentService> _mockDepartmentService;
        private readonly Mock<IDepartmentUnitService> _mockDepartmentUnitService;
        private readonly Mock<IChannelService> _mockChannelService;
        private readonly Mock<IIdentificationTypeService> _mockIdentificationTypeService;
        private readonly Mock<IUserContextService> _mockUserContextService;
        private readonly AdministrationController _controller;

        public AdministrationControllerTests()
        {
            _mockAdminService = new Mock<IAdministrationService>();
            _mockMenuService = new Mock<IMenuService>();
            _mockDepartmentService = new Mock<IDepartmentService>();
            _mockDepartmentUnitService = new Mock<IDepartmentUnitService>();
            _mockChannelService = new Mock<IChannelService>();
            _mockIdentificationTypeService = new Mock<IIdentificationTypeService>();
            _mockUserContextService = new Mock<IUserContextService>();

            _controller = new AdministrationController(
                _mockAdminService.Object,
                _mockDepartmentService.Object,
                _mockDepartmentUnitService.Object,
                _mockMenuService.Object,
                _mockChannelService.Object,
                _mockIdentificationTypeService.Object,
                _mockUserContextService.Object
            );
        }

        [Fact]
        public async Task GetChannels_ShouldReturnListOfChannels()
        {
            // Arrange
            var channels = new List<ChannelReadDto>
            {
                new ChannelReadDto(1, "Web"),
                new ChannelReadDto(2, "Mobile")
            };

            _mockChannelService.Setup(x => x.GetChannelAsync())
                .ReturnsAsync(channels);

            // Act
            var result = await _controller.GetChannels();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var returnValue = Assert.IsAssignableFrom<IEnumerable<ChannelReadDto>>(okResult.Value);
            Assert.Equal(2, returnValue.Count());
        }

        [Fact]
        public async Task CreateChannel_WithValidData_ShouldReturnCreated()
        {
            // Arrange
            var channelDto = new ChannelCreateDto
            (
                1,
                "New Channel",
                "testUserId"
            );

            _mockUserContextService.Setup(x => x.GetUserId())
                .Returns("testUserId");

            _mockChannelService.Setup(x => x.AddChannelAsync(channelDto))
                .ReturnsAsync(new ChannelReadDto(1, "New Channel"));

            // Act
            var result = await _controller.CreateChannel(channelDto);

            // Assert
            var createdResult = Assert.IsType<ObjectResult>(result.Result);
            Assert.Equal(StatusCodes.Status201Created, createdResult.StatusCode);
        }

        [Fact]
        public async Task ApproveUserAccount_WithValidData_ShouldReturnOk()
        {
            // Arrange
            var approvalDto = new ApproveUserAccountDto
            (
                "testUserId",
                "roleId",
                "approverUserId"
            );

            _mockUserContextService.Setup(x => x.GetUserId())
                .Returns("approverUserId");

            var successResponse = new ApproveUserAccountResponseDto
            {
                IsSuccess = true,
                SuccessResponse = new ApproveUserAccountSuccessResponseDto
                {
                    StatusCode = StatusCodes.Status200OK,
                    StatusMessage = "Successfully approved"
                }
            };

            _mockAdminService.Setup(x => x.ApproveUserAccount(approvalDto))
                .ReturnsAsync(successResponse);

            // Act
            var result = await _controller.ApproveUserAccount(approvalDto);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
            Assert.NotNull(okResult.Value);
        }

        [Fact]
        public async Task GetUserRoles_AsAdmin_ShouldReturnAllRoles()
        {
            // Arrange
            var roles = new List<RolesDto>
            {
                new RolesDto("1", "Admin", 1, "IT", 1, "Development", "creator", DateTime.Now, "approver", DateTime.Now, "Active"),
                new RolesDto("2", "User", 1, "IT", 1, "Development", "creator", DateTime.Now, "approver", DateTime.Now, "Active")
            };

            _mockUserContextService.Setup(x => x.GetUserRole("MISAdministrator"))
                .Returns(true);

            _mockAdminService.Setup(x => x.GetUserRoles())
                .ReturnsAsync(roles);

            // Act
            var result = await _controller.GetUserRoles(0, 0);

            // Assert
            Assert.Equal(2, result.Count);
        }

        [Fact]
        public async Task CreateDepartment_WithValidData_ShouldReturnCreated()
        {
            // Arrange
            var departmentDto = new DepartmentCreateDto
            (
                1,
                "New Department",
                "testUserId"
            );

            _mockUserContextService.Setup(x => x.GetUserId())
                .Returns("testUserId");

            _mockDepartmentService.Setup(x => x.AddDepartmentAsync(departmentDto))
                .ReturnsAsync(new DepartmentReadDto(1, "New Department"));

            // Act
            var result = await _controller.CreateDepartment(departmentDto);

            // Assert
            var createdResult = Assert.IsType<ObjectResult>(result.Result);

        }
    }
}