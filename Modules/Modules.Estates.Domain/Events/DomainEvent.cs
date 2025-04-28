// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.EntityFrameworkCore;

namespace Modules.Estates.Domain.Events
{
    [Keyless]
    public abstract class DomainEvent
    {
        public DateTime OccurredOn { get; }
        public string EventType { get; }

        protected DomainEvent()
        {
            OccurredOn = DateTime.UtcNow;
            EventType = GetType().Name;
        }
    }
}