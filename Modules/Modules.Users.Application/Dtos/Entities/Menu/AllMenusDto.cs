using System;
namespace Modules.Users.Application.Dtos.Entities.Menu
{
    public record AllMenusDto(MenusDto menuName, List<SubMenusDto> subMenus);

}

