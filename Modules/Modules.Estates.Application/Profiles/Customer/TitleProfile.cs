using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class TitleProfile : Profile
    {
		public TitleProfile()
		{
			CreateMap<Title, TitleReadDto>();
            CreateMap<TitleCreateDto, Title>();
            CreateMap<TitleUpdateDto, Title>();
            CreateMap<TitleDeleteDto, Title>();
        }
	}
}

