
namespace Modules.Notification.Application.UseCases
{
    public class SendNotificationCommand : IRequest<Guid>
    {
        public SendNotificationRequest Request { get; }

        public SendNotificationCommand(SendNotificationRequest request) => Request = request;
    }

}

