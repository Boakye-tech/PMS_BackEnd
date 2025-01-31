using System;
using Modules.Notification.Domain.Interfaces;

namespace Modules.Notification.Infrastructure.Services
{
	public class EmailNotificationService : INotificationSender
    {
		public EmailNotificationService()
		{
		}

        public Task<bool> SendAsync(Notifications notification)
        {
            throw new NotImplementedException();
        }
    }
}

