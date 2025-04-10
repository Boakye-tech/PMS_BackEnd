using System;
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