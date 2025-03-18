using System.Threading.Tasks;

namespace Modules.Estates.Domain.Events
{
    public interface IDomainEventDispatcher
    {
        Task DispatchAsync(DomainEvent domainEvent);
    }
}