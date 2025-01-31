using System;

namespace Modules.Notification.Domain.Interfaces
{
	public interface INotificationSender
	{
        Task<bool> SendAsync(Notifications notification);
    }
}

