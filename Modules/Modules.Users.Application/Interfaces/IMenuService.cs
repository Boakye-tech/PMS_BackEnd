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

        Task<IEnumerable<MenusDto>> GetMenus();
        Task<IEnumerable<SubMenusDto>> GetSubMenus();

        //void GetSubMenus(SubMenusDto subMenus);

        Task<IEnumerable<MenusWithActionsDto>> GetMenuActions();
        //Task<IEnumerable<MenuActionsDto>> GetActions();
        IEnumerable<MenuActionsDto> GetActions();

        //void AssignMenuActionsToRole(RolesPermissionsDto rolesPermissions);
        Task<AssignPermissionToRoleResponseDto> AssignPermissionToRole(RolesPermissionsDto rolesPermissions);
        Task<IdentityResult> AssignUserRole(AssignUserRoleDto assignUserRole);

        Task<IEnumerable<RolesPermissionsResponseDto>> GetRolesPermissions(string roleId);

        Task<IEnumerable<RolesPermissionsResponseDto>> GetUserRolePermissions(string userId);

        Task<IEnumerable<Claim>> GetUserRoleClaims(string userId); //remove
    }
}

