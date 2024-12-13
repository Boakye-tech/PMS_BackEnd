using System;
namespace Modules.Users.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        //IBankRepository Bank { get; }s
        


        Task<int> Complete();
    }
}

