using System;

namespace Modules.Users.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Department { get; }
        IDepartmentUnitRepository DepartmentUnit { get; }
        ITokenStoreRepository TokenStore { get; }
        IChannelsRepository Channels { get; }

        IUserRepository Users { get; }
        IRolesRepository Roles {get; }
        IUsersRolesRepository UsersRoles { get; }

        IMenusRepository Menus { get; }
        ISubMenusRepository SubMenus { get; }
        ISubMenuItemsRepository SubMenuItems { get; }

        IPermissionsRepository AcccessPermissions { get; }
        ISubPermissionsRepository SubPermissions { get; }
        ISubPermissionsItemsRepository SubPermissionsItems { get; }

        IStaffAccountsRepository StaffAccounts { get; }

        IApplicationModulesRepository ApplicationModules { get; }
        IApplicationModulesPermissionsRepository ApplicationModulesPermissions { get; }

        Task<int> Complete();
    }
}

