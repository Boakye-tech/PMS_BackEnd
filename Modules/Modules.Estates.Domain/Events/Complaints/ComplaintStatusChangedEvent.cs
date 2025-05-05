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
	public class ComplaintStatusChangedEvent : DomainEvent
    {
		public string ComplaintNumber { get;  }
        public ComplaintStatusEnum ComplaintStatus { get;  }
        public string ActionBy { get;  }


        public ComplaintStatusChangedEvent(string complaintNumber, ComplaintStatusEnum complaintStatus, string actionBy)
		{
            ComplaintNumber = complaintNumber ?? throw new ArgumentNullException(nameof(complaintNumber));
            ComplaintStatus = complaintStatus;
            ActionBy = actionBy ?? throw new ArgumentNullException(nameof(actionBy));
        }

    }

}

