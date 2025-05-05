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
	public class SocialMediaProfile : Profile
    {
		public SocialMediaProfile()
		{
            CreateMap<SocialMedia, SocialMediaReadDto>();

            CreateMap<SocialMediaCreateDto, SocialMedia>();
            CreateMap<SocialMediaUpdateDto, SocialMedia>();
            CreateMap<SocialMediaDeleteDto, SocialMedia>();
        }
	}
}

