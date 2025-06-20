// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/ApartmentCategoryProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 16/06/2025 5:39 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.Profiles.Property;

public class ApartmentCategoryProfile : Profile
{
	public ApartmentCategoryProfile()
	{
		CreateMap<ApartmentCategory, ApartmentCategoryReadDto>();

        CreateMap<ApartmentCategoryCreateDto, ApartmentCategory>();
		CreateMap<ApartmentCategoryUpdateDto, ApartmentCategory>();
		CreateMap<ApartmentCategoryDeleteDto, ApartmentCategory>();

		//// Mapping for the relationship with ApartmentTypes
		//CreateMap<ApartmentCategory, ApartmentCategoryAndTypesReadDto>()
		//	.ForMember(dest => dest.ApartmentTypes, opt => opt.MapFrom(src => src.ApartmentTypes));
	}
}

