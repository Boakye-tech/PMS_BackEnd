using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
	public record SubMenusDto(int menuId, int subMenuId, string subMenuName, string description, string createdBy, bool IsOpen);
    public record SubMenusCreateDto(int menuId, int subMenuId, string subMenuName, string description, string createdBy, bool IsOpen);
    public record SubMenusUpdateDto(int subMenuId, string subMenuName, string description, string modifiedBy, bool IsOpen);
    public record SubMenuDeleteDto(int subMenuId);

}

