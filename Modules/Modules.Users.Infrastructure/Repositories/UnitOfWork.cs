using System;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Domain.Interfaces.Entities.Menu;
using Modules.Users.Infrastructure.Repositories.Entities.Menu;

namespace Modules.Users.Infrastructure.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
        private bool disposedValue;
        private readonly UserDbContext _dbContext;

        public UnitOfWork(UserDbContext dbContext)
		{
            _dbContext = dbContext;

            Department = new DepartmentRepository(dbContext);
            DepartmentUnit = new DepartmentUnitRepository(dbContext);
            TokenStore = new TokenStoreRepository(dbContext);
            Users = new UserRepository(dbContext);

            MenuActions = new MenuActionsRepository(dbContext);
            RoleMenuActions = new RoleMenuActionsRepository(dbContext);
            Menus = new MenusRepository(dbContext);
            SubMenus = new SubMenusRepository(dbContext);
        }


        public IDepartmentRepository Department { get; private set; }
        public IDepartmentUnitRepository DepartmentUnit { get; private set; }
        public ITokenStoreRepository TokenStore { get; private set; }
        public IUserRepository Users { get; private set; }

        public IMenuActionsRepository MenuActions { get; private set; }
        public IRoleMenuActionsRepository RoleMenuActions { get; private set; }
        public IMenusRepository Menus { get; private set; }
        public ISubMenusRepository SubMenus { get; private set; }

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

