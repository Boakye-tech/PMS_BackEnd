using System;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.Profiles
{
	public class MenusProfile : Profile
	{
		public MenusProfile()
		{
			CreateMap<Menus, MenusDto>();
            CreateMap<MenusDto, Menus>();
            CreateMap<MenusDeleteDto, Menus>();

        }
    }
}

