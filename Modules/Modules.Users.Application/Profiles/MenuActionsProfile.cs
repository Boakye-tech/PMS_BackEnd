using System;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.Profiles
{
	public class MenuActionsProfile : Profile
	{
		public MenuActionsProfile()
		{
			CreateMap<MenuActions, MenuActionsDto>();
			CreateMap<MenuActionsDto, MenuActions>();

        }
	}
}

