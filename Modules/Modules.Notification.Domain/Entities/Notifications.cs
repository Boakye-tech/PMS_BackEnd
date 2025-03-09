﻿using System;

namespace Modules.Notification.Domain.Entities
{
	public class Notifications
	{
        public Guid Id { get; private set; }
        public string? UserId { get; private set; }
        public string? Subject { get; private set; }
        public string? Message { get; private set; }
        public NotificationType Type { get; private set; }
        public NotificationStatus Status { get; set; }
        public DateTime CreatedAt { get; private set; }

        private Notifications() { }

        public Notifications(string userId, string subject, string message, NotificationType type)
        {
            Id = Guid.NewGuid();
            UserId = userId;
            Subject = subject;
            Message = message;
            Type = type;
            Status = NotificationStatus.Pending;
            CreatedAt = DateTime.UtcNow;
        }

        public void MarkAsSent() => Status = NotificationStatus.Sent;
    }
}

