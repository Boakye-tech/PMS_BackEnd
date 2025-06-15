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
    public class PlotTypeServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly PlotTypeService _plotTypeService;

        public PlotTypeServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _plotTypeService = new PlotTypeService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetPlotTypeAsync_ShouldReturnAllPlotTypes()
        {
            // Arrange
            var plotTypes = new List<PlotType>();
            var plotTypeDtos = new List<PlotTypeReadDto>();
            _unitOfWorkMock.Setup(x => x.PlotType.GetAll()).ReturnsAsync(plotTypes);
            _mapperMock.Setup(x => x.Map<IEnumerable<PlotTypeReadDto>>(plotTypes)).Returns(plotTypeDtos);

            // Act
            var result = await _plotTypeService.GetPlotTypeAsync();

            // Assert
            Assert.Equal(plotTypeDtos, result);
            _unitOfWorkMock.Verify(x => x.PlotType.GetAll(), Times.Once);
        }


        [Fact]
        public async Task CreatePlotTypeAsync_WithValidData_ShouldCreatePlotType()
        {
            // Arrange
            var createDto = new PlotTypeCreateDto
            (
                PlotTypes: "Test Type",
                CreatedBy: "testuser"
            );

            var plotType = PlotType.Create(0, createDto.PlotTypes!);
            var plotTypeDto = new PlotTypeReadDto(0, createDto.PlotTypes!);

            _unitOfWorkMock.Setup(x => x.PlotType.Get(It.IsAny<Expression<Func<PlotType, bool>>>(), null)).ReturnsAsync((PlotType)null!);
            _mapperMock.Setup(x => x.Map<PlotTypeReadDto>(It.IsAny<PlotType>())).Returns(plotTypeDto);

            // Act
            var result = await _plotTypeService.CreatePlotTypeAsync(createDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PlotType.Insert(It.IsAny<PlotType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task CreatePlotTypeAsync_WithExistingName_ShouldReturnError()
        {
            // Arrange
            var createDto = new PlotTypeCreateDto
            (
                PlotTypes: "Test Type",
                CreatedBy: "testuser"
            );

            var existingPlotType = PlotType.Create(2, "Test Type");
            _unitOfWorkMock.Setup(x => x.PlotType.Get(It.IsAny<Expression<Func<PlotType, bool>>>(), null)).ReturnsAsync(existingPlotType);

            // Act
            var result = await _plotTypeService.CreatePlotTypeAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
            Assert.Equal("Property Type already exists.", result.ErrorResponse.Message);
        }

        [Fact]
        public async Task UpdatePlotTypeAsync_WithValidData_ShouldUpdatePlotType()
        {
            // Arrange
            var updateDto = new PlotTypeUpdateDto
            (
                PlotTypeId: 1,
                PlotTypes: "Updated Type",
                ModifiedBy: "testuser"
            );

            var existingPlotType = PlotType.Create(1, "Old Type");
            var PlotTypeDto = new PlotTypeReadDto(1, "Old Type");

            _unitOfWorkMock.Setup(x => x.PlotType.Get(updateDto.PlotTypeId)).ReturnsAsync(existingPlotType);
            _mapperMock.Setup(x => x.Map<PlotTypeReadDto>(It.IsAny<PlotType>())).Returns(PlotTypeDto);

            // Act
            var result = await _plotTypeService.UpdatePlotTypeAsync(updateDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PlotType.Update(It.IsAny<PlotType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task UpdatePlotTypeAsync_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            var updateDto = new PlotTypeUpdateDto
            (
                PlotTypeId: 999,
                PlotTypes: "Test Type",
                ModifiedBy: "testuser"
            );

            _unitOfWorkMock.Setup(x => x.PlotType.Get(updateDto.PlotTypeId)).ReturnsAsync((PlotType)null!);

            // Act
            var result = await _plotTypeService.UpdatePlotTypeAsync(updateDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }

        [Fact]
        public async Task DeleteBPlotType_WithValidId_ShouldDeleteBPlotType()
        {
            // Arrange
            int PlotTypeId = 1;
            var existingPlotType = PlotType.Create(PlotTypeId, "Test Type");
            _unitOfWorkMock.Setup(x => x.PlotType.Get(PlotTypeId)).ReturnsAsync(existingPlotType);

            // Act
            var result = await _plotTypeService.DeletePlotType(PlotTypeId);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.PlotType.Delete(It.IsAny<PlotType>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteBPlotType_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            int PlotTypeId = 999;
            _unitOfWorkMock.Setup(x => x.PlotType.Get(PlotTypeId)).ReturnsAsync((PlotType)null!);

            // Act
            var result = await _plotTypeService.DeletePlotType(PlotTypeId);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }
    }
}