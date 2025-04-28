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