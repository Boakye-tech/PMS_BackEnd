using System;
using Modules.Users.Domain.Interfaces.Entities;
using Modules.Users.Domain.Interfaces.Entities.Menu;

namespace Modules.Users.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Department { get; }
        IDepartmentUnitRepository DepartmentUnit { get; }
        ITokenStoreRepository TokenStore { get; }
        IUserRepository Users { get; }

        IMenuActionsRepository MenuActions {get; }
        IRoleMenuActionsRepository RolePermissions { get; }
        IMenusRepository Menus { get; }
        ISubMenusRepository SubMenus { get; }

        Task<int> Complete();
    }
}

