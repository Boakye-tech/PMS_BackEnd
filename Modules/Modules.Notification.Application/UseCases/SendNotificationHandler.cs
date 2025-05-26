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

        public SendNotificationHandler(INotificationRepository repository, INotificationSender sender) 
        {
            _repository = repository;
            _sender = sender;
        }

        public async Task<Guid> Handle(SendNotificationCommand command, CancellationToken cancellationToken)
        {

            var notification_msg = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, command.Request.Type, command.Request.UserId);

            await _repository.AddAsync(notification_msg);

            switch (command.Request.Type)
            {
                case NotificationType.Email:
                   
                    var notification_email = new Notifications(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message, command.Request.Type, command.Request.UserId);

                    var result = await _sender.SendEmailAsync(notification_email);
                    if (result == "success")
                        notification_email.MarkAsSent();
                    else
                        notification_email.Status = NotificationStatus.Failed;


                    await _repository.UpdateStatusAsync(notification_email.Id, notification_email.Status);
                    return notification_email.Id;

                case NotificationType.SMS:
                    var sent = await _sender.SendSMSAsync(notification_msg);
                    if (sent == "success")
                        notification_msg.MarkAsSent();
                    else
                        notification_msg.Status = NotificationStatus.Failed;

                    break;

                case NotificationType.Push:
                    var response = await _sender.PushAsync(notification_msg);
                    if (response.Contains("/messages/"))
                        notification_msg.MarkAsSent();
                    else
                        notification_msg.Status = NotificationStatus.Failed;

                    break;


                case NotificationType.InApp:
                    var _response = await _sender.InAppAsync(notification_msg);
                    if (_response == "success")
                        notification_msg.MarkAsSent();
                    else
                        notification_msg.Status = NotificationStatus.Failed;

                    break;
            }

            await _repository.UpdateStatusAsync(notification_msg.Id, notification_msg.Status);
            return notification_msg.Id;


        }
    }

}

