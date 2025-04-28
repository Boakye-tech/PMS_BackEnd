// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Domain.Events.Complaints
{
	public class ComplaintCreatedEvent : DomainEvent
	{
        public string ComplaintNumber { get; }
        public ComplaintStatusEnum ComplaintStatus { get; set; }
        public string CreatedBy { get; }


        public ComplaintCreatedEvent(string complaintNumber, ComplaintStatusEnum complaintStatus, string createdBy)
		{
            ComplaintNumber = complaintNumber;
            ComplaintStatus = complaintStatus;
            CreatedBy = createdBy;
		}
	}

    
}

