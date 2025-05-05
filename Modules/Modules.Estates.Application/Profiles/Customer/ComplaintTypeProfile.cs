// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Profiles.Customer
{
	public class ComplaintTypeProfile : Profile
    {
		public ComplaintTypeProfile()
		{
			CreateMap<ComplaintType, ComplaintTypeReadDto>();
            CreateMap<ComplaintTypeCreateDto, ComplaintType>();
            CreateMap<ComplaintTypeUpdateDto, ComplaintType>();
            CreateMap<ComplaintTypeDeleteDto, ComplaintType>();
        }
	}
}

