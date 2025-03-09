using System;

namespace Modules.Users.Application.Profiles
{
	public class ChannelsProfile : Profile
    {
		public ChannelsProfile()
		{
			CreateMap<Channels, ChannelReadDto>();
            CreateMap<ChannelCreateDto, Channels>();
            CreateMap<ChannelUpdateDto, Channels>();
            CreateMap<ChannelDeleteDto, Channels>();

        }
    }
}

