namespace Modules.Property.Application.Profiles.Property;

public class LocalityProfile : Profile
{
	public LocalityProfile()
	{
		CreateMap<Locality, LocalityReadDto>();
        CreateMap<LocalityCreateDto, Locality>();
        CreateMap<LocalityUpdateDto, Locality>();
        CreateMap<LocalityDeleteDto, Locality>();
    }

}

