// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Linq.Expressions;
using AutoMapper;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.UseCases;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Domain.Interfaces.Entities;
using Moq;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserServices
{
    public class DepartmentUnitServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
        private readonly DepartmentUnitService _service;

        public DepartmentUnitServiceTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMapper = new Mock<IMapper>();
            _service = new DepartmentUnitService(_mockUnitOfWork.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task AddDepartmentUnitAsync_WithValidData_ShouldCreateDepartmentUnit()
        {
            // Arrange
            var createDto = new DepartmentUnitCreateDto
            (
                DepartmentId: 1,
                UnitId: 0,
                UnitName: "Test Unit",
                CreatedBy: "system"
            );

            var mockDepartmentUnitRepo = new Mock<IDepartmentUnitRepository>();
            _mockUnitOfWork.Setup(u => u.DepartmentUnit).Returns(mockDepartmentUnitRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete()).ReturnsAsync(1);

            // Act
            var result = await _service.AddDepartmentUnitAsync(createDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.DepartmentId);
            Assert.Equal(0, result.UnitId);
            Assert.Equal("Test Unit", result.UnitName);
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.Insert(It.IsAny<DepartmentUnit>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteDepartmentUnit_WithValidId_ShouldDeleteUnit()
        {
            // Arrange
            var unitId = 1;
            var existingUnit = new DepartmentUnit(1, 1, "Test Unit");

            _mockUnitOfWork.Setup(u => u.DepartmentUnit.Get(unitId))
                .ReturnsAsync(existingUnit);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.DeleteDepartmentUnit(unitId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("success", result.response);
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.Delete(It.IsAny<DepartmentUnit>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteDepartmentUnit_WithInvalidId_ShouldReturnNotFound()
        {
            // Arrange
            var unitId = 999;
            _mockUnitOfWork.Setup(u => u.DepartmentUnit.Get(unitId))
                .ReturnsAsync((DepartmentUnit)null!);

            // Act
            var result = await _service.DeleteDepartmentUnit(unitId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal("Not Found", result.response);
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.Delete(It.IsAny<DepartmentUnit>()), Times.Never);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Never);
        }

        [Fact]
        public async Task GetDepartmentUnitAsync_ShouldReturnAllUnits()
        {
            // Arrange
            var units = new List<DepartmentUnit>
        {
            new DepartmentUnit(1, 1, "Unit 1"),
            new DepartmentUnit(1, 2, "Unit 2")
        };

            var expectedDtos = new List<DepartmentUnitReadDto>
        {
            new DepartmentUnitReadDto(1, 1, "Unit 1"),
            new DepartmentUnitReadDto(1, 2, "Unit 2")
        };

            _mockUnitOfWork.Setup(u => u.DepartmentUnit.GetAll())
                .ReturnsAsync(units);
            _mockMapper.Setup(m => m.Map<IEnumerable<DepartmentUnitReadDto>>(units))
                .Returns(expectedDtos);

            // Act
            var result = await _service.GetDepartmentUnitAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.GetAll(), Times.Once);
        }

        [Fact]
        public async Task GetDepartmentUnitAsync_ByDepartmentId_ShouldReturnUnits()
        {
            // Arrange
            var departmentId = 1;
            var units = new List<DepartmentUnit>
            {
                new DepartmentUnit(1, 1, "Unit 1"),
                new DepartmentUnit(1, 2, "Unit 2")
            };

            var expectedDtos = new List<DepartmentUnitReadDto>
            {
                new DepartmentUnitReadDto(1, 1, "Unit 1"),
                new DepartmentUnitReadDto(1, 2, "Unit 2")
            };

            _mockUnitOfWork.Setup(u => u.DepartmentUnit.GetAll(It.IsAny<Expression<Func<DepartmentUnit, bool>>>(), default, default))
                .ReturnsAsync(units);

            //_mockUnitOfWork.Setup(u => u.DepartmentUnit.GetAll(
            //        It.IsAny<Expression<Func<DepartmentUnit, bool>>>(),
            //        It.IsAny<Func<IQueryable<DepartmentUnit>, IOrderedQueryable<DepartmentUnit>>>(),
            //        It.IsAny<List<string>>()
            //    ))
            //    .ReturnsAsync(units);


            _mockMapper.Setup(m => m.Map<IEnumerable<DepartmentUnitReadDto>>(units))
                .Returns(expectedDtos);

            // Act
            var result = await _service.GetDepartmentUnitAsync(departmentId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.GetAll(It.IsAny<Expression<Func<DepartmentUnit, bool>>>(), default, default), Times.Once);
        }

        [Fact]
        public async Task UpdateDepartmentUnitAsync_WithValidData_ShouldUpdateUnit()
        {
            // Arrange
            var updateDto = new DepartmentUnitUpdateDto
            (
                DepartmentId: 1,
                UnitId: 1,
                UnitName: "Updated Unit",
                ModifiedBy: "system"
            );

            var mockDepartmentUnitRepo = new Mock<IDepartmentUnitRepository>();
            _mockUnitOfWork.Setup(u => u.DepartmentUnit).Returns(mockDepartmentUnitRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.UpdateDepartmentUnitAsync(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.DepartmentId);
            Assert.Equal(1, result.UnitId);
            Assert.Equal("Updated Unit", result.UnitName);
            _mockUnitOfWork.Verify(u => u.DepartmentUnit.Update(It.IsAny<DepartmentUnit>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }
    }
}

