using System;

namespace Modules.Notification.Domain.Interfaces
{
	public interface IPushNotificationSender
	{
        Task<string> PushAsync(Notifications values);
    }
}

