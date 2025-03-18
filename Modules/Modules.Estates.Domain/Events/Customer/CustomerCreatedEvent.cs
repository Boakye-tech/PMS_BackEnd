using System;

namespace Modules.Estates.Domain.Events.Customer
{
    public class CustomerCreatedEvent : DomainEvent
    {
        public int CustomerMasterId { get; }
        public string CustomerCode { get; }
        public string CustomerType { get; }
        public string CreatedBy { get; }

        public CustomerCreatedEvent(int customerMasterId, string customerCode, string customerType, string createdBy)
        {
            CustomerMasterId = customerMasterId;
            CustomerCode = customerCode;
            CustomerType = customerType;
            CreatedBy = createdBy;
        }
    }
}