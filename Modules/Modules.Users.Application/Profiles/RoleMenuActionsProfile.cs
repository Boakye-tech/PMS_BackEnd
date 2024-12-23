using System;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.Profiles
{
	public class RoleMenuActionsProfile : Profile
	{
		public RoleMenuActionsProfile()
		{
            CreateMap<RoleMenuActions, RoleMenuActionsDto>();
            CreateMap<RoleMenuActionsDto, RoleMenuActions>();

        }
	}
}

