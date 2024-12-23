using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record SubMenusDto(int menuId, int subMenuId, string subMenuName, string description);
    public record SubMenusCreateDto(int menuId, int subMenuId, string subMenuName, string description);
    public record SubMenusUpdateDto(int subMenuId, string subMenuName, string description);
    public record SubMenuDeleteDto(int subMenuId);

}

