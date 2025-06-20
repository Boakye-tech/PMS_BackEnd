// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/FloorNumberingProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Profiles.Property;

public class FloorNumberingProfile : Profile
{
	public FloorNumberingProfile()
	{
		CreateMap<FloorNumbering, FloorNumberingReadDto>();

		CreateMap<FloorNumberingCreateDto, FloorNumbering>();
        CreateMap<FloorNumberingUpdateDto, FloorNumbering>();
        CreateMap<FloorNumberingDeleteDto, FloorNumbering>();

    }
}

