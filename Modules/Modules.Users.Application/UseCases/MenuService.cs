using System;
using System.Data;
using System.Security.Claims;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Application.Dtos.UserAccounts;
using static System.Collections.Specialized.BitVector32;


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


        public async Task<GenericResponseDto> AssignPermissionToRole(PermissionsAccessModulesDto rolesPermissions)
        {
            if (rolesPermissions is null || rolesPermissions.permissionsAccessModules == null)
            {
                return new GenericResponseDto("Invalid input data.");
            }

            foreach (var _menus in rolesPermissions.permissionsAccessModules)
            {
                // Step 1: Create and save AccessPermissions FIRST
                var permissions = new AccessPermissions
                (
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
                await _unitOfWork.Complete(); // Save to DB first

                // Step 2: Retrieve the assigned PermissionsId
                int permissionsId = permissions.PermissionsId; // EF Core now assigns this

                foreach (var _subMenu in _menus.sections)
                {
                    // Create SubPermissions with the real permissionsId
                    var subpermissions = new SubPermissions
                    (
                        permissionsId: permissionsId, // Use the DB-generated ID
                        roleId: rolesPermissions.RoleId,
                        sectionName: _subMenu.sectionName,
                        noAccess: _subMenu.permissionsActions.NoAccess,
                        create: _subMenu.permissionsActions.Create,
                        read: _subMenu.permissionsActions.Read,
                        update: _subMenu.permissionsActions.Update,
                        delete: _subMenu.permissionsActions.Delete,
                        approve: _subMenu.permissionsActions.Approve
                    );

                    _unitOfWork.SubPermissions.Insert(subpermissions);
                    await _unitOfWork.Complete(); // Save to DB first

                    int subPermissionsId = subpermissions.SubPermissionsId; // Get the new ID

                    foreach (var _item in _subMenu.items)
                    {
                        // Create SubPermissionsItems with real IDs
                        var subpermissionsitems = new SubPermissionsItems
                        (
                            permissionsId: permissionsId,
                            subPermissionsId: subPermissionsId, // Use the correct sub permission ID
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

                    await _unitOfWork.Complete(); // Ensure changes persist
                }
            }

            return new GenericResponseDto("Permissions applied successfully.");
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

            return new PermissionsAccessModulesDto(values.RoleId, accessModules);
        }

        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            var response = await _unitOfWork.Menus.GetAll();
            return _mapper.Map<IEnumerable<MenusDto>>(response);
        }


        public async Task<PermissionsAccessModulesDto> GetRolesPermissions(string roleId)
        {
            var _permissions = await _unitOfWork.AcccessPermissions.GetAll(p => p.RoleId == roleId);
            var accessModules = new List<PermissionAccessMenusWithActionsDto>();

            foreach (var permission in _permissions)
            {
                string role = permission.RoleId;

                var _subPermissions = await _unitOfWork.SubPermissions.GetAll(sp => sp.PermissionsId == permission.PermissionsId);
                var sections = new List<PermissionAccessSubMenusWithActionsDto>();

                foreach (var _section in _subPermissions)
                {
                    var _subPermissionItems = await _unitOfWork.SubPermissionsItems.GetAll(spi => spi.SubPermissionsId == _section.SubPermissionsId);
                    var items = new List<PermissionAccessSubMenuItemsWithActionsDto>();

                    foreach (var item in _subPermissionItems)
                    {
                         items.Add(new PermissionAccessSubMenuItemsWithActionsDto(item.ItemName, new PermissionsActionsDto(item.NoAccess, item.Create, item.Read, item.Update, item.Delete, item.Approve)));
                    }

                    sections.Add(new PermissionAccessSubMenusWithActionsDto(_section.SectionName,new PermissionsActionsDto(_section.NoAccess, _section.Create, _section.Read, _section.Update, _section.Delete, _section.Approve), items));
                }

                accessModules.Add(new PermissionAccessMenusWithActionsDto(permission.ModuleName, new PermissionsActionsDto(permission.NoAccess, permission.Create, permission.Read, permission.Update, permission.Delete, permission.Approve), sections));
            }

            return new PermissionsAccessModulesDto(roleId, accessModules);
        }


        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public async Task<PermissionsAccessModulesDto> GetUserRolePermissions(string userId)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                throw new Exception("User not found");
            }

            var userRoles = await _userManager.GetRolesAsync(user); 

            if (userRoles.Count == 0)
            {
                throw new Exception("User has no roles assigned");
            }

            // Assuming a user has only one role, get the first role name
            string roleName = userRoles.First();

            // Find the role entity using its name
            var role = await _roleManager.FindByNameAsync(roleName);

            if (role is null)
            {
                throw new Exception("Role not found");
            }

            string roleId = role.Id; // Role ID

            return await GetRolesPermissions(roleId);

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

        public async Task<IEnumerable<UsersAndRolesReadDto>> GetListOfUsersAndRoles()
        {
            //throw new NotImplementedException();

            IEnumerable<ApplicationIdentityUser> appUsers = await _unitOfWork.Users.GetAll();
            IEnumerable<ApplicationIdentityRole> appRoles = await _unitOfWork.Roles.GetAll();
            IEnumerable<ApplicationIdentityUserRole> appUserRoles = await _unitOfWork.UsersRoles.GetAll();

            var userRoles = from au in appUsers
                            join aur in appUserRoles on au.Id equals aur.UserId into table1
                            from aur in table1.ToList()
                            join ar in appRoles on aur.RoleId equals ar.Id into table2
                            from ar in table2.ToList()


                            select new UsersAndRolesReadDto
                            (
                                userId: au.Id,
                                userName: au.Email!,
                                roleId: ar.Id,
                                roleName: ar.Name!
                            );

            return userRoles;
        }
    }
}

