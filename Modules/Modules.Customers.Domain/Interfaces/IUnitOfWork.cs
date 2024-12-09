
namespace Modules.Customers.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        int Complete();
    }
}

