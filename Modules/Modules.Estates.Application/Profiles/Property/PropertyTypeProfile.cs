// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

