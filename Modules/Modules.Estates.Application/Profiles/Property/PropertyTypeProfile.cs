using System;
namespace Modules.Estates.Application.Profiles.Property;

public class PropertyTypeProfile : Profile
{
	public PropertyTypeProfile()
	{
        CreateMap<PropertyType, PropertyTypeReadDto>();

        CreateMap<PropertyTypeCreateDto, PropertyType>();
        CreateMap<PropertyTypeUpdateDto, PropertyType>();
        CreateMap<PropertyTypeDeleteDto, PropertyType>();
    }
}

