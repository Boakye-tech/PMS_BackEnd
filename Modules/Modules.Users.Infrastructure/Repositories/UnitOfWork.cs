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


        public UnitOfWork(UserDbContext dbContext, UserManager<ApplicationIdentityUser> userManager,  IConfiguration configuration, HttpClient httpClient) 
        {
            _dbContext = dbContext;
            _userManager = userManager;
            _configuration = configuration;
            _httpClient = httpClient;

            Department = new DepartmentRepository(dbContext);
            DepartmentUnit = new DepartmentUnitRepository(dbContext);
            Channels = new ChannelsRepository(dbContext);
            TokenStore = new TokenStoreRepository(dbContext, _userManager!,_configuration!, _httpClient); 
            Users = new UserRepository(dbContext);

            Menus = new MenusRepository(dbContext);
            SubMenus = new SubMenusRepository(dbContext);
            SubMenuItems = new SubMenuItemsRepository(dbContext);

            AcccessPermissions = new PermissionsRepository(dbContext);
            SubPermissions = new SubPermissionsRepository(dbContext);
            SubPermissionsItems = new SubPermissionsItemsRepository(dbContext);
        }


        public IDepartmentRepository Department { get; private set; }
        public IDepartmentUnitRepository DepartmentUnit { get; private set; }
        public IChannelsRepository Channels { get; private set; }
        public ITokenStoreRepository TokenStore { get; private set; }
        public IUserRepository Users { get; private set; }

        public IMenusRepository Menus { get; private set; }
        public ISubMenusRepository SubMenus { get; private set; }
        public ISubMenuItemsRepository SubMenuItems { get; private set; }

        public IPermissionsRepository AcccessPermissions { get; private set; }
        public ISubPermissionsRepository SubPermissions { get; private set; }
        public ISubPermissionsItemsRepository SubPermissionsItems { get; private set; }


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

