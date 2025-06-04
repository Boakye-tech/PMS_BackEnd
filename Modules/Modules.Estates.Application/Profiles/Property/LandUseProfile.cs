// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/LandUseProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

