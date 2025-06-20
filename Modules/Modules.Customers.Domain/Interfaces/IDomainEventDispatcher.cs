// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Domain
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/06/2025
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Customers.Domain.Events;

namespace Modules.Customers.Domain.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task DispatchEventsAsync(IEnumerable<ComplaintDomainEvent> domainEvents);
    }
}