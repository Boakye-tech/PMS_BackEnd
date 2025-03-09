using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Interfaces.Entities.Menu;
using Modules.Users.Infrastructure.Repositories.Entities.Menu;
using Modules.Users.Infrastructure.Repositories.Entities.Permissions;

namespace Modules.Users.Infrastructure.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
        private bool disposedValue;
        private IConfiguration _configuration { get; }
        private readonly UserDbContext _dbContext;
        readonly UserManager<ApplicationIdentityUser> _userManager;
        
        private readonly HttpClient _httpClient;
        //private readonly IMenuService _menuService;


        public UnitOfWork(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager,  IConfiguration configuration, HttpClient httpClient) //, IMenuService menuService
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _configuration = configuration;
            _httpClient = httpClient;
            //_menuService = menuService;

            Department = new DepartmentRepository(dbContext);
            DepartmentUnit = new DepartmentUnitRepository(dbContext);
            Channels = new ChannelsRepository(dbContext);
            TokenStore = new TokenStoreRepository(dbContext, _userManager!, _configuration!, _httpClient);

            Users = new UserRepository(dbContext);
            Roles = new RolesRepository(dbContext);
            UsersRoles = new UsersRolesRepository(dbContext);

            Menus = new MenusRepository(dbContext);
            SubMenus = new SubMenusRepository(dbContext);
            SubMenuItems = new SubMenuItemsRepository(dbContext);

            AcccessPermissions = new PermissionsRepository(dbContext);
            SubPermissions = new SubPermissionsRepository(dbContext);
            SubPermissionsItems = new SubPermissionsItemsRepository(dbContext);
            StaffAccounts = new StaffAccountsRepository(dbContext);

            ApplicationModules = new ApplicationModulesRepository(dbContext);
            ApplicationModulesPermissions = new ApplicationModulesPermissionsRepository(dbContext);

            IdentificationType = new IdentificationTypeRepository(dbContext);

            //ActionsRepository = new MenuActionsRepository(dbContext);
        }


        public IDepartmentRepository Department { get; private set; }
        public IDepartmentUnitRepository DepartmentUnit { get; private set; }
        public IChannelsRepository Channels { get; private set; }
        public ITokenStoreRepository TokenStore { get; private set; }

        public IUserRepository Users { get; private set; }
        public IRolesRepository Roles { get; private set; }
        public IUsersRolesRepository UsersRoles { get; private set; }

        public IMenusRepository Menus { get; private set; }
        public ISubMenusRepository SubMenus { get; private set; }
        public ISubMenuItemsRepository SubMenuItems { get; private set; }

        public IPermissionsRepository AcccessPermissions { get; private set; }
        public ISubPermissionsRepository SubPermissions { get; private set; }
        public ISubPermissionsItemsRepository SubPermissionsItems { get; private set; }

        public IStaffAccountsRepository StaffAccounts { get; private set; }

        public IApplicationModulesRepository ApplicationModules { get; private set; }
        public IApplicationModulesPermissionsRepository ApplicationModulesPermissions { get; private set; }

        public IIdentificationTypeRepository IdentificationType { get; private set; }

        //public IMenuActionsRepository ActionsRepository { get; private set; }

        public Task<int> Complete()
        {
            return _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _dbContext.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

