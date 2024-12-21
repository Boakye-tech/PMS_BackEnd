using System;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDepartmentRepository Department { get; }
        IDepartmentUnitRepository DepartmentUnit { get; }
        ITokenStoreRepository TokenStore { get; }
        IUserRepository Users { get; }

        Task<int> Complete();
    }
}

