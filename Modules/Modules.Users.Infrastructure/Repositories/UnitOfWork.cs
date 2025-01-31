using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Modules.Users.Application.Interfaces;
using Modules.Users.Domain.Interfaces.Entities.Menu;
using Modules.Users.Infrastructure.Repositories.Entities.Menu;

namespace Modules.Users.Infrastructure.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
        private bool disposedValue;
        private IConfiguration _configuration { get; }
        private readonly UserDbContext _dbContext;
        readonly UserManager<ApplicationIdentityUser> _userManager;
        //readonly IMenuService _menuService;


        public UnitOfWork(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager,  IConfiguration configuration) //IMenuService menuService,
        {
            _dbContext = dbContext;
            _userManager = userManager;
            //_menuService = menuService;
            _configuration = configuration;

            Department = new DepartmentRepository(dbContext);
            DepartmentUnit = new DepartmentUnitRepository(dbContext);
            Channels = new ChannelsRepository(dbContext);
            TokenStore = new TokenStoreRepository(dbContext, _userManager!,_configuration!); // _menuService!
            Users = new UserRepository(dbContext);

            MenuActions = new MenuActionsRepository(dbContext);
            //RoleMenuActions = new RoleMenuActionsRepository(dbContext);
            Menus = new MenusRepository(dbContext);
            SubMenus = new SubMenusRepository(dbContext);
            RolePermissions = new RoleMenuActionsRepository(dbContext);
        }


        public IDepartmentRepository Department { get; private set; }
        public IDepartmentUnitRepository DepartmentUnit { get; private set; }
        public ITokenStoreRepository TokenStore { get; private set; }
        public IUserRepository Users { get; private set; }

        public IMenuActionsRepository MenuActions { get; private set; }
        //public IRoleMenuActionsRepository RoleMenuActions { get; private set; }
        public IMenusRepository Menus { get; private set; }
        public ISubMenusRepository SubMenus { get; private set; }

        public IRoleMenuActionsRepository RolePermissions { get; private set; }

        public IChannelsRepository Channels { get; private set; }

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

