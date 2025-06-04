// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/FloorAreaProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Profiles.Property;

public class FloorAreaProfile : Profile
{
	public FloorAreaProfile()
	{
		CreateMap<FloorArea, FloorAreaReadDto>();

        CreateMap<FloorAreaCreateDto, FloorArea>();
        CreateMap<FloorAreaUpdateDto, FloorArea>();
        CreateMap<FloorAreaDeleteDto, FloorArea>();

    }
}

