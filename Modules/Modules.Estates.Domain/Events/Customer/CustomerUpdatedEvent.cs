using System;

namespace Modules.Estates.Domain.Events.Customer
{
    public class CustomerUpdatedEvent : DomainEvent
    {
        public int CustomerMasterId { get; }
        public string CustomerCode { get; }
        public string UpdatedBy { get; }
        public string UpdateType { get; }

        public CustomerUpdatedEvent(int customerMasterId, string customerCode, string updatedBy, string updateType)
        {
            CustomerMasterId = customerMasterId;
            CustomerCode = customerCode;
            UpdatedBy = updatedBy;
            UpdateType = updateType;
        }
    }
}