using System;
namespace Modules.Notification.Application.Dtos
{
	public record PushNotificationDto(string Title, string Body, string DeviceToken);
}

