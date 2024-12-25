using System;
using System.Data;
using System.Security.Claims;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Application.Validations;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.UseCases
{
	public class MenuService : IMenuService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        readonly UserManager<ApplicationIdentityUser> _userManager;
        readonly RoleManager<ApplicationIdentityRole> _roleManager;
        readonly ValidationService _validationService;


        public MenuService(IUnitOfWork unitOfWork, IMapper mapper, ValidationService validationService, UserManager<ApplicationIdentityUser> userManager, RoleManager<ApplicationIdentityRole> roleManager)
		{
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationService = validationService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<AssignPermissionToRoleResponseDto> AssignPermissionToRole(RolesPermissionsDto rolesPermissions)
        {
            //throw new NotImplementedException();

            if (!await _roleManager.RoleExistsAsync(rolesPermissions.RoleName!))
            {
                return new AssignPermissionToRoleResponseDto($"Role name {rolesPermissions.RoleName} does not exist.");
            }

            if (rolesPermissions.Permissions!.Count() == 0)
            {
                return new AssignPermissionToRoleResponseDto("Permissions have not been assigned to this role.");
            }

            List<RoleMenuActions> roleswithPermissions = new List<RoleMenuActions>();

            string roleId = _roleManager.FindByNameAsync(rolesPermissions.RoleName!).Result!.Id;

            foreach (var item in rolesPermissions.Permissions!)
            {

                var rolePermission = new RoleMenuActions
                (
                    //id,
                    //rolesPermissions.RoleName!,
                    roleId,
                    item.MenuId,
                    item.SubMenuId,
                    item.NoAccess,
                    item.Create,
                    item.Read,
                    item.Update,
                    item.Delete,
                    item.Approve

                );
                roleswithPermissions.Add(rolePermission);
            }

            _unitOfWork.RolePermissions.InsertRange(roleswithPermissions);
            await _unitOfWork.Complete();

            return new AssignPermissionToRoleResponseDto("Permissions applied successfully.");
        }

        public async Task<IdentityResult> AssignUserRole(AssignUserRoleDto assignUserRole)
        {
            //throw new NotImplementedException();
            var resultUser = _userManager.FindByEmailAsync(assignUserRole.EmailAddress).Result;

            if (resultUser == null)
                return null!;

            IdentityResult resultRole = await _userManager.AddToRoleAsync(resultUser!, assignUserRole.RoleName);
            
            return resultRole;

        }

        public async Task<MenusDto> CreateMenu(MenusDto menus)
        {
            var validationResult = _validationService.Validate(menus);

            if (validationResult.IsValid)
            {
                Menus menu = new(menus.menuId, menus.menuName, menus.description);
                _unitOfWork.Menus.Insert(menu);
                await _unitOfWork.Complete();

                return new MenusDto(menu.MenuId, menus.menuName, menu.Description);
            }

            return new MenusDto(StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest");
        }

        public async Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus)
        {
            //throw new NotImplementedException();
            var validationResult = _validationService.Validate(subMenus);

            if (validationResult.IsValid)
            {
                SubMenus _subMenu = new(subMenus.menuId, subMenus.subMenuId, subMenus.subMenuName, subMenus.description);
                _unitOfWork.SubMenus.Insert(_subMenu);
                await _unitOfWork.Complete();

                return new SubMenusDto(_subMenu.MenuId, _subMenu.SubMenuId, _subMenu.SubMenuName, _subMenu.Description);
            }

            return new SubMenusDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest");
        }

        public void DeleteMenu(MenusDeleteDto menuid)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubMenu(SubMenuDeleteDto subMenuId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuActionsDto>> GetActions()
        {
            var response = await _unitOfWork.MenuActions.GetAll();
            return _mapper.Map<IEnumerable<MenuActionsDto>>(response);
        }

        public async Task<IEnumerable<MenusWithActionsDto>> GetMenuActions()
        {
            //throw new NotImplementedException();
            var _actions = await _unitOfWork.MenuActions!.GetAll();

            var result =
                (from menu in await _unitOfWork.Menus.GetAll()
                 join submenu in await _unitOfWork.SubMenus.GetAll()
                 on menu.MenuId equals submenu.MenuId into submenuGroup
                 from submenu in submenuGroup.DefaultIfEmpty() // LEFT JOIN
                 from action in _actions  // CROSS JOIN
                 group new { menu, submenu, action }
                 by new { menu.MenuName, SubmenuName = submenu != null ? submenu.SubMenuName : null } into grouped
                 select new MenusWithActionsDto
                 (0,
                  grouped.Key.MenuName,
                  grouped.Key.SubmenuName,
                  grouped.Any(g => g.action.ActionName == "No Access") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Create") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Read") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Update") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Delete") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Approve") ? "" : null!
                 )).ToList();
            //select new MenusWithActionsDto
            //{
            //    MenuId = 0,
            //    MenuName = grouped.Key.MenuName,
            //    SubmenuName = grouped.Key.SubmenuName,
            //    NoAccess = grouped.Any(g => g.action.ActionName == "No Access") ? "" : null,
            //    Create = grouped.Any(g => g.action.ActionName == "Create") ? "" : null,
            //    Read = grouped.Any(g => g.action.ActionName == "Read") ? "" : null,
            //    Update = grouped.Any(g => g.action.ActionName == "Update") ? "" : null,
            //    Delete = grouped.Any(g => g.action.ActionName == "Delete") ? "" : null,
            //    Approve = grouped.Any(g => g.action.ActionName == "Approve") ? "" : null
            //}).ToList();

            return result!;
        }

        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            var response = await _unitOfWork.Menus.GetAll();
            return _mapper.Map<IEnumerable<MenusDto>>(response);
        }

        //public void GetRolesMenusActions()
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<RolesPermissionsResponseDto>> GetRolesPermissions(string roleId)
        {
            //throw new NotImplementedException();

            var roles = _roleManager.Roles;

            var result = from roleAction in await _unitOfWork.RolePermissions.GetAll()
                         join menu in await _unitOfWork.Menus.GetAll()
                         on roleAction.MenuId equals menu.MenuId
                         join subMenu in await _unitOfWork.SubMenus.GetAll()
                         on roleAction.SubMenuId equals subMenu.SubMenuId
                         join role in roles
                         on roleAction.RoleId equals role.Id
                         where role.Id == roleId
                         group new { roleAction, menu, subMenu, role } by role.Name into roleGroup
                         select new RolesPermissionsResponseDto
                         {
                             RoleName = roleGroup.Key, // Now RoleName is fetched from roles.
                             AssignedPermissions = roleGroup.Select(g => new RolesWithMenusResponseDto(
                                 g.menu.MenuName,
                                 g.subMenu.SubMenuName,
                                 g.roleAction.NoAccess,
                                 g.roleAction.Create,
                                 g.roleAction.Read,
                                 g.roleAction.Update,
                                 g.roleAction.Delete,
                                 g.roleAction.Approve
                             ))
                         };

            return result.ToList();
        }

        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public async Task<IEnumerable<RolesPermissionsResponseDto>> GetUserRolePermissions(string userId)
        {
            //throw new NotImplementedException();
            var resultUser = await  _userManager.FindByIdAsync(userId);

            if(resultUser is null) { }

            var resultRole = _userManager.GetRolesAsync(resultUser!).Result.FirstOrDefault();

            var roles = _roleManager.Roles;

            var result = from roleAction in await _unitOfWork.RolePermissions.GetAll()
                         join menu in await _unitOfWork.Menus.GetAll()
                         on roleAction.MenuId equals menu.MenuId
                         join subMenu in await _unitOfWork.SubMenus.GetAll()
                         on roleAction.SubMenuId equals subMenu.SubMenuId
                         join role in roles
                         on roleAction.RoleId equals role.Id
                         where role.Name == resultRole
                         group new { roleAction, menu, subMenu, role } by role.Name into roleGroup
                         select new RolesPermissionsResponseDto
                         {
                             RoleName = roleGroup.Key, // Now RoleName is fetched from roles.
                             AssignedPermissions = roleGroup.Select(g => new RolesWithMenusResponseDto(
                                 g.menu.MenuName,
                                 g.subMenu.SubMenuName,
                                 g.roleAction.NoAccess,
                                 g.roleAction.Create,
                                 g.roleAction.Read,
                                 g.roleAction.Update,
                                 g.roleAction.Delete,
                                 g.roleAction.Approve
                             ))
                         };

            return result.ToList();


        }

        public Task<MenusDto> UpdateMenu(MenusDto updateMenus)
        {
            throw new NotImplementedException();
        }

        public Task<SubMenusDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Claim>> GetUserRoleClaims(string userId)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(userId);
            var userrole = _userManager.GetRolesAsync(user!).Result.FirstOrDefault();
            var roles = _roleManager.Roles;


            var result = from roleAction in await _unitOfWork.RolePermissions.GetAll()
                         join menu in await _unitOfWork.Menus.GetAll()
                         on roleAction.MenuId equals menu.MenuId
                         join subMenu in await _unitOfWork.SubMenus.GetAll()
                         on roleAction.SubMenuId equals subMenu.SubMenuId
                         join role in roles
                         on roleAction.RoleId equals role.Id
                         where role.Name == userrole
                         //group new { roleAction, menu, subMenu, role } by role.Name into roleGroup
                         select new Claim
                         (
                             menu.MenuName,
                             subMenu.SubMenuName,
                             roleAction.NoAccess,
                             roleAction.Create,
                             roleAction.Read,
                             roleAction.Update,
                             roleAction.Delete,
                             roleAction.Approve
                         );

            return result.ToList();
        }


    }
}

