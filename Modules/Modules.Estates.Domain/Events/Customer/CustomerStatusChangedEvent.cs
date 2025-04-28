// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Domain.Events.Customer
{
    public class CustomerStatusChangedEvent : DomainEvent
    {
        public int CustomerMasterId { get; }
        public string CustomerCode { get; }
        public string OldStatus { get; }
        public string NewStatus { get; }
        public string ChangedBy { get; }

        public CustomerStatusChangedEvent(
            int customerMasterId,
            string? customerCode,
            string oldStatus,
            string newStatus,
            string changedBy)
        {
            CustomerMasterId = customerMasterId;
            CustomerCode = customerCode!;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            ChangedBy = changedBy;
        }
    }
}