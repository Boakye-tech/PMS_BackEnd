using System;
using Microsoft.EntityFrameworkCore;

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
        }


        public IDepartmentRepository Department { get; private set; }
        public IDepartmentUnitRepository DepartmentUnit { get; private set; }
        public ITokenStoreRepository TokenStore { get; private set; }
        public IUserRepository Users { get; private set; }

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

