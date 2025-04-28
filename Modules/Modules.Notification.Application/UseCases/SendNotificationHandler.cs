// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.UseCases
{
    public class SendNotificationHandler : IRequestHandler<SendNotificationCommand, Guid>
    {
        private readonly INotificationRepository _repository;
        private readonly INotificationSender _sender;
        //private readonly IPushNotificationSender _pushSender;

        public SendNotificationHandler(INotificationRepository repository, INotificationSender sender) //, IPushNotificationSender pushSender
        {
            _repository = repository;
            _sender = sender;
            //_pushSender = pushSender;
        }

        public async Task<Guid> Handle(SendNotificationCommand command, CancellationToken cancellationToken)
        {
            var notification_msg = new Notifications(command.Request.UserId, command.Request.Subject, command.Request.Message, command.Request.Type);

            await _repository.AddAsync(notification_msg);

            if(command.Request.Type == NotificationType.Push)
            {
                var response = await _sender.PushAsync(notification_msg);
                if (response.Contains("/messages/"))
                    notification_msg.MarkAsSent();
                else
                    notification_msg.Status = NotificationStatus.Failed;

                await _repository.UpdateStatusAsync(notification_msg.Id, notification_msg.Status);
                return notification_msg.Id;
            }

            var sent = await _sender.SendAsync(notification_msg);
            if (sent)
                notification_msg.MarkAsSent();
            else
                notification_msg.Status = NotificationStatus.Failed;

            await _repository.UpdateStatusAsync(notification_msg.Id, notification_msg.Status);
            return notification_msg.Id;
        }
    }

}

