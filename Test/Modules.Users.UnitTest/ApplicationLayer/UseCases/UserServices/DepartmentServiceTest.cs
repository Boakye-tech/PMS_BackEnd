// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



using Moq;
using AutoMapper;
using Modules.Users.Domain.Entities;
using Modules.Users.Application.UseCases;
using Modules.Users.Domain.Interfaces;
using global::Modules.Users.Application.Dtos.Entities;
using System.Linq.Expressions;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserServices
{
    public class DepartmentServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
        private readonly DepartmentService _service;

        public DepartmentServiceTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMapper = new Mock<IMapper>();
            _service = new DepartmentService(_mockUnitOfWork.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task AddDepartmentAsync_WithValidData_ShouldCreateDepartment()
        {
            // Arrange
            var createDto = new DepartmentCreateDto
            (
                DepartmentId: 0,
                DepartmentName: "Test Department",
                CreatedBy: "system"
            );

            var mockDepartmentRepo = new Mock<IDepartmentRepository>();
            _mockUnitOfWork.Setup(u => u.Department).Returns(mockDepartmentRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.AddDepartmentAsync(createDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(0, result.DepartmentId);
            Assert.Equal("Test Department", result.DepartmentName);
            _mockUnitOfWork.Verify(u => u.Department.Insert(It.IsAny<Department>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteDepartment_WithValidId_ShouldDeleteDepartment()
        {
            // Arrange
            var departmentId = 1;
            var existingDepartment = new Department(1, "Test Department");

            _mockUnitOfWork.Setup(u => u.Department.Get(departmentId))
                .ReturnsAsync(existingDepartment);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.DeleteDepartment(departmentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("success", result.response);
            _mockUnitOfWork.Verify(u => u.Department.Delete(It.IsAny<Department>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteDepartment_WithInvalidId_ShouldReturnNotFound()
        {
            // Arrange
            var departmentId = 999;
            _mockUnitOfWork.Setup(u => u.Department.Get(departmentId))
                .ReturnsAsync((Department)null!);

            // Act
            var result = await _service.DeleteDepartment(departmentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Found", result.response);
            _mockUnitOfWork.Verify(u => u.Department.Delete(It.IsAny<Department>()), Times.Never);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Never);
        }

        [Fact]
        public async Task GetDepartmentAsync_ShouldReturnAllDepartments()
        {
            // Arrange
            var departments = new List<Department>
            {
                new Department(1, "Department 1"),
                new Department(2, "Department 2")
            };

            var expectedDtos = new List<DepartmentReadDto>
            {
                new DepartmentReadDto(1, "Department 1"),
                new DepartmentReadDto(2, "Department 2")
            };

            _mockUnitOfWork.Setup(u => u.Department.GetAll())
                .ReturnsAsync(departments);
            _mockMapper.Setup(m => m.Map<IEnumerable<DepartmentReadDto>>(departments))
                .Returns(expectedDtos);

            // Act
            var result = await _service.GetDepartmentAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Collection(result,
                item => Assert.Equal("Department 1", item.DepartmentName),
                item => Assert.Equal("Department 2", item.DepartmentName)
            );
            _mockUnitOfWork.Verify(u => u.Department.GetAll(), Times.Once);
        }

        [Fact]
        public async Task GetDepartmentAsync_ById_ShouldReturnDepartment()
        {
            // Arrange
            var departmentId = 1;
            var department = new Department(1, "Test Department");
            var expectedDto = new DepartmentReadDto(1, "Test Department");

            _mockUnitOfWork.Setup(u => u.Department.Get(departmentId))
                .ReturnsAsync(department);
            _mockMapper.Setup(m => m.Map<DepartmentReadDto>(department))
                .Returns(expectedDto);

            // Act
            var result = await _service.GetDepartmentAsync(departmentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(departmentId, result.DepartmentId);
            Assert.Equal("Test Department", result.DepartmentName);
            _mockUnitOfWork.Verify(u => u.Department.Get(departmentId), Times.Once);
        }

        [Fact]
        public async Task GetDepartmentAsync_ByName_ShouldReturnDepartment()
        {
            // Arrange
            var departmentName = "Test Department";
            var department = new Department(1, departmentName);
            var expectedDto = new DepartmentReadDto(1, departmentName);

            _mockUnitOfWork.Setup(u => u.Department.Get(It.IsAny<Expression<Func<Department, bool>>>(), null))
                .ReturnsAsync(department);
            _mockMapper.Setup(m => m.Map<DepartmentReadDto>(department))
                .Returns(expectedDto);

            // Act
            var result = await _service.GetDepartmentAsync(departmentName);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(departmentName, result.DepartmentName);
            _mockUnitOfWork.Verify(u => u.Department.Get(It.IsAny<Expression<Func<Department, bool>>>(), null), Times.Once);
        }

        [Fact]
        public async Task UpdateDepartmentAsync_WithValidData_ShouldUpdateDepartment()
        {
            // Arrange
            var updateDto = new DepartmentUpdateDto
            (
                DepartmentId: 1,
                DepartmentName: "Updated Department",
                ModifiedBy: "system"
            );

            var mockDepartmentRepo = new Mock<IDepartmentRepository>();
            _mockUnitOfWork.Setup(u => u.Department).Returns(mockDepartmentRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.UpdateDepartmentAsync(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.DepartmentId);
            Assert.Equal("Updated Department", result.DepartmentName);
            _mockUnitOfWork.Verify(u => u.Department.Update(It.IsAny<Department>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task AddDepartmentAsync_WithNullName_ShouldThrowException()
        {
            // Arrange
            var createDto = new DepartmentCreateDto
            (
                DepartmentId: 1,
                DepartmentName: null!,
                CreatedBy: "system"
            );

            var mockDepartmentRepo = new Mock<IDepartmentRepository>();
            _mockUnitOfWork.Setup(u => u.Department).Returns(mockDepartmentRepo.Object);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _service.AddDepartmentAsync(createDto));
        }

        [Fact]
        public async Task UpdateDepartmentAsync_WithNullName_ShouldThrowException()
        {
            // Arrange
            var updateDto = new DepartmentUpdateDto
            (
                DepartmentId: 1,
                DepartmentName: null!,
                ModifiedBy: "system"
            );

            var mockDepartmentRepo = new Mock<IDepartmentRepository>();
            _mockUnitOfWork.Setup(u => u.Department).Returns(mockDepartmentRepo.Object);

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _service.UpdateDepartmentAsync(updateDto));
        }


    }
}

