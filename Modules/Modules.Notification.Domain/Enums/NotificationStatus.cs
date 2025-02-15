using System;
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

