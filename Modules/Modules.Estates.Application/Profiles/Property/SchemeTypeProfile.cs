// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/SchemeTypeProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Profiles.Property
{
	public class SchemeTypeProfile : Profile
    {
		public SchemeTypeProfile()
		{
            CreateMap<SchemeType, SchemeTypeReadDto>();

            CreateMap<SchemeTypeCreateDto, SchemeType>();
            CreateMap<SchemeTypeUpdateDto, SchemeType>();
            CreateMap<SchemeTypeDeleteDto, SchemeType>();
        }
	}
}

