using System;

namespace Modules.Notification.Application.Dtos
{
    public record SendNotificationRequest(string UserId, string Message, NotificationType Type);

}

