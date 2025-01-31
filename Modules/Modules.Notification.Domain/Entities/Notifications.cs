using System;

namespace Modules.Notification.Domain.Entities
{
	public class Notifications
	{
        public Guid Id { get; private set; }
        public string? UserId { get; private set; }
        public string? Message { get; private set; }
        public NotificationType Type { get; private set; }
        public NotificationStatus Status { get; set; }
        public DateTime CreatedAt { get; private set; }

        private Notifications() { }

        public Notifications(string userId, string message, NotificationType type)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Message = message;
            Type = type;
            Status = NotificationStatus.Pending;
            CreatedAt = DateTime.UtcNow;
        }

        public void MarkAsSent() => Status = NotificationStatus.Sent;
    }
}

