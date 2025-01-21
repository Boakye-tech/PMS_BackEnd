using System;
namespace Modules.Customers.Application.Profiles
{
	public class PropertyDetailsProfile : Profile
	{
		public PropertyDetailsProfile()
		{
            CreateMap<PropertyDetails, PropertyDetailsReadDto>();
            CreateMap<PropertyDetailsCreateDto, PropertyDetails>();
        }
	}
}

