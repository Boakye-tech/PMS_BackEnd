namespace Modules.Property.Application.Profiles.Property;

public class LandUseTypeProfile : Profile
{
	public LandUseTypeProfile()
	{
        CreateMap<LandUseType, LandUseTypeReadDto>();

        CreateMap<LandUseTypeCreateDto, LandUseType>();
        CreateMap<LandUseTypeUpdateDto, LandUseType>();
        CreateMap<LandUseTypeDeleteDto, LandUseType>();
    }
}

