namespace Modules.Property.Application.Profiles.Property;

public class LandUseProfile : Profile
{
	public LandUseProfile()
	{
		CreateMap<LandUse, LandUseReadDto>();

        CreateMap<LandUseCreateDto, LandUse>();
        CreateMap<LandUseUpdateDto, LandUse>();
        CreateMap<LandUseDeleteDto, LandUse>();

    }
}

