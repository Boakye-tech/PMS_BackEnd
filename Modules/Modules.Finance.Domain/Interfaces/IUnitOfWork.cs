using System;
namespace Modules.Finance.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {

        int Complete();
    }

}

