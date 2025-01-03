using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class ActivityTypeProfile : Profile
    {
		public ActivityTypeProfile()
		{
            CreateMap<ActivityType, ActivityTypeReadDto>();

            CreateMap<ActivityTypeCreateDto, ActivityType>();
            CreateMap<ActivityTypeUpdateDto, ActivityType>();
            CreateMap<ActivityTypeDeleteDto, ActivityType>();
        }
	}
}

