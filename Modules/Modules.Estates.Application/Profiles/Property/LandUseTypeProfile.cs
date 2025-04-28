// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

