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
    public class FloorAreaServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWorkMock;
        private readonly Mock<IMapper> _mapperMock;
        private readonly FloorAreaService _floorAreaService;

        public FloorAreaServiceTests()
        {
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _mapperMock = new Mock<IMapper>();
            _floorAreaService = new FloorAreaService(_unitOfWorkMock.Object, _mapperMock.Object);
        }

        [Fact]
        public async Task GetFloorAreaAsync_ShouldReturnAllFloorAreas()
        {
            // Arrange
            var floorArea = new List<FloorArea>();
            var floorAreaDtos = new List<FloorAreaReadDto>();
            _unitOfWorkMock.Setup(x => x.FloorArea.GetAll()).ReturnsAsync(floorArea);
            _mapperMock.Setup(x => x.Map<IEnumerable<FloorAreaReadDto>>(floorArea)).Returns(floorAreaDtos);

            // Act
            var result = await _floorAreaService.GetFloorAreaAsync();

            // Assert
            Assert.Equal(floorAreaDtos, result);
            _unitOfWorkMock.Verify(x => x.FloorArea.GetAll(), Times.Once);
        }

        [Fact]
        public async Task GetFloorAreaAsync_WithValidId_ShouldReturnFlooArea()
        {
            // Arrange
            int floorAreaId = 1;
            var floorArea = new FloorArea(floorAreaId, 102.56m);
            var floorAreaDto = new FloorAreaReadDto(floorAreaId, 102.56m);
            _unitOfWorkMock.Setup(x => x.FloorArea.Get(floorAreaId)).ReturnsAsync(floorArea);
            _mapperMock.Setup(x => x.Map<FloorAreaReadDto>(floorArea)).Returns(floorAreaDto);

            // Act
            var result = await _floorAreaService.GetFloorAreaAsync(floorAreaId);

            // Assert
            Assert.Equal(floorAreaDto, result);
            _unitOfWorkMock.Verify(x => x.FloorArea.Get(floorAreaId), Times.Once);
        }

        [Fact]
        public async Task GetFloorAreaAsync_WithValidString_ShouldReturnFloorArea()
        {
            // Arrange
            decimal value = 120.32m;
            var floorArea = new FloorArea(1, 102.56m);
            var floorAreaDto = new FloorAreaReadDto(1, 102.56m);
            _unitOfWorkMock.Setup(x => x.FloorArea.Get(It.IsAny<Expression<Func<FloorArea, bool>>>(), null)).ReturnsAsync(floorArea);
            _mapperMock.Setup(x => x.Map<FloorAreaReadDto>(floorArea)).Returns(floorAreaDto);

            // Act
            var result = await _floorAreaService.GetFloorAreaAsync(value);

            // Assert
            Assert.Equal(floorAreaDto, result);
            _unitOfWorkMock.Verify(x => x.FloorArea.Get(It.IsAny<Expression<Func<FloorArea, bool>>>(), null), Times.Once);
        }

        [Fact]
        public async Task CreateFloorAreaAsync_WithValidData_ShouldCreateFloorArea()
        {
            // Arrange
            var createDto = new FloorAreaCreateDto
            (
                area: 153.45m,
                createdBy: "testuser"
            );

            var floorArea = FloorArea.Create(0, createDto.area);
            var floorAreaDto = new FloorAreaReadDto(0, createDto.area);

            _unitOfWorkMock.Setup(x => x.FloorArea.Get(It.IsAny<Expression<Func<FloorArea, bool>>>(), null)).ReturnsAsync((FloorArea)null!);
            _mapperMock.Setup(x => x.Map<FloorAreaReadDto>(It.IsAny<FloorArea>())).Returns(floorAreaDto);

            // Act
            var result = await _floorAreaService.CreateFloorAreaAsync(createDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status201Created, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.FloorArea.Insert(It.IsAny<FloorArea>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task CreateFloorAreaAsync_WithExistingArea_ShouldReturnError()
        {
            // Arrange
            var createDto = new FloorAreaCreateDto
            (
                area: 153.45m,
                createdBy: "testuser"
            );

            var existingFacility = FloorArea.Create(2, 153.45m);
            _unitOfWorkMock.Setup(x => x.FloorArea.Get(It.IsAny<Expression<Func<FloorArea, bool>>>(), null)).ReturnsAsync(existingFacility);

            // Act
            var result = await _floorAreaService.CreateFloorAreaAsync(createDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status400BadRequest, result.ErrorResponse!.Code);
            Assert.Equal("Floor Area already exists.", result.ErrorResponse.Message);
        }

        [Fact]
        public async Task UpdateFloorAreaAsync_WithValidData_ShouldUpdateFacility()
        {
            // Arrange
            var updateDto = new FloorAreaUpdateDto
            (
                floorAreaId: 1,
                area: 620.56m,
                modifiedBy: "testuser"
            );

            var existingfloorArea = FloorArea.Create(1, 620.56m);
            var floorAreaDto = new FloorAreaReadDto(1, 620.56m);

            _unitOfWorkMock.Setup(x => x.FloorArea.Get(updateDto.floorAreaId)).ReturnsAsync(existingfloorArea);
            _mapperMock.Setup(x => x.Map<FloorAreaReadDto>(It.IsAny<FloorArea>())).Returns(floorAreaDto);

            // Act
            var result = await _floorAreaService.UpdateFloorAreaAsync(updateDto);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.FloorArea.Update(It.IsAny<FloorArea>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task UpdateFloorAreaAsync_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            var updateDto = new FloorAreaUpdateDto
            (
                floorAreaId: 999,
                area: 450.32m,
                modifiedBy: "testuser"
            );

            _unitOfWorkMock.Setup(x => x.FloorArea.Get(updateDto.floorAreaId)).ReturnsAsync((FloorArea)null!);

            // Act
            var result = await _floorAreaService.UpdateFloorAreaAsync(updateDto);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }

        [Fact]
        public async Task DeleteFloorArea_WithValidId_ShouldDeleteFacility()
        {
            // Arrange
            int floorAreaId = 1;
            var existingFloorArea = FloorArea.Create(floorAreaId, 310.56m);
            _unitOfWorkMock.Setup(x => x.FloorArea.Get(floorAreaId)).ReturnsAsync(existingFloorArea);

            // Act
            var result = await _floorAreaService.DeleteFloorArea(floorAreaId);

            // Assert
            Assert.True(result.IsSuccess);
            Assert.Equal(StatusCodes.Status200OK, result.SuccessResponse!.Code);
            _unitOfWorkMock.Verify(x => x.FloorArea.Delete(It.IsAny<FloorArea>()), Times.Once);
            _unitOfWorkMock.Verify(x => x.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteFloorArea_WithNonExistentId_ShouldReturnError()
        {
            // Arrange
            int facilityId = 999;
            _unitOfWorkMock.Setup(x => x.FloorArea.Get(facilityId)).ReturnsAsync((FloorArea)null!);

            // Act
            var result = await _floorAreaService.DeleteFloorArea(facilityId);

            // Assert
            Assert.False(result.IsSuccess);
            Assert.Equal(StatusCodes.Status404NotFound, result.ErrorResponse!.Code);
        }
    }
}