using AutoMapper;
using Microsoft.AspNetCore.Http;
using Moq;
using Modules.Estates.Application.DTO.Setup.Property;
using Modules.Estates.Application.UseCases.Setup.Property;
using Modules.Estates.Domain.Entities.Setup.Property;
using Modules.Estates.Domain;
using System.Linq.Expressions;

namespace Modules.Estates.UnitTest.ApplicationLayer.Setups
{
    public class PropertyTypeServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly PropertyTypeService _propertyTypeService;

        public PropertyTypeServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _propertyTypeService = new PropertyTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetPropertyTypeAsync_ShouldReturnAllPropertyTypes()
        {
            // Arrange
            var propertyTypes = new List<PropertyType>();
            var propertyTypeDtos = new List<PropertyTypeReadDto>();
            _unitOfWorkMock.Setup(x => x.PropertyType.GetAll()).ReturnsAsync(propertyTypes);
            _mapperMock.Setup(x => x.Map<IEnumerable<PropertyTypeReadDto>>(propertyTypes)).Returns(propertyTypeDtos);

            // Act
            var result = await _propertyTypeService.GetPropertyTypeAsync();

            // Assert
            Assert.Equal(propertyTypeDtos, result);
            _unitOfWorkMock.Verify(x => x.PropertyType.GetAll(), Times.Once);
        }

        [Fact]
        public async Task GetPropertyTypeAsync_WithValidId_ShouldReturnPropertyType()
        {
            // Arrange
            int propertyTypeId = 1;
            var propertyType = new PropertyType(propertyTypeId, "TYPE");
            var propertyTypeDto = new PropertyTypeReadDto(propertyTypeId, "TYPE");
            _unitOfWorkMock.Setup(x => x.PropertyType.Get(propertyTypeId)).ReturnsAsync(propertyType);
            _mapperMock.Setup(x => x.Map<PropertyTypeReadDto>(propertyType)).Returns(propertyTypeDto);

            // Act
            var result = await _propertyTypeService.GetPropertyTypeAsync(propertyTypeId);

            // Assert
            Assert.Equal(propertyTypeDto, result);
            _unitOfWorkMock.Verify(x => x.PropertyType.Get(propertyTypeId), Times.Once);
        }

        [Fact]
        public async Task GetPropertyTypeAsync_WithValidString_ShouldReturnPropertyType()
        {
            // Arrange
            string value = "test";
            var propertyType = new PropertyType(1, "TYPE");
            var propertyTypeDto = new PropertyTypeReadDto(1, "TYPE");
            _unitOfWorkMock.Setup(x => x.PropertyType.Get(It.IsAny<Expression<Func<PropertyType, bool>>>(), null)).ReturnsAsync(propertyType);
            _mapperMock.Setup(x => x.Map<PropertyTypeReadDto>(propertyType)).Returns(propertyTypeDto);

            // Act
            var result = await _propertyTypeService.GetPropertyTypeAsync(value);

            // Assert
            Assert.Equal(propertyTypeDto, result);
            _unitOfWorkMock.Verify(x => x.PropertyType.Get(It.IsAny<Expression<Func<PropertyType, bool>>>(), null), Times.Once);
        }

        [Fact]
        public async Task CreatePropertyTypeAsync_WithValidData_ShouldCreatePropertyType()
        {
            // Arrange
            var createDto = new PropertyTypeCreateDto
            (
                PropertyTypes: "Test Type",
                CreatedBy: "testuser"
            );

            var propertyType = PropertyType.Create(0, createDto.PropertyTypes!);
            var propertyTypeDto = new PropertyTypeReadDto(0, createDto.PropertyTypes!);

            _unitOfWorkMock.Setup(x => x.PropertyType.Get(It.IsAny<Expression<Func<PropertyType, bool>>>(), null)).ReturnsAsync((PropertyType)null!);
            _mapperMock.Setup(x => x.Map<PropertyTypeReadDto>(It.IsAny<PropertyType>())).Returns(propertyTypeDto);

            // Act
            var result = await _propertyTypeService.CreatePropertyTypeAsync(createDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PropertyType.Insert(It.IsAny<PropertyType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task CreatePropertyTypeAsync_WithExistingName_ShouldReturnError()
        {
            // Arrange
            var createDto = new PropertyTypeCreateDto
            (
                PropertyTypes: "Test Type",
                CreatedBy: "testuser"
            );

            var existingPropertyType = PropertyType.Create(2, "Test Type");
            _unitOfWorkMock.Setup(x => x.PropertyType.Get(It.IsAny<Expression<Func<PropertyType, bool>>>(), null)).ReturnsAsync(existingPropertyType);

            // Act
            var result = await _propertyTypeService.CreatePropertyTypeAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
            Assert.Equal("Property Type already exists.", result.ErrorResponse.Message);
        }

        [Fact]
        public async Task UpdatePropertyTypeAsync_WithValidData_ShouldUpdatePropertyType()
        {
            // Arrange
            var updateDto = new PropertyTypeUpdateDto
            (
                PropertyTypeId: 1,
                PropertyTypes: "Updated Type",
                ModifiedBy: "testuser"
            );

            var existingPropertyType = PropertyType.Create(1, "Old Type");
            var propertyTypeDto = new PropertyTypeReadDto(1, "Old Type");

            _unitOfWorkMock.Setup(x => x.PropertyType.Get(updateDto.PropertyTypeId)).ReturnsAsync(existingPropertyType);
            _mapperMock.Setup(x => x.Map<PropertyTypeReadDto>(It.IsAny<PropertyType>())).Returns(propertyTypeDto);

            // Act
            var result = await _propertyTypeService.UpdatePropertyTypeAsync(updateDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PropertyType.Update(It.IsAny<PropertyType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task UpdatePropertyTypeAsync_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            var updateDto = new PropertyTypeUpdateDto
            (
                PropertyTypeId: 999,
                PropertyTypes: "Test Type",
                ModifiedBy: "testuser"
            );

            _unitOfWorkMock.Setup(x => x.PropertyType.Get(updateDto.PropertyTypeId)).ReturnsAsync((PropertyType)null!);

            // Act
            var result = await _propertyTypeService.UpdatePropertyTypeAsync(updateDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }

        [Fact]
        public async Task DeleteBPropertyType_WithValidId_ShouldDeleteBPropertyType()
        {
            // Arrange
            int propertyTypeId = 1;
            var existingPropertyType = PropertyType.Create(propertyTypeId, "Test Type");
            _unitOfWorkMock.Setup(x => x.PropertyType.Get(propertyTypeId)).ReturnsAsync(existingPropertyType);

            // Act
            var result = await _propertyTypeService.DeletePropertyType(propertyTypeId);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PropertyType.Delete(It.IsAny<PropertyType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteBPropertyType_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            int propertyTypeId = 999;
            _unitOfWorkMock.Setup(x => x.PropertyType.Get(propertyTypeId)).ReturnsAsync((PropertyType)null!);

            // Act
            var result = await _propertyTypeService.DeletePropertyType(propertyTypeId);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }
    }
}