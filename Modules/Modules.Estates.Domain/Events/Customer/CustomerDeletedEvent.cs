using System;

namespace Modules.Estates.Domain.Events.Customer
{
    public class CustomerDeletedEvent : DomainEvent
    {
        public int CustomerMasterId { get; }
        public string CustomerCode { get; }
        public string DeletedBy { get; }
        public string Reason { get; }

        public CustomerDeletedEvent(int customerMasterId, string customerCode, string deletedBy, string reason)
        {
            CustomerMasterId = customerMasterId;
            CustomerCode = customerCode;
            DeletedBy = deletedBy;
            Reason = reason;
        }
    }
}