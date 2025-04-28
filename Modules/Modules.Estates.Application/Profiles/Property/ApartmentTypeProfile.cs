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

public class ApartmentTypeProfile : Profile
{
	public ApartmentTypeProfile()
	{
		CreateMap<ApartmentTypes, ApartmentTypeReadDto>();
		CreateMap<ApartmentTypeCreateDto, ApartmentTypes>();
        CreateMap<ApartmentTypeUpdateDto, ApartmentTypes>();
        CreateMap<ApartmentTypeDeleteDto, ApartmentTypes>();
    }
}

