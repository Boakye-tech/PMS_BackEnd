namespace Modules.Estates.Application.Profiles.Property;

public class FacilitiesProfile : Profile
{
	public FacilitiesProfile()
	{
		CreateMap<Facilities, FacilitiesReadDto>();

        CreateMap<FacilitiesCreateDto, Facilities>();
        CreateMap<FacilitiesUpdateDto, Facilities>();
        CreateMap<FacilitiesDeleteDto, Facilities>();

    }
}

