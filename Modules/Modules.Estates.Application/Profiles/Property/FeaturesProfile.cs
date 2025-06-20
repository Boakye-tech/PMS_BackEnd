// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/FeaturesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 17/05/2025 4:31 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class FeaturesProfile : Profile
	{
		public FeaturesProfile()
		{
            CreateMap<Features, FeaturesReadDto>();
                //.ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.GetEnumDescription()));
            CreateMap<FeaturesCreateDto, Features>();
            CreateMap<FeaturesUpdateDto, Features>();
            CreateMap<FeaturesDeleteDto, Features>();

        }
    }
}

