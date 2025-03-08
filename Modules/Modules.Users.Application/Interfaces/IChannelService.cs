using System;
namespace Modules.Users.Application.Interfaces
{
	public interface IChannelService
	{
        Task<ChannelReadDto> AddChannelAsync(ChannelCreateDto values);
        Task<ChannelReadDto> UpdateChannelAsync(ChannelUpdateDto values);
        Task<IEnumerable<ChannelReadDto>> GetChannelAsync();
        Task<ChannelReadDto> GetChannelAsync(int value);
        Task<ChannelReadDto> GetChannelAsync(string value);

        Task<string> DeleteChannelAsync(int value);
    }
}

