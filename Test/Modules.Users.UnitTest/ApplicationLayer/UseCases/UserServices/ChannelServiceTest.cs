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
using Modules.Users.Application.Dtos.Entities;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.UnitTest.ApplicationLayer.UseCases.UserServices
{
    public class ChannelServiceTests
    {
        private readonly Mock<IUnitOfWork> _mockUnitOfWork;
        private readonly Mock<IMapper> _mockMapper;
        private readonly ChannelService _service;

        public ChannelServiceTests()
        {
            _mockUnitOfWork = new Mock<IUnitOfWork>();
            _mockMapper = new Mock<IMapper>();
            _service = new ChannelService(_mockUnitOfWork.Object, _mockMapper.Object);
        }

        [Fact]
        public async Task AddChannelAsync_WithValidData_ShouldCreateChannel()
        {
            // Arrange
            var createDto = new ChannelCreateDto
            (
                ChannelId: 1,
                ChannelName: "Test Channel",
                CreatedBy: "system"
            );

            var mockChannelRepo = new Mock<IChannelsRepository>();
            _mockUnitOfWork.Setup(u => u.Channels).Returns(mockChannelRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.AddChannelAsync(createDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.ChannelId);
            Assert.Equal("Test Channel", result.ChannelName);
            _mockUnitOfWork.Verify(u => u.Channels.Insert(It.IsAny<Channels>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteChannelAsync_WithValidId_ShouldDeleteChannel()
        {
            // Arrange
            var channelId = 1;
            var existingChannel = new Channels(1, "Test Channel");

            _mockUnitOfWork.Setup(u => u.Channels.Get(channelId))
                .ReturnsAsync(existingChannel);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.DeleteChannelAsync(channelId);

            // Assert
            Assert.Equal("success", result);
            _mockUnitOfWork.Verify(u => u.Channels.Delete(It.IsAny<Channels>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task DeleteChannelAsync_WithInvalidId_ShouldReturnBadRequest()
        {
            // Arrange
            var channelId = 999;
            _mockUnitOfWork.Setup(u => u.Channels.Get(channelId))
                .ReturnsAsync((Channels)null!);

            // Act
            var result = await _service.DeleteChannelAsync(channelId);

            // Assert
            Assert.Equal("BadRequest", result);
            _mockUnitOfWork.Verify(u => u.Channels.Delete(It.IsAny<Channels>()), Times.Never);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Never);
        }

        [Fact]
        public async Task GetChannelAsync_ShouldReturnAllChannels()
        {
            // Arrange
            var channels = new List<Channels>
            {
                new Channels(1, "Channel 1"),
                new Channels(2, "Channel 2")
            };

            var expectedDtos = new List<ChannelReadDto>
            {
                new ChannelReadDto(1, "Channel 1"),
                new ChannelReadDto(2, "Channel 2")
            };

            _mockUnitOfWork.Setup(u => u.Channels.GetAll())
                .ReturnsAsync(channels);
            _mockMapper.Setup(m => m.Map<IEnumerable<ChannelReadDto>>(channels))
                .Returns(expectedDtos);

            // Act
            var result = await _service.GetChannelAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Collection(result,
                item => Assert.Equal("Channel 1", item.ChannelName),
                item => Assert.Equal("Channel 2", item.ChannelName)
            );
            _mockUnitOfWork.Verify(u => u.Channels.GetAll(), Times.Once);
        }

        [Fact]
        public async Task UpdateChannelAsync_WithValidData_ShouldUpdateChannel()
        {
            // Arrange
            var updateDto = new ChannelUpdateDto
            (
                ChannelId : 1,
                ChannelName : "Updated Channel",
                ModifiedBy : "system"
            );

            var mockChannelRepo = new Mock<IChannelsRepository>();
            _mockUnitOfWork.Setup(u => u.Channels).Returns(mockChannelRepo.Object);
            _mockUnitOfWork.Setup(u => u.Complete())
                .ReturnsAsync(1);

            // Act
            var result = await _service.UpdateChannelAsync(updateDto);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.ChannelId);
            Assert.Equal("Updated Channel", result.ChannelName);
            _mockUnitOfWork.Verify(u => u.Channels.Update(It.IsAny<Channels>()), Times.Once);
            _mockUnitOfWork.Verify(u => u.Complete(), Times.Once);
        }

        [Fact]
        public async Task GetChannelAsync_WithEmptyDatabase_ShouldReturnEmptyList()
        {
            // Arrange
            var emptyList = new List<Channels>();
            var emptyDtos = new List<ChannelReadDto>();

            _mockUnitOfWork.Setup(u => u.Channels.GetAll())
                .ReturnsAsync(emptyList);
            _mockMapper.Setup(m => m.Map<IEnumerable<ChannelReadDto>>(emptyList))
                .Returns(emptyDtos);

            // Act
            var result = await _service.GetChannelAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Empty(result);
            _mockUnitOfWork.Verify(u => u.Channels.GetAll(), Times.Once);
        }

        [Fact]
        public async Task AddChannelAsync_WithNullName_ShouldThrowException()
        {
            // Arrange
            var createDto = new ChannelCreateDto
            (
                ChannelId : 1,
                ChannelName : null!,
                CreatedBy : "system"
            );

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _service.AddChannelAsync(createDto));
        }

        [Fact]
        public async Task UpdateChannelAsync_WithNullName_ShouldThrowException()
        {
            // Arrange
            var updateDto = new ChannelUpdateDto
            (
                ChannelId : 1,
                ChannelName: null!,
                ModifiedBy : "system"
            );

            // Act & Assert
            await Assert.ThrowsAsync<ArgumentException>(() =>
                _service.UpdateChannelAsync(updateDto));
        }
    }
}
