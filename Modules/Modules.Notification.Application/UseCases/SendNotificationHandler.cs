using System;
using Modules.Notification.Domain.Entities;
using Modules.Notification.Domain.Interfaces;

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
            var notification_msg = new Notifications(command.Request.UserId, command.Request.Message, command.Request.Type);

            await _repository.AddAsync(notification_msg);

            var sent = await _sender.SendAsync(notifications);
            if (sent)
                notification.MarkAsSent();

            await _repository.UpdateStatusAsync(notification.Id, notification.Status);

            return notification.Id;
        }
    }

}

