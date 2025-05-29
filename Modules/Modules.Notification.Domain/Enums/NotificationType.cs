// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Enums/NotificationType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Notification.Domain.Enums
{
	public enum NotificationType
	{
        Email = 0,
        SMS = 1,
        Push = 2,
        InApp = 3
    }

    public static class RegistrationStatusEnumDescription
    {
        public static NotificationType NotificationTypeEnum(int input)
        {
            if (Enum.IsDefined(typeof(NotificationType), input))
            {
                return (NotificationType)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for notification types.");
            }
        }

    }

}

