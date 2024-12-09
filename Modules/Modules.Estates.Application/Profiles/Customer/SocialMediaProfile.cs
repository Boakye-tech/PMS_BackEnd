using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class SocialMediaProfile : Profile
    {
		public SocialMediaProfile()
		{
            CreateMap<SocialMedia, SocialMediaReadDto>();

            CreateMap<SocialMediaCreateDto, SocialMedia>();
            CreateMap<SocialMediaUpdateDto, SocialMedia>();
            CreateMap<SocialMediaDeleteDto, SocialMedia>();
        }
	}
}

