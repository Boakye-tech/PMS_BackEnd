// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/TypesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 9:30 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Profiles.Property
{
	public class TypesProfile : Profile
    {
        public TypesProfile()
        {
            CreateMap<Types, TypesReadDto>();
            CreateMap<TypesCreateDto, Types>();
            CreateMap<TypesUpdateDto, Types>();

        }
    }
}

