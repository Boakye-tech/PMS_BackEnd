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
	public class ComplaintStatusesProfile : Profile
	{
		public ComplaintStatusesProfile()
		{
            CreateMap<ComplaintStatuses, ComplaintStatusesReadDto>();
            CreateMap<ComplaintStatusesCreateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesUpdateDto, ComplaintStatuses>();
            CreateMap<ComplaintStatusesDeleteDto, ComplaintStatuses>();
        }
    }
}

