using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;
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

        Task<SubMenuItemsDto> CreateSubMenuItems(SubMenuItemsCreateDto subMenuItems);
        Task<SubMenuItemsDto> UpdateSubMenuItems(SubMenuItemsUpdateDto updateSubMenuItems);
        void DeleteSubMenuItems(SubMenuItemsDeleteDto subMenuItemsId);

        Task<IEnumerable<MenusDto>> GetMenus();
        Task<IEnumerable<SubMenusDto>> GetSubMenus();
        Task<IEnumerable<SubMenuItemsDto>> GetSubMenuItems();


        //Task<IEnumerable<MenusWithActionsDto>> GetMenuActions();

        Task<AccessModulesDto> GetAccessMenus();
        //Task<IEnumerable<MenuActionsDto>> GetActions();
        IEnumerable<MenuActionsDto> GetActions();


        Task<GenericResponseDto> AssignPermissionToRole(PermissionsAccessModulesDto rolesPermissions); 

        Task<IdentityResult> AssignUserRole(AssignUserRoleDto assignUserRole);

        Task<PermissionsAccessModulesDto> GetRolesPermissions(string roleId);

        Task<PermissionsAccessModulesDto> GetUserRolePermissions(string userId);

    }
}

