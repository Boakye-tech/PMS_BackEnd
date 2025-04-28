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