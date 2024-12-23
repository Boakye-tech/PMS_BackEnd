using System;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Interfaces
{
	public interface IMenuService
	{
        Task<MenusDto> CreateMenu(MenusDto menus);
        Task<MenusDto> UpdateMenu(MenusDto updateMenus);
        void DeleteMenu(MenusDeleteDto menuid);
        

        Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus);
        Task<SubMenusDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus);
        void DeleteSubMenu(SubMenuDeleteDto subMenuId);

        Task<IEnumerable<MenusDto>> GetMenus();
        Task<IEnumerable<SubMenusDto>> GetSubMenus();

        //void GetSubMenus(SubMenusDto subMenus);

        Task<IEnumerable<MenusWithActionsDto>> GetMenuActions();
        Task<IEnumerable<MenuActionsDto>> GetActions();
        void GetRolesMenusActions();

        void AssignMenuActionsToRole();
    }
}

