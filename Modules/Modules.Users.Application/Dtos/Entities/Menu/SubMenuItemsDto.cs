using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record SubMenuItemsDto(int menuId, int subMenuId, int subMenuItemsId, string subMenuItemName, string description, bool IsOpen);
    public record SubMenuItemsCreateDto(int menuId, int subMenuId, int subMenuItemsId ,string subMenuItemName, string description, bool IsOpen);
    public record SubMenuItemsUpdateDto(int subMenuItemId, string subMenuItemName, string description, bool IsOpen);
    public record SubMenuItemsDeleteDto(int subMenuItemId);

}

