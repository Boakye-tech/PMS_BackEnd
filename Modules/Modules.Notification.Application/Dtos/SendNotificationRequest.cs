
namespace Modules.Notification.Application.Dtos
{
    public record SendNotificationRequest(string UserId,string Subject ,string Message, NotificationType Type);

}

