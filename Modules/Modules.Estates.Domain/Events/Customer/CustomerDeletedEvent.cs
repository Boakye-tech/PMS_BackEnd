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