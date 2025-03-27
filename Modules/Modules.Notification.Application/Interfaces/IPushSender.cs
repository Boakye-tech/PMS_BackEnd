using System;
using Modules.Notification.Application.Dtos.Sms;

namespace Modules.Notification.Application.Interfaces
{
	public interface IPushSender
	{
        Task<string> PushMessageAsync(PushNotificationDto pushRequest);
    }
}

