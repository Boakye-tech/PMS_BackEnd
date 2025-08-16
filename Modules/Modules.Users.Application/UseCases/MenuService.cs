// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.Data;
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
                menu.CreatedOn = DateTime.UtcNow;

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
                _subMenu.CreatedOn = DateTime.UtcNow;

                _unitOfWork.SubMenus.Insert(_subMenu);
                await _unitOfWork.Complete();

                var _user = await _userManager.FindByIdAsync(subMenus.createdBy);
                var _createdBy = string.Concat(_user!.FirstName, " ", _user.MiddleName, " ", _user.LastName).Trim();


                return new SubMenusDto(_subMenu.MenuId, _subMenu.SubMenuId, _subMenu.SubMenuName!, _subMenu.Description!, _createdBy, _subMenu.IsOpen);
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

                    sections.Add(new AccessSubMenusWithActionsDto(_subMenu.SubMenuName!, _subMenu.IsOpen, permissions, items));
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

                    sections.Add(new PermissionAccessSubMenusWithActionsDto(_subMenu.SubMenuName!,  permissions, items));
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
                    m.SubMenuName!,
                    m.Description!,
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

            var defaultPermissions = new PermissionsActionsDto(NoAccess: false, Create: false, Read: false, Update: false, Delete: false, Approve: false);

            // Fetch everything once
            var allMenus = await _unitOfWork.Menus.GetAll();
            var allSubMenus = await _unitOfWork.SubMenus.GetAll();
            var allSubMenuItems = await _unitOfWork.SubMenuItems.GetAll();

            var permissions = await _unitOfWork.AcccessPermissions.GetAll(p => p.RoleId == roleId);
            var subPermissions = await _unitOfWork.SubPermissions.GetAll();
            var subPermissionItems = await _unitOfWork.SubPermissionsItems.GetAll();

            // Build dictionaries for fast lookup
            var permissionDict = permissions.ToDictionary(p => p.ModuleName, p => p);
            var subPermissionDict = subPermissions.ToDictionary(sp => (sp.PermissionsId, sp.SectionName), sp => sp);
            var subPermissionItemDict = subPermissionItems.ToDictionary(spi => (spi.SubPermissionsId, spi.ItemName), spi => spi);

            var accessModules = allMenus.Select(menu =>
            {
                var permission = permissionDict.GetValueOrDefault(menu.MenuName);
                var permissionId = permission?.PermissionsId ?? 0;

                var menuPermissions = permission != null
                    ? new PermissionsActionsDto(permission.NoAccess, permission.Create, permission.Read, permission.Update, permission.Delete, permission.Approve)
                    : defaultPermissions;

                var sections = allSubMenus
                    .Where(sm => sm.MenuId == menu.MenuId)
                    .Select(subMenu =>
                    {
                        var subPermission = subPermissionDict!.GetValueOrDefault((permissionId, subMenu.SubMenuName));
                        var subPermissionId = subPermission?.SubPermissionsId ?? 0;

                        var subMenuPermissions = subPermission != null
                            ? new PermissionsActionsDto(subPermission.NoAccess, subPermission.Create, subPermission.Read, subPermission.Update, subPermission.Delete, subPermission.Approve)
                            : defaultPermissions;

                        var items = allSubMenuItems
                            .Where(smi => smi.SubMenuId == subMenu.SubMenuId)
                            .Select(item =>
                            {
                                var subPermissionItem = subPermissionItemDict.GetValueOrDefault((subPermissionId, item.SubMenuItemName));

                                var itemPermissions = subPermissionItem != null
                                    ? new PermissionsActionsDto(subPermissionItem.NoAccess, subPermissionItem.Create, subPermissionItem.Read, subPermissionItem.Update, subPermissionItem.Delete, subPermissionItem.Approve)
                                    : defaultPermissions;

                                return new PermissionAccessSubMenuItemsWithActionsReadDto(
                                    permissionId,
                                    subPermissionId,
                                    subPermissionItem?.SubPermissionsItemsId ?? 0,
                                    item.SubMenuItemName,
                                    itemPermissions
                                );
                            })
                            .ToList();

                        return new PermissionAccessSubMenusWithActionsReadDto(
                            permissionId,
                            subPermissionId,
                            subMenu.SubMenuName!,
                            subMenuPermissions,
                            items
                        );
                    })
                    .ToList();

                return new PermissionAccessMenusWithActionsReadDto(
                    permission?.PermissionsId ?? 0,
                    menu.MenuName,
                    menuPermissions,
                    sections
                );
            }).ToList();

            return new PermissionsAccessModulesReadDto(roleId, accessModules);


        }


        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public async Task<PermissionsAccessModulesReadDto> GetUserRolePermissions(string userId)
        {
            var user = await _userManager.FindByIdAsync(userId);
            if (user is null)
            {
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

        public async Task<MenusUpdateDto> UpdateMenu(MenusUpdateDto updateMenus)
        {
            var menu = await _unitOfWork.Menus.Get(m => m.MenuId == updateMenus.menuId);
            if(menu is null)
            {
                return new MenusUpdateDto(404, "Not Found.",null!, null!, false );
            }

            menu.MenuName = updateMenus.menuName;
            menu.Description = updateMenus.description;
            menu.ModifiedBy = updateMenus.modifiedBy;
            menu.ModifiedOn = DateTime.UtcNow;

            //var _menu = _mapper.Map<Menus>(menu);
            _unitOfWork.Menus.Update(menu);
            await _unitOfWork.Complete();

            var updateMenu = _mapper.Map<MenusUpdateDto>(menu);
            return updateMenu;
        }

        public async Task<SubMenusUpdateResponseDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus)
        {
            var subMenu = await _unitOfWork.SubMenus.Get(sm => sm.SubMenuId == updateSubMenus.subMenuId);
            if (subMenu is null)
            {
                return new SubMenusUpdateResponseDto(404, 404, "Not Found.", null!, null!, false);
            }

            subMenu.SubMenuName = updateSubMenus.subMenuName;
            subMenu.Description = updateSubMenus.description;
            subMenu.IsOpen = updateSubMenus.IsOpen;
            subMenu.ModifiedBy = updateSubMenus.modifiedBy;
            subMenu.ModifiedOn = DateTime.UtcNow;

            //var _subMenu = _mapper.Map<SubMenus>(updateSubMenus);
            _unitOfWork.SubMenus.Update(subMenu);
            await _unitOfWork.Complete();

            var updatedSubMenu = _mapper.Map<SubMenusUpdateResponseDto>(subMenu);
            return updatedSubMenu;

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

            var result = _unitOfWork.ApplicationModules.Get(am => am.ModuleName == appModules.ModuleName);
            if(result is not null)
            {
                return new ApplicationModulesDto
                {
                    ModuleId = "400",
                    ModuleName = "Module name already exist"
                };
            }


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
            var result = _unitOfWork.ApplicationModules.Get(am => am.ModuleName == appModules.ModuleName);
            if (result is not null)
            {
                return new ApplicationModulesDto
                {
                    ModuleId = "400",
                    ModuleName = "Module name already exist"
                };
            }

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
            var modulePermission = await _unitOfWork.ApplicationModulesPermissions.GetAll(amp => amp.RoleId == permissions.RoleId);
            if (modulePermission.Any())
            {
                return new GenericResponseDto("Role supplied already has permissions assigned.");
            }

            if (permissions.ModulePermission == null || !permissions.ModulePermission.Any(mp => !string.IsNullOrWhiteSpace(mp.ModuleId) && mp.Permissions != null && mp.Permissions.Any(p => !string.IsNullOrWhiteSpace(p) && p != "string")))
            {
                return new GenericResponseDto("Module permissions cannot be empty.");
            }

            foreach (var module in permissions.ModulePermission!)
            {
                foreach (var permission in module.Permissions!)
                {
                    ApplicationModulesPermissions modulesPermissions = new ApplicationModulesPermissions(permissions.RoleId!, module.ModuleId!, permission);
                    _unitOfWork.ApplicationModulesPermissions.Insert(modulesPermissions);
                }
            }

            await _unitOfWork.Complete();

            return new GenericResponseDto("Permissions applied successfully.");
        }

        public async Task<IEnumerable<ApplicationModulesDto>> GetModules()
        {
            var response = await _unitOfWork.ApplicationModules.GetAll();
            return _mapper.Map<IEnumerable<ApplicationModulesDto>>(response);

        }

        //public async Task<IEnumerable<ModulesByRolesPermissionsDto>> GetModulesPermissions(string roleId)
        //{

        //    // First, load the data asynchronously outside the query
        //    var modulesPermissions = await _unitOfWork.ModulesPermissions.GetAll();
        //    var modules = await _unitOfWork.ApplicationModules.GetAll();
        //    var roles = await _unitOfWork.Roles.GetAll();
        //    var appModulesPermissions = await _unitOfWork.ApplicationModulesPermissions.GetAll();


        //    return (
        //                from mp in modulesPermissions
        //                join m in modules on mp.ModuleId equals m.ModuleId
        //                join r in roles.Where(x => x.Id == roleId) on 1 equals 1
        //                join amp in appModulesPermissions
        //                    .Where(x => x.RoleId == roleId)
        //                    on new { mp.ModuleId, ModulePermission = mp.PermissionName }
        //                    equals new { amp.ModuleId, ModulePermission = amp.ModulePermission }
        //                    into ampJoin
        //                from amp in ampJoin.DefaultIfEmpty()
        //                group new { mp, m, amp, r } by new { r.Id, r.Name, mp.ModuleId, m.ModuleName } into g
        //                select new
        //                {
        //                    g.Key.Id,
        //                    g.Key.Name,
        //                    g.Key.ModuleId,
        //                    g.Key.ModuleName,
        //                    Permissions = g
        //                    .GroupBy(x => x.mp.PermissionName!)
        //                    .ToDictionary(
        //                        permGroup => permGroup.Key,
        //                        permGroup => permGroup.Any(x => x.amp != null)
        //                    )
        //                }
        //            )
        //            .GroupBy(x => new { x.Id, x.Name })
        //            .Select(g => new ModulesByRolesPermissionsDto
        //            {
        //                //RoleId = g.Key.Id,
        //                //RoleName = g.Key.Name,
        //                ModulesPermission = g.Select(m => new RoleModulePermissions
        //                {
        //                    ModuleId = m.ModuleId,
        //                    ModuleName = m.ModuleName,
        //                    Permissions = m.Permissions
        //                }).ToList()
        //            });

        //}


        public async Task<IEnumerable<RoleModulePermissions>> GetModulesPermissions(string roleId)
        {
            // Load the data asynchronously outside the query
            var modulesPermissions = await _unitOfWork.ModulesPermissions.GetAll();
            var modules = await _unitOfWork.ApplicationModules.GetAll();
            var appModulesPermissions = await _unitOfWork.ApplicationModulesPermissions.GetAll();

            return (
                from mp in modulesPermissions
                join m in modules on mp.ModuleId equals m.ModuleId
                join amp in appModulesPermissions
                    .Where(x => x.RoleId == roleId)
                    on new { mp.ModuleId, ModulePermission = mp.PermissionName }
                    equals new { amp.ModuleId, ModulePermission = amp.ModulePermission }
                    into ampJoin
                from amp in ampJoin.DefaultIfEmpty()
                group new { mp, m, amp } by new { mp.ModuleId, m.ModuleName } into g
                select new RoleModulePermissions
                {
                    ModuleId = g.Key.ModuleId,
                    ModuleName = g.Key.ModuleName,
                    PermissionName = g
                        .GroupBy(x => x.mp.PermissionName!)
                        .ToDictionary(
                            permGroup => permGroup.Key,
                            permGroup => permGroup.Any(x => x.amp != null)
                        )
                }
            ).ToList();
        }





        public async Task<GenericResponseDto> UpdateAssignModulePermission(ApplicationModulesPermissionsUpdateDto permissions)
        {
            var modulePermission = await _unitOfWork.ApplicationModulesPermissions.GetAll(amp => amp.RoleId == permissions.RoleId);
            if (!modulePermission.Any())
            {
                return new GenericResponseDto("Role supplied does not have any permissions assigned.");
            }

            if (permissions.ModulePermission == null || !permissions.ModulePermission.Any(mp =>!string.IsNullOrWhiteSpace(mp.ModuleId) && mp.Permissions != null && mp.Permissions.Any(p => !string.IsNullOrWhiteSpace(p) && p != "string")))
            {
                return new GenericResponseDto("Module permissions cannot be empty.");
            }

            _unitOfWork.ApplicationModulesPermissions.DeleteRange(modulePermission);

            foreach (var module in permissions.ModulePermission!)
            {
                foreach (var _permission in module.Permissions!)
                {
                    ApplicationModulesPermissions modulesPermissions = new ApplicationModulesPermissions(permissions.RoleId!, module.ModuleId!, _permission);
                    _unitOfWork.ApplicationModulesPermissions.Insert(modulesPermissions);
                }
            }

            await _unitOfWork.Complete();

            return new GenericResponseDto("Assigned Permissions updated successfully.");

        }

        public async Task<GenericResponseDto> DeleteModulePermission(int modulePermissionId)
        {
            var modulePermission = await _unitOfWork.ApplicationModulesPermissions.Get(modulePermissionId);
            if(modulePermission is null)
            {
                return new GenericResponseDto("Permissions id supplied does not exisit.");
            }

            _unitOfWork.ApplicationModulesPermissions.Delete(modulePermission!);
            await _unitOfWork.Complete();

            return new GenericResponseDto("Permission removed successfully.");

        }

        public async Task<GenericResponseDto> AddModulesPermissions(ModulesPermissionsDto values)
        {

            if(!values.PermissionName.Any())
                return new GenericResponseDto("Module permissions cannot be empty.");

            foreach (var permission in values.PermissionName)
            {
                ModulesPermissions modulesPermissions = ModulesPermissions.CreateUpdate(values.ModuleId, permission);
                _unitOfWork.ModulesPermissions.Insert(modulesPermissions);
            }

            await _unitOfWork.Complete();

            return new GenericResponseDto("Module Permissions added successfully.");

        }


        public async Task<List<ModulesPermissionsReadDto>> GetModulesPermissions()
        {
            var response = await _unitOfWork.ApplicationModules.GetAll(includes: new List<string> { "ModulesPermissions" });

            var modulePermissions = response.Select(permission => new ModulesPermissionsReadDto
            {
                ModuleId = permission.ModuleId,
                ModuleName = permission.ModuleName,
                PermissionName = permission.ModulesPermissions?.Select(p => p.PermissionName).Where(p => p != null).Select(p => p!) .ToList()
            }).ToList();

            return modulePermissions;
        }


        public async Task<GenericResponseDto> UpdateModulesPermissions(ModulesPermissionsUpdateDto values)
        {
            var modulePermission = await _unitOfWork.ModulesPermissions.Get(values.ModulesPermissionsId);
            if (modulePermission is null)
            {
                return new GenericResponseDto("Modules Permissions id supplied does not exisit.");
            }

            modulePermission.ModuleId = values.ModuleId;
            modulePermission.PermissionName = values.PermissionName;


            _unitOfWork.ModulesPermissions.Update(modulePermission);
            await _unitOfWork.Complete();

            return new GenericResponseDto("Modules Permission updated successfully.");
        }

   
    }
}

