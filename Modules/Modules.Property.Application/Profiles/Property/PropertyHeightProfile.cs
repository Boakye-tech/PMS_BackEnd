namespace Modules.Estates.Application.Profiles.Property;

public class PropertyHeightProfile : Profile
{
	public PropertyHeightProfile()
	{
		CreateMap<PropertyHeight, PropertyHeightReadDto>();
		CreateMap<PropertyHeightCreateDto, PropertyHeight>();
        CreateMap<PropertyHeightUpdateDto, PropertyHeight>();
        CreateMap<PropertyHeightDeleteDto, PropertyHeight>();
    }
}

