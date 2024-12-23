using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record MenuActionsDto(int actionId, string actionName, string description);

    public record MenusWithActionsDto(int menuId, string menuName, int actionId, string actionName);
}

