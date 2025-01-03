using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class ActivityProfile : Profile
    {
		public ActivityProfile()
		{
            CreateMap<Activity, ActivityReadDto>();

            CreateMap<ActivityCreateDto, Activity>();
            CreateMap<ActivityUpdateDto, Activity>();
            CreateMap<ActivityDeleteDto, Activity>();
        }
	}
}

