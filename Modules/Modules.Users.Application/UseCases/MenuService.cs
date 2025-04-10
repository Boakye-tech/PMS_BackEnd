using System;
using System.Data;
using System.Reflection;
using System.Security.Claims;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Application.Dtos.Entities.Permissions;
using Modules.Users.Application.Dtos.UserAccounts;
using Modules.Users.Domain.Entities;
using Modules.Users.Domain.Entities.Menu;
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

            //check if role already exist with permissions
            var persmissions = await _unitOfWork.AcccessPermissions.GetAll(p => p.RoleId == rolesPermissions.RoleId);

            if(persmissions is not null)
            {
                _unitOfWork.AcccessPermissions.DeleteRange(persmissions);
            }

            foreach (var _menus in rolesPermissions.permissionsAccessModules)
            {
                // Step 1: Create and save AccessPermissions FIRST
                var permissions = new AccessPermissions
                (
                    permissionsId: 0,
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
                        subPermissionsId: 0,
                        roleId: rolesPermissions.RoleId,
                        sectionName: _subMenu.sectionName,
                        noAccess: _subMenu.permissionsActions.NoAccess,
                        create: _subMenu.permissionsActions.Create,
                        read: _subMenu.permissionsActions.Read,
                        update: _subMenu.permissionsActions.Update,
                        delete: _subMenu.permissionsActions.Delete,
                        approve: _subMenu.permissionsActions.Approve
                    ) ;

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
                            subPermissionsItemsId : 0,
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
                menu.CreatedBy = menus.createdBy;

                _unitOfWork.Menus.Insert(menu);
                await _unitOfWork.Complete();

                var _user = await _userManager.FindByIdAsync(menus.createdBy);
                var _createdBy = string.Concat(_user!.FirstName," ",_user.MiddleName," ",_user.LastName).Trim(); 

                return new MenusDto(menu.MenuId, menus.menuName, menu.Description, _createdBy, menu.IsOpen);
            }

            return new MenusDto(StatusCodes.Status400BadRequest, "BadRequest", "BadRequest", "400-BadRequest", false);
        }

        public async Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus)
        {
            var validationResult = _validationService.Validate(subMenus);

            if (validationResult.IsValid)
            {
                SubMenus _subMenu = new(subMenus.menuId, subMenus.subMenuId, subMenus.subMenuName, subMenus.description, subMenus.IsOpen);
                _subMenu.CreatedBy = subMenus.createdBy;

                _unitOfWork.SubMenus.Insert(_subMenu);
                await _unitOfWork.Complete();

                var _user = await _userManager.FindByIdAsync(subMenus.createdBy);
                var _createdBy = string.Concat(_user!.FirstName, " ", _user.MiddleName, " ", _user.LastName).Trim();


                return new SubMenusDto(_subMenu.MenuId, _subMenu.SubMenuId, _subMenu.SubMenuName, _subMenu.Description, _createdBy, _subMenu.IsOpen);
            }

            return new SubMenusDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "BadRequest", "400-BadRequest",false);
        }

        public async Task<GenericResponseDto> DeleteMenu(int menuId)
        {
            var response = await _unitOfWork.Menus.Get(m => m.MenuId == menuId);
            if(response is null)
            {
                return new GenericResponseDto("Menu id supplied does nto exist");
            }

            if (response is not null)
            {
                _unitOfWork.Menus.Delete(response);
                await _unitOfWork.Complete();
                return new GenericResponseDto("Menu deleted successfully.");
            }

            return new GenericResponseDto("Menu deletion unsuccessful.");

        }

        public async Task<GenericResponseDto> DeleteSubMenu(int subMenuId)
        {
            var response = await _unitOfWork.SubMenus.Get(sm => sm.SubMenuId == subMenuId);
            if (response is null)
            {
                return new GenericResponseDto("Sub-menu id supplied does nto exist");
            }

            if (response is not null)
            {
                _unitOfWork.SubMenus.Delete(response);
                await _unitOfWork.Complete();

                return new GenericResponseDto("Sub-menu deleted successfully.");
            }

            return new GenericResponseDto("Sub-menu deletion unsuccessful.");
        }

        public IEnumerable<MenuActionsDto> GetActions()
        {
            var response = ClaimsMenuActionsEnumDescription.ToMenuActionsDtoList();
            return _mapper.Map<IEnumerable<MenuActionsDto>>(response);
        }

        public async Task<AccessModulesDto> GetAccessMenus()
        {

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

        public async Task<List<AllMenusDto>> GetAllMenus()
        {
            List<AllMenusDto> allMenusResponse = new List<AllMenusDto>();

            var menuJoined = (
                            from m in await _unitOfWork.Menus.GetAll()
                            join u in await _unitOfWork.Users.GetAll() on m.CreatedBy equals u.Id
                            select new MenusDto
                            (
                                m.MenuId,
                                m.MenuName,
                                m.Description,
                                string.Concat(u.FirstName," ", u.MiddleName, " ", u.LastName).Trim(),
                                m.IsOpen
                            )).ToList();

            var subMenuJoined = (
                from m in await _unitOfWork.SubMenus.GetAll()
                join u in await _unitOfWork.Users.GetAll() on m.CreatedBy equals u.Id
                select new SubMenusDto
                (
                    m.MenuId,
                    m.SubMenuId,
                    m.SubMenuName,
                    m.Description,
                    string.Concat(u.FirstName, " ", u.MiddleName, " ", u.LastName).Trim(),
                    m.IsOpen
                )).ToList();

            foreach (var _menuItem in menuJoined)
            {
                var _subMenus = subMenuJoined.FindAll(sm => sm.menuId == _menuItem.menuId);

                var menuItem = _mapper.Map<MenusDto>(_menuItem);
                var subMenuItem = _mapper.Map<List<SubMenusDto>>(_subMenus);

                AllMenusDto _allMenusDto = new AllMenusDto(menuItem, subMenuItem);
                allMenusResponse.Add(_allMenusDto);
            }

            return allMenusResponse;
        }

        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            var response = await _unitOfWork.Menus.GetAll();
            return _mapper.Map<IEnumerable<MenusDto>>(response);
        }


        public async Task<PermissionsAccessModulesReadDto> GetRolesPermissions(string roleId)
        {
            var _permissions = await _unitOfWork.AcccessPermissions.GetAll(p => p.RoleId == roleId);
            var accessModules = new List<PermissionAccessMenusWithActionsReadDto>();

            foreach (var permission in _permissions)
            {
                string role = permission.RoleId;

                var _subPermissions = await _unitOfWork.SubPermissions.GetAll(sp => sp.PermissionsId == permission.PermissionsId);
                var sections = new List<PermissionAccessSubMenusWithActionsReadDto>();

                foreach (var _section in _subPermissions)
                {
                    var _subPermissionItems = await _unitOfWork.SubPermissionsItems.GetAll(spi => spi.SubPermissionsId == _section.SubPermissionsId);
                    var items = new List<PermissionAccessSubMenuItemsWithActionsReadDto>();

                    foreach (var item in _subPermissionItems)
                    {
                         items.Add(new PermissionAccessSubMenuItemsWithActionsReadDto(item.PermissionsId,item.SubPermissionsId, item.SubPermissionsItemsId, item.ItemName, new PermissionsActionsDto(item.NoAccess, item.Create, item.Read, item.Update, item.Delete, item.Approve)));
                    }

                    sections.Add(new PermissionAccessSubMenusWithActionsReadDto(_section.PermissionsId, _section.SubPermissionsId, _section.SectionName,new PermissionsActionsDto(_section.NoAccess, _section.Create, _section.Read, _section.Update, _section.Delete, _section.Approve), items));
                }

                accessModules.Add(new PermissionAccessMenusWithActionsReadDto(permission.PermissionsId, permission.ModuleName, new PermissionsActionsDto(permission.NoAccess, permission.Create, permission.Read, permission.Update, permission.Delete, permission.Approve), sections));
            }

            return new PermissionsAccessModulesReadDto(roleId, accessModules);
        }


        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public async Task<PermissionsAccessModulesReadDto> GetUserRolePermissions(string userId)
        {
            //throw new NotImplementedException();
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
                //throw new Exception("User not found");
                return null!;
            }

            var userRoles = await _userManager.GetRolesAsync(user); 

            if (userRoles.Count == 0)
            {
                return null!;
            }

            // Assuming a user has only one role, get the first role name
            string roleName = userRoles.First();

            // Find the role entity using its name
            var role = await _roleManager.FindByNameAsync(roleName);

            if (role is null)
            {
                return null!;
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

            return new SubMenuItemsDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "400-BadRequest");
        }

        public Task<SubMenuItemsDto> UpdateSubMenuItems(SubMenuItemsUpdateDto updateSubMenuItems)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto> DeleteSubMenuItems(int subMenuItemsId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UsersAndRolesReadDto>> GetListOfUsersAndRoles()
        {
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

        public async Task<GenericResponseDto> UpdatePermissionsAssignedToRole(PermissionsAccessModulesReadDto rolesPermissions)
        {
            //throw new NotImplementedException();

            if (rolesPermissions is null || rolesPermissions.permissionsAccessModules == null)
            {
                return new GenericResponseDto("Invalid input data.");
            }

            foreach (var _menus in rolesPermissions.permissionsAccessModules)
            {
                // Step 1: Create and save AccessPermissions FIRST
                var permissions = new AccessPermissions
                (
                    permissionsId: _menus.PermissionsId,
                    roleId: rolesPermissions.RoleId,
                    moduleName: _menus.menuName,
                    noAccess: _menus.permissionsActions.NoAccess,
                    create: _menus.permissionsActions.Create,
                    read: _menus.permissionsActions.Read,
                    update: _menus.permissionsActions.Update,
                    delete: _menus.permissionsActions.Delete,
                    approve: _menus.permissionsActions.Approve
                );

                _unitOfWork.AcccessPermissions.Update(permissions);
                //await _unitOfWork.Complete(); // Save to DB first

                // Step 2: Retrieve the assigned PermissionsId
                //int permissionsId = permissions.PermissionsId; // EF Core now assigns this

                foreach (var _subMenu in _menus.sections)
                {
                    // Create SubPermissions with the real permissionsId
                    var subpermissions = new SubPermissions
                    (
                        permissionsId: _subMenu.PermissionsId, // Use the DB-generated ID
                        subPermissionsId: _subMenu.SubPermissionsId,
                        roleId: rolesPermissions.RoleId,
                        sectionName: _subMenu.sectionName,
                        noAccess: _subMenu.permissionsActions.NoAccess,
                        create: _subMenu.permissionsActions.Create,
                        read: _subMenu.permissionsActions.Read,
                        update: _subMenu.permissionsActions.Update,
                        delete: _subMenu.permissionsActions.Delete,
                        approve: _subMenu.permissionsActions.Approve
                    );

                    _unitOfWork.SubPermissions.Update(subpermissions);
                    //await _unitOfWork.Complete(); // Save to DB first

                    //int subPermissionsId = subpermissions.SubPermissionsId; // Get the new ID

                    foreach (var _item in _subMenu.items)
                    {
                        // Create SubPermissionsItems with real IDs
                        var subpermissionsitems = new SubPermissionsItems
                        (
                            permissionsId: _item.PermissionsId,
                            subPermissionsId: _item.SubPermissionsId, // Use the correct sub permission ID
                            subPermissionsItemsId: _item.SubPermissionsItemsId,
                            roleId: rolesPermissions.RoleId,
                            itemName: _item.ItemName,
                            noAccess: _item.permissionsActions.NoAccess,
                            create: _item.permissionsActions.Create,
                            read: _item.permissionsActions.Read,
                            update: _item.permissionsActions.Update,
                            delete: _item.permissionsActions.Delete,
                            approve: _item.permissionsActions.Approve
                        );

                        _unitOfWork.SubPermissionsItems.Update(subpermissionsitems);
                    }

                    await _unitOfWork.Complete(); // Ensure changes persist
                }
            }

            return new GenericResponseDto("Permissions updated successfully.");
        }

        public async Task<ApplicationModulesDto> AddModules(ApplicationModulesCreateDto appModules)
        {
            //throw new NotImplementedException();
            var moduleId = Guid.NewGuid().ToString().Substring(0,12);
            ApplicationModules applicationModules = new ApplicationModules(moduleId, appModules.ModuleName!);
            _unitOfWork.ApplicationModules.Insert(applicationModules);
            await _unitOfWork.Complete();

            return new ApplicationModulesDto
            {
                ModuleId = applicationModules.ModuleId,
                ModuleName = applicationModules.ModuleName
            };

        }

        public async Task<ApplicationModulesDto> UpdateModules(ApplicationModulesDto appModules)
        {
            //throw new NotImplementedException();
            ApplicationModules applicationModules = new ApplicationModules(appModules.ModuleId!, appModules.ModuleName!);
            _unitOfWork.ApplicationModules.Update(applicationModules);
            await _unitOfWork.Complete();

            return new ApplicationModulesDto
            {
                ModuleId = applicationModules.ModuleId,
                ModuleName = applicationModules.ModuleName
            };
        }

        public async Task<GenericResponseDto> AssignModulePermission(ApplicationModulesPermissionsDto permissions)
        {
            //throw new NotImplementedException();

            foreach (var item in permissions.ModulePermission!)
            {
                ApplicationModulesPermissions modulesPermissions = new ApplicationModulesPermissions(permissions.RoleId!, permissions.ModuleId!, item.ModulePermission!);
                _unitOfWork.ApplicationModulesPermissions.Insert(modulesPermissions);
            }

            await _unitOfWork.Complete();

            return new GenericResponseDto("Permissions applied successfully.");
        }

        public async Task<IEnumerable<ApplicationModulesDto>> GetModules()
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.ApplicationModules.GetAll();
            return _mapper.Map<IEnumerable<ApplicationModulesDto>>(response);

        }

        public async Task<IEnumerable<RoleModulesPermissionsDto>> GetModulesPermissions(string roleId)
        {
            var modulePermissions = (await _unitOfWork.ApplicationModulesPermissions.GetAll())
               .Where(a => a.RoleId == roleId) // Filter where based on RoleId 
               .GroupJoin(await _unitOfWork.ApplicationModules.GetAll(),
                   a => a.ModuleId,
                   b => b.ModuleId,
                   (a, moduleGroup) => new { a, module = moduleGroup.FirstOrDefault() }) // Left Join on ApplicationModules
               .GroupJoin(await _unitOfWork.Roles.GetAll(),
                   ab => ab.a.RoleId,
                   c => c.Id,
                   (ab, roleGroup) => new RoleModulesPermissionsDto
                   {
                       ModulePermissionId = ab.a.ModulePermissionId,
                       RoleId = ab.a.RoleId,
                       RoleName = roleGroup.FirstOrDefault()?.Name, // Left Join on Roles
                       ModuleId = ab.a.ModuleId,
                       ModuleName = ab.module?.ModuleName,
                       ModulePermission = ab.a.ModulePermission
                   })
               .ToList();


            return _mapper.Map<IEnumerable<RoleModulesPermissionsDto>>(modulePermissions);

        }
    }
}

