using System;
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

