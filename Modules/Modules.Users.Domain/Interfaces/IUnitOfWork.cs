using System;

namespace Modules.Users.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Department { get; }
        IDepartmentUnitRepository DepartmentUnit { get; }
        ITokenStoreRepository TokenStore { get; }
        IUserRepository Users { get; }
        IChannelsRepository Channels { get; }

        //IMenuActionsRepository MenuActions {get; }
        IRoleMenuActionsRepository RolePermissions { get; }
        IMenusRepository Menus { get; }
        ISubMenusRepository SubMenus { get; }
        ISubMenuItemsRepository SubMenuItems { get; }

        Task<int> Complete();
    }
}

