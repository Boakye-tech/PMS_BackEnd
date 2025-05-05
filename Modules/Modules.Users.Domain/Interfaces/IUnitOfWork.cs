// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



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

        IIdentificationTypeRepository IdentificationType { get; }

        //IMenuActionsRepository ActionsRepository { get; }

        Task<int> Complete();
    }
}

