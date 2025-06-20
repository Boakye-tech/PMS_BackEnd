// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Enums/NotificationStatus.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Notification.Domain.Enums
{
	public enum NotificationStatus
	{
        Pending = 0,
        Sent = 1,
        Failed = 2
    }


    public static class NotificationStatusEnumDescription
    {
        public static NotificationStatus NotificationStatusEnum(int input)
        {
            if (Enum.IsDefined(typeof(NotificationStatus), input))
            {
                return (NotificationStatus)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for notification status.");
            }
        }

    }

}

