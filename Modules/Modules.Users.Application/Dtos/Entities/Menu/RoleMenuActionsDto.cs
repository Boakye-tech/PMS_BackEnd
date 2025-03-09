using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record RoleMenuActionsDto(int roleMenuActionId, string roleId, int menuId, int subMenuId, int actionId);
}

