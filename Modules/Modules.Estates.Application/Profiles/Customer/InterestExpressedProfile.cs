using System;
namespace Modules.Estates.Application.Profiles.Customer
{
	public class InterestExpressedProfile : Profile
	{
		public InterestExpressedProfile()
		{
            CreateMap<InterestExpressed, InterestExpressedReadDto>();
            CreateMap<InterestExpressedCreateDto, InterestExpressed>();
            CreateMap<InterestExpressedUpdateDto, InterestExpressed>();
            CreateMap<InterestExpressedDeleteDto, InterestExpressed>();
        }
	}
}

