using System;
using AutoMapper;
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Application.UseCases;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Interfaces;
using Modules.Users.Domain.Interfaces.Entities;
using Moq;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserServices
{
    public class IdentificationTypeServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
        private readonly IdentificationTypeService _service;

        public IdentificationTypeServiceTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMapper = new Mock<IMapper>();
            _service = new IdentificationTypeService(_mockUnitOfWork.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task AddIdentificationTypeAsync_WithValidData_ShouldCreateIdentificationType()
        {
            // Arrange
            var createDto = new IdentificationTypeDto
            (
                identificationTypeId: 1,
                identificationTypes: "National ID"
            );

            var mockIdentificationTypeRepo = new Mock<IIdentificationTypeRepository>();
            _mockUnitOfWork.Setup(u => u.IdentificationType).Returns(mockIdentificationTypeRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.AddIdentificationTypeAsync(createDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.identificationTypeId);
            Assert.Equal("National ID", result.identificationTypes);
            _mockUnitOfWork.Verify(u => u.IdentificationType.Insert(It.IsAny<IdentificationType>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteIdentificationTypeAsync_WithValidId_ShouldDelete()
        {
            // Arrange
            var typeId = 1;
            var existingType = new IdentificationType(1, "National ID");

            _mockUnitOfWork.Setup(u => u.IdentificationType.Get(typeId))
                .ReturnsAsync(existingType);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.DeleteIdentificationTypeAsync(typeId);

            // Assert
            Assert.Equal("success", result);
            _mockUnitOfWork.Verify(u => u.IdentificationType.Delete(It.IsAny<IdentificationType>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteIdentificationTypeAsync_WithInvalidId_ShouldReturnBadRequest()
        {
            // Arrange
            var typeId = 999;
            _mockUnitOfWork.Setup(u => u.IdentificationType.Get(typeId))
                .ReturnsAsync((IdentificationType)null!);

            // Act
            var result = await _service.DeleteIdentificationTypeAsync(typeId);

            // Assert
            Assert.Equal("BadRequest", result);
            _mockUnitOfWork.Verify(u => u.IdentificationType.Delete(It.IsAny<IdentificationType>()), Times.Never);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Never);
        }

        [Fact]
        public async Task GetIdentificationTypeAsync_ShouldReturnAllTypes()
        {
            // Arrange
            var types = new List<IdentificationType>
        {
            new IdentificationType(1, "National ID"),
            new IdentificationType(2, "Passport")
        };

            var expectedDtos = new List<IdentificationTypeDto>
        {
            new IdentificationTypeDto(1, "National ID"),
            new IdentificationTypeDto(2, "Passport")
        };

            _mockUnitOfWork.Setup(u => u.IdentificationType.GetAll())
                .ReturnsAsync(types);
            _mockMapper.Setup(m => m.Map<IEnumerable<IdentificationTypeDto>>(types))
                .Returns(expectedDtos);

            // Act
            var result = await _service.GetIdentificationTypeAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            _mockUnitOfWork.Verify(u => u.IdentificationType.GetAll(), Times.Once);
        }

        [Fact]
        public async Task UpdateIdentificationTypeAsync_WithValidData_ShouldUpdate()
        {
            // Arrange
            var updateDto = new IdentificationTypeDto
            (
                identificationTypeId: 1,
                identificationTypes: "Updated ID Type"
            );

            var mockIdentificationTypeRepo = new Mock<IIdentificationTypeRepository>();
            _mockUnitOfWork.Setup(u => u.IdentificationType).Returns(mockIdentificationTypeRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.UpdateIdentificationTypeAsync(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.identificationTypeId);
            Assert.Equal("Updated ID Type", result.identificationTypes);
            _mockUnitOfWork.Verify(u => u.IdentificationType.Update(It.IsAny<IdentificationType>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }
    }
}


