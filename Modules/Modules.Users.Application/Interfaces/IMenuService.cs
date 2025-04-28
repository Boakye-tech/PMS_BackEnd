// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Identity;

namespace Modules.Users.Application.Interfaces
{
	public interface IMenuService
	{
        Task<MenusDto> CreateMenu(MenusDto menus);
        Task<MenusUpdateDto> UpdateMenu(MenusUpdateDto updateMenus);
        Task<GenericResponseDto> DeleteMenu(int menuId);
        

        Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus);
        Task<SubMenusUpdateResponseDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus);

        Task<GenericResponseDto> DeleteSubMenu(int subMenuId);

        Task<SubMenuItemsDto> CreateSubMenuItems(SubMenuItemsCreateDto subMenuItems);
        Task<SubMenuItemsDto> UpdateSubMenuItems(SubMenuItemsUpdateDto updateSubMenuItems);
        Task<GenericResponseDto> DeleteSubMenuItems(int subMenuItemsId);

        Task<List<AllMenusDto>> GetAllMenus();

        Task<IEnumerable<MenusDto>> GetMenus();
        Task<IEnumerable<SubMenusDto>> GetSubMenus();
        Task<IEnumerable<SubMenuItemsDto>> GetSubMenuItems();

        Task<AccessModulesDto> GetAccessMenus();
        IEnumerable<MenuActionsDto> GetActions();

        Task<GenericResponseDto> AssignPermissionToRole(PermissionsAccessModulesDto rolesPermissions);

        Task<GenericResponseDto> UpdatePermissionsAssignedToRole(PermissionsAccessModulesReadDto rolesPermissions);

        Task<IdentityResult> AssignUserRole(AssignUserRoleDto assignUserRole);

        Task<PermissionsAccessModulesReadDto> GetRolesPermissions(string roleId);

        Task<PermissionsAccessModulesReadDto> GetUserRolePermissions(string userId);

        Task<IEnumerable<UsersAndRolesReadDto>> GetListOfUsersAndRoles();

        Task<IEnumerable<ApplicationModulesDto>> GetModules();
        Task<ApplicationModulesDto> AddModules(ApplicationModulesCreateDto appModules);
        Task<ApplicationModulesDto> UpdateModules(ApplicationModulesDto appModules);

        Task<GenericResponseDto> AssignModulePermission(ApplicationModulesPermissionsDto permissions);

        Task<IEnumerable<RoleModulesPermissionsDto>> GetModulesPermissions(string roleId);

    }
}

