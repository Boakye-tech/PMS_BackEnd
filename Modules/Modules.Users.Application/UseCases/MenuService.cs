using System;
using System.Data;
using System.Security.Claims;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


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

        public async Task<string> AssignPermissionToRole(PermissionsAccessModulesDto rolesPermissions)
        {
            //throw new NotImplementedException();

            //set counters
            int pCounter; int spCounter; int spiCounter;

            if(rolesPermissions is null)
            {
            }
            pCounter = _unitOfWork.AcccessPermissions.GetAll().Result.Count();
            spCounter = _unitOfWork.SubPermissions.GetAll().Result.Count();
            spiCounter = _unitOfWork.SubPermissionsItems.GetAll().Result.Count();


            foreach (var _menus in rolesPermissions!.permissionsAccessModules)
            {
                pCounter++;
                var permissions = new AccessPermissions
                (
                    permissionsId: pCounter,
                    roleId: rolesPermissions.RoleId,
                    moduleName: _menus.menuName,
                    noAccess: _menus.permissionsActions.NoAccess,
                    create: _menus.permissionsActions.Create,
                    read: _menus.permissionsActions.Read,
                    update: _menus.permissionsActions.Update,
                    delete: _menus.permissionsActions.Delete,
                    approve: _menus.permissionsActions.Approve
                );

                _unitOfWork.AcccessPermissions.Insert(permissions);

                foreach (var _subMenu in _menus.sections)
                {
                    spCounter++;
                    var subpermissions = new SubPermissions
                    (
                        permissionsId : pCounter,
                        subPermissionsId: spCounter,
                        roleId: rolesPermissions.RoleId,
                        sectionName: _subMenu.sectionName,
                        noAccess: _subMenu.permissionsActions.NoAccess,
                        create: _subMenu.permissionsActions.Create,
                        read: _subMenu.permissionsActions.Read,
                        update: _subMenu.permissionsActions.Update,
                        delete: _subMenu.permissionsActions.Delete,
                        approve: _subMenu.permissionsActions.Approve
                    );;

                    _unitOfWork.SubPermissions.Insert(subpermissions);

                    foreach (var _item in _subMenu.items)
                    {
                        spiCounter++;
                        var subpermissionsitems = new SubPermissionsItems
                        (
                            permissionsId: pCounter,
                            subPermissionsId : spCounter,
                            subPermissionsItemsId: spiCounter,
                            roleId: rolesPermissions.RoleId,
                            itemName: _item.ItemName,
                            noAccess: _item.permissionsActions.NoAccess,
                            create: _item.permissionsActions.Create,
                            read: _item.permissionsActions.Read,
                            update: _item.permissionsActions.Update,
                            delete: _item.permissionsActions.Delete,
                            approve: _item.permissionsActions.Approve
                        );

                        _unitOfWork.SubPermissionsItems.Insert(subpermissionsitems);
                    }
                }
            }
            await _unitOfWork.Complete();

            //return null!;
            

            return "Permissions applied successfully.";
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
                Menus menu = new(menus.menuId, menus.menuName, menus.description, menus.IsOpen);
                _unitOfWork.Menus.Insert(menu);
                await _unitOfWork.Complete();

                return new MenusDto(menu.MenuId, menus.menuName, menu.Description, menu.IsOpen);
            }

            return new MenusDto(StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest", false);
        }

        public async Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus)
        {
            //throw new NotImplementedException();
            var validationResult = _validationService.Validate(subMenus);

            if (validationResult.IsValid)
            {
                SubMenus _subMenu = new(subMenus.menuId, subMenus.subMenuId, subMenus.subMenuName, subMenus.description, subMenus.IsOpen);
                _unitOfWork.SubMenus.Insert(_subMenu);
                await _unitOfWork.Complete();

                return new SubMenusDto(_subMenu.MenuId, _subMenu.SubMenuId, _subMenu.SubMenuName, _subMenu.Description, _subMenu.IsOpen);
            }

            return new SubMenusDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest",false);
        }

        public void DeleteMenu(MenusDeleteDto menuid)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubMenu(SubMenuDeleteDto subMenuId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MenuActionsDto> GetActions()
        {
            //var response = await _unitOfWork.MenuActions.GetAll();
            var response = ClaimsMenuActionsEnumDescription.ToMenuActionsDtoList();
            return _mapper.Map<IEnumerable<MenuActionsDto>>(response);
        }

        public async Task<AccessModulesDto> GetAccessMenus()
        {
            //throw new NotImplementedException();

            var permissions = new PermissionsActionsDto(NoAccess:false, Create:false, Read:false, Update:false, Delete:false, Approve:false);

            var menus = await _unitOfWork.Menus.GetAll();
            var accessModules = new List<AccessMenusWithActionsDto>();

            foreach (var _menuItem in menus)
            {
                var subMenus = await _unitOfWork.SubMenus.GetAll(sm => sm.MenuId == _menuItem.MenuId);
                var sections = new List<AccessSubMenusWithActionsDto>();

                foreach (var _subMenu in subMenus)
                {
                    var subMenuItems = await _unitOfWork.SubMenuItems.GetAll(smi => smi.SubMenuId == _subMenu.SubMenuId);
                    var items = new List<AccessSubMenuItemsWithActionsDto>();

                    foreach (var item in subMenuItems)
                    {
                        items.Add(new AccessSubMenuItemsWithActionsDto(item.SubMenuItemName, permissions));
                    }

                    sections.Add(new AccessSubMenusWithActionsDto(_subMenu.SubMenuName, _subMenu.IsOpen, permissions, items));
                }

                accessModules.Add(new AccessMenusWithActionsDto(_menuItem.MenuName, _menuItem.IsOpen, permissions, sections));
            }

            //return new List<AccessModulesDto> { new AccessModulesDto(accessModules) };
            return new AccessModulesDto(accessModules);
        }

        public async Task<PermissionsAccessModulesDto> PermissionsAccessMenus(PermissionsAccessModulesDto values)
        {

            var permissions = new PermissionsActionsDto(NoAccess: false, Create: false, Read: false, Update: false, Delete: false, Approve: false);

            var menus = await _unitOfWork.Menus.GetAll();
            var accessModules = new List<PermissionAccessMenusWithActionsDto>();

            foreach (var _menuItem in menus)
            {
                var subMenus = await _unitOfWork.SubMenus.GetAll(sm => sm.MenuId == _menuItem.MenuId);
                var sections = new List<PermissionAccessSubMenusWithActionsDto>();

                foreach (var _subMenu in subMenus)
                {
                    var subMenuItems = await _unitOfWork.SubMenuItems.GetAll(smi => smi.SubMenuId == _subMenu.SubMenuId);
                    var items = new List<PermissionAccessSubMenuItemsWithActionsDto>();

                    foreach (var item in subMenuItems)
                    {
                        items.Add(new PermissionAccessSubMenuItemsWithActionsDto(item.SubMenuItemName, permissions));
                    }

                    sections.Add(new PermissionAccessSubMenusWithActionsDto(_subMenu.SubMenuName,  permissions, items));
                }

                accessModules.Add(new PermissionAccessMenusWithActionsDto(_menuItem.MenuName, permissions, sections));
            }

            //return new List<AccessModulesDto> { new AccessModulesDto(accessModules) };
            return new PermissionsAccessModulesDto(values.RoleId, accessModules);
        }

        //public async Task<IEnumerable<MenusWithActionsDto>> GetMenuActions()
        //{
        //    //throw new NotImplementedException();
        //    //var _actions = await _unitOfWork.MenuActions!.GetAll();
        //    var _actions = ClaimsMenuActionsEnumDescription.ToMenuActionsDtoList();

        //    var result =
        //        (from menu in await _unitOfWork.Menus.GetAll()
        //         join submenu in await _unitOfWork.SubMenus.GetAll()
        //         on menu.MenuId equals submenu.MenuId into submenuGroup
        //         from submenu in submenuGroup.DefaultIfEmpty() // LEFT JOIN
        //         from action in _actions  // CROSS JOIN
        //         group new { menu, submenu, action }
        //         by new { menu.MenuName, SubmenuName = submenu != null ? submenu.SubMenuName : null } into grouped
        //         select new MenusWithActionsDto
        //         (0,
        //          grouped.Key.MenuName,
        //          grouped.Key.SubmenuName,
        //          grouped.Any(g => g.action.actionName == "No Access") ? "" : null!,
        //          grouped.Any(g => g.action.actionName == "Create") ? "" : null!,
        //          grouped.Any(g => g.action.actionName == "Read") ? "" : null!,
        //          grouped.Any(g => g.action.actionName == "Update") ? "" : null!,
        //          grouped.Any(g => g.action.actionName == "Delete") ? "" : null!,
        //          grouped.Any(g => g.action.actionName == "Approve") ? "" : null!
        //         )).ToList();
        //    //select new MenusWithActionsDto
        //    //{
        //    //    MenuId = 0,
        //    //    MenuName = grouped.Key.MenuName,
        //    //    SubmenuName = grouped.Key.SubmenuName,
        //    //    NoAccess = grouped.Any(g => g.action.ActionName == "No Access") ? "" : null,
        //    //    Create = grouped.Any(g => g.action.ActionName == "Create") ? "" : null,
        //    //    Read = grouped.Any(g => g.action.ActionName == "Read") ? "" : null,
        //    //    Update = grouped.Any(g => g.action.ActionName == "Update") ? "" : null,
        //    //    Delete = grouped.Any(g => g.action.ActionName == "Delete") ? "" : null,
        //    //    Approve = grouped.Any(g => g.action.ActionName == "Approve") ? "" : null
        //    //}).ToList();

        //    return result!;
        //}

        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            var response = await _unitOfWork.Menus.GetAll();
            return _mapper.Map<IEnumerable<MenusDto>>(response);
        }

        //public void GetRolesMenusActions()
        //{
        //    throw new NotImplementedException();
        //}

        public Task<PermissionsAccessModulesDto> GetRolesPermissions(string roleId)
        {
            throw new NotImplementedException();

            //var roles = _roleManager.Roles;

            //var result = from roleAction in await _unitOfWork.RolePermissions.GetAll()
            //             join menu in await _unitOfWork.Menus.GetAll()
            //             on roleAction.MenuId equals menu.MenuId

            //             join subMenu in await _unitOfWork.SubMenus.GetAll()
            //             on roleAction.SubMenuId equals subMenu.SubMenuId

            //             join subMenuItems in await _unitOfWork.SubMenuItems.GetAll()
            //             on roleAction.SubMenuItemsId equals subMenuItems.SubMenuItemId
            //             join role in roles
            //             on roleAction.RoleId equals role.Id
            //             where role.Id == roleId
            //             group new { roleAction, menu, subMenu, subMenuItems, role } by role.Name into roleGroup
            //             select new RolesPermissionsResponseDto
            //             {
            //                 RoleName = roleGroup.Key, // Now RoleName is fetched from roles.
            //                 AssignedPermissions = roleGroup.Select(g => new RolesWithMenusResponseDto(
            //                     g.menu.MenuName,
            //                     g.subMenu.SubMenuName,
            //                     g.subMenuItems.SubMenuItemName,
            //                     g.roleAction.NoAccess,
            //                     g.roleAction.Create,
            //                     g.roleAction.Read,
            //                     g.roleAction.Update,
            //                     g.roleAction.Delete,
            //                     g.roleAction.Approve
            //                 ))
            //             };

            //return result.ToList();
        }

        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public Task<PermissionsAccessModulesDto> GetUserRolePermissions(string userId)
        {
            throw new NotImplementedException();
            //var resultUser = await  _userManager.FindByIdAsync(userId);

            //if(resultUser is null) { }

            //var resultRole = _userManager.GetRolesAsync(resultUser!).Result.FirstOrDefault();

            //var roles = _roleManager.Roles;

            //var result = from roleAction in await _unitOfWork.RolePermissions.GetAll()
            //             join menu in await _unitOfWork.Menus.GetAll()
            //             on roleAction.MenuId equals menu.MenuId
            //             join subMenu in await _unitOfWork.SubMenus.GetAll()
            //             on roleAction.SubMenuId equals subMenu.SubMenuId
            //             join subMenuItems in await _unitOfWork.SubMenuItems.GetAll()
            //             on roleAction.SubMenuItemsId equals subMenuItems.SubMenuItemId
            //             join role in roles
            //             on roleAction.RoleId equals role.Id
            //             where role.Name == resultRole
            //             group new { roleAction, menu, subMenu, subMenuItems, role } by role.Name into roleGroup
            //             select new RolesPermissionsResponseDto
            //             {
            //                 RoleName = roleGroup.Key, // Now RoleName is fetched from roles.
            //                 AssignedPermissions = roleGroup.Select(g => new RolesWithMenusResponseDto(
            //                     g.menu.MenuName,
            //                     g.subMenu.SubMenuName,
            //                     g.subMenuItems.SubMenuItemName,
            //                     g.roleAction.NoAccess,
            //                     g.roleAction.Create,
            //                     g.roleAction.Read,
            //                     g.roleAction.Update,
            //                     g.roleAction.Delete,
            //                     g.roleAction.Approve
            //                 ))
            //             };

            //return result.ToList();
        }

        public Task<MenusDto> UpdateMenu(MenusDto updateMenus)
        {
            throw new NotImplementedException();
        }

        public Task<SubMenusDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus)
        {
            throw new NotImplementedException();
        }




        public async Task<IEnumerable<SubMenuItemsDto>> GetSubMenuItems()
        {
            var response = await _unitOfWork.SubMenuItems.GetAll();
            return _mapper.Map<IEnumerable<SubMenuItemsDto>>(response);
        }

        public async Task<SubMenuItemsDto> CreateSubMenuItems(SubMenuItemsCreateDto subMenuItems)
        {
            var validationResult = _validationService.Validate(subMenuItems);

            if (validationResult.IsValid)
            {
                SubMenuItems _subMenuItems = new(subMenuItems.menuId, subMenuItems.subMenuId, subMenuItems.subMenuItemId ,subMenuItems.subMenuItemName, subMenuItems.description);
                _unitOfWork.SubMenuItems.Insert(_subMenuItems);
                await _unitOfWork.Complete();

                return new SubMenuItemsDto(_subMenuItems.MenuId, _subMenuItems.SubMenuId, _subMenuItems.SubMenuItemId , _subMenuItems.SubMenuItemName, _subMenuItems.Description);
            }

            return new SubMenuItemsDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest");
        }

        public Task<SubMenuItemsDto> UpdateSubMenuItems(SubMenuItemsUpdateDto updateSubMenuItems)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubMenuItems(SubMenuItemsDeleteDto subMenuItemsId)
        {
            throw new NotImplementedException();
        }


    }
}

