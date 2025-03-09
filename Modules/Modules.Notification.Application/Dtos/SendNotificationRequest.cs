
namespace Modules.Notification.Application.Dtos
{

    public record SendNotificationRequest(string UserId, string Subject ,string Message, NotificationType Type);

    public record SendNotificationRequestDto(string UserId, string DisplayName, string Subject, string Message, NotificationType Type); 

}

