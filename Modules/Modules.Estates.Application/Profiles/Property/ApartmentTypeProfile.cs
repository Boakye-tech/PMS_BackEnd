namespace Modules.Estates.Application.Profiles.Property;

public class ApartmentTypeProfile : Profile
{
	public ApartmentTypeProfile()
	{
		CreateMap<ApartmentTypes, ApartmentTypeReadDto>();
		CreateMap<ApartmentTypeCreateDto, ApartmentTypes>();
        CreateMap<ApartmentTypeUpdateDto, ApartmentTypes>();
        CreateMap<ApartmentTypeDeleteDto, ApartmentTypes>();
    }
}

