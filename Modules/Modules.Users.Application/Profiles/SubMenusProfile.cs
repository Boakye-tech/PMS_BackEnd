using System;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.Profiles
{
	public class SubMenusProfile : Profile
	{
		public SubMenusProfile()
		{
			CreateMap<SubMenus, SubMenusDto>();
            CreateMap<SubMenusDto, SubMenus>();
            CreateMap<SubMenuDeleteDto, SubMenus>();

        }
    }
}

