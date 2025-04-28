// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Profiles
{
	public class SubMenuItemsProfile : Profile
	{
		public SubMenuItemsProfile()
		{
			CreateMap<SubMenuItems, SubMenuItemsDto>();
            CreateMap<SubMenuItemsCreateDto, SubMenuItems>();
            CreateMap<SubMenuItemsUpdateDto, SubMenuItems>();
            CreateMap<SubMenuItemsDeleteDto, SubMenuItems>();

        }
    }
}

