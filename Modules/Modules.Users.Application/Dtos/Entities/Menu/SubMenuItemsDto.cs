using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record SubMenuItemsDto(int menuId, int subMenuId, int subMenuItemId, string subMenuItemName, string description);
    public record SubMenuItemsCreateDto(int menuId, int subMenuId, int subMenuItemId ,string subMenuItemName, string description);
    public record SubMenuItemsUpdateDto(int subMenuItemId, string subMenuItemName, string description);
    public record SubMenuItemsDeleteDto(int subMenuItemId);

}

