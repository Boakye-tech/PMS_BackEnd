// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendNotificationHandler.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 2:54 PM
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

            // Get user preferences
            var userPreferences = await _repository.GetUserPreferencesAsync(command.Request.UserId);

            // If no preferences found, use the default type from the command
            if (userPreferences == null)
            {
                return await SendNotificationByType(command.Request.Type, notification_msg);
            }

            // Send notifications based on user preferences
            if (userPreferences.EnableEmail)
            {
                var emailNotification = new Notifications(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message, NotificationType.Email, command.Request.UserId);
                var result = await _sender.SendEmailAsync(emailNotification);
                if (result == "success")
                    emailNotification.MarkAsSent();
                else
                    emailNotification.Status = NotificationStatus.Failed;
                await _repository.UpdateStatusAsync(emailNotification.Id, emailNotification.Status);
            }

            if (userPreferences.EnableSms)
            {
                var smsNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.SMS, command.Request.UserId);
                var result = await _sender.SendSMSAsync(smsNotification);
                if (result == "success")
                    smsNotification.MarkAsSent();
                else
                    smsNotification.Status = NotificationStatus.Failed;
                await _repository.UpdateStatusAsync(smsNotification.Id, smsNotification.Status);
            }

            if (userPreferences.EnablePush)
            {
                var pushNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.Push, command.Request.UserId);
                var result = await _sender.PushAsync(pushNotification);
                if (result.Contains("/messages/"))
                    pushNotification.MarkAsSent();
                else
                    pushNotification.Status = NotificationStatus.Failed;
                await _repository.UpdateStatusAsync(pushNotification.Id, pushNotification.Status);
            }

            if (userPreferences.EnableInApp)
            {
                var inAppNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.InApp, command.Request.UserId);
                var result = await _sender.InAppAsync(inAppNotification);
                if (result == "success")
                    inAppNotification.MarkAsSent();
                else
                    inAppNotification.Status = NotificationStatus.Failed;
                await _repository.UpdateStatusAsync(inAppNotification.Id, inAppNotification.Status);
            }

            return notification_msg.Id;
        }

        private async Task<Guid> SendNotificationByType(NotificationType type, Notifications notification)
        {
            switch (type)
            {
                case NotificationType.Email:
                    var result = await _sender.SendEmailAsync(notification);
                    if (result == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.SMS:
                    var sent = await _sender.SendSMSAsync(notification);
                    if (sent == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.Push:
                    var response = await _sender.PushAsync(notification);
                    if (response.Contains("/messages/"))
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.InApp:
                    var _response = await _sender.InAppAsync(notification);
                    if (_response == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;
            }

            await _repository.UpdateStatusAsync(notification.Id, notification.Status);
            return notification.Id;
        }
    }

}

