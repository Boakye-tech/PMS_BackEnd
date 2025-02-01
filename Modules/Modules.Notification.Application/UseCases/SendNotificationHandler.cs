
namespace Modules.Notification.Application.UseCases
{
    public class SendNotificationHandler : IRequestHandler<SendNotificationCommand, Guid>
    {
        private readonly INotificationRepository _repository;
        private readonly INotificationSender _sender;

        public SendNotificationHandler(INotificationRepository repository, INotificationSender sender)
        {
            _repository = repository;
            _sender = sender;
        }

        public async Task<Guid> Handle(SendNotificationCommand command, CancellationToken cancellationToken)
        {
            var notification_msg = new Notifications(command.Request.UserId, command.Request.Subject, command.Request.Message, command.Request.Type);

            await _repository.AddAsync(notification_msg);

            var sent = await _sender.SendAsync(notification_msg);
            if (sent)
                notification_msg.MarkAsSent();

            await _repository.UpdateStatusAsync(notification_msg.Id, notification_msg.Status);

            return notification_msg.Id;
        }
    }

}

