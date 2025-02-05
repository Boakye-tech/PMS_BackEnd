using System;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Domain.Entities.Menu;

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

