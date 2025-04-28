// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

