using System;
using Modules.Notification.Domain.Enums;

namespace Modules.Notification.Domain.Interfaces
{
	public interface INotificationRepository
	{
        Task AddAsync(Notifications notification_msg);
        Task<IEnumerable<Notifications>> GetPendingNotificationsAsync();
        Task UpdateStatusAsync(Guid notificationId, NotificationStatus status);
    }
}

