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
    public class SendNotificationHandler : IRequestHandler<SendNotificationCommand, string>
    {
        private readonly INotificationRepository _repository;
        private readonly INotificationSender _sender;

        public SendNotificationHandler(INotificationRepository repository, INotificationSender sender)
        {
            _repository = repository;
            _sender = sender;
        }

        public async Task<string> Handle(SendNotificationCommand command, CancellationToken cancellationToken)
        {
            var notification_msg = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, command.Request.Type, command.Request.UserId);


            if (command.Request.Type != NotificationType.Email)
            {
                await _repository.AddAsync(notification_msg);
            }

            

            var result = string.Empty;

            // Get user preferences
            var userPreferences = await _repository.GetUserPreferencesAsync(command.Request.UserId);

            // If no preferences found, use the default type from the command
            if (userPreferences == null)
            {
                return await SendNotificationByType(command.Request.Type, command);
            }

            // Send notifications based on user preferences
            if (userPreferences.EnableEmail)
            {
                //var emailNotification = new Notifications(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message, NotificationType.Email, command.Request.UserId);
                //await _repository.AddAsync(emailNotification);
                notification_msg.Subject = $"{command.Request.Subject}-{command.Request.DisplayName}";
                await _repository.AddAsync(notification_msg);

                result = await _sender.SendEmailAsync(notification_msg);
                if (result == "success")
                    notification_msg.MarkAsSent();
                else
                    notification_msg.Status = NotificationStatus.Failed;

                //await _repository.UpdateStatusAsync(emailNotification.Id, emailNotification.Status);

                //_response = result.ToString();
            }

            if (userPreferences.EnableSms)
            {
                //var smsNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.SMS, command.Request.UserId);
                //await _repository.AddAsync(smsNotification);

                result = await _sender.SendSMSAsync(notification_msg);
                if (result == "success")
                    notification_msg.MarkAsSent();
                else
                    notification_msg.Status = NotificationStatus.Failed;

                //await _repository.UpdateStatusAsync(smsNotification.Id, smsNotification.Status);
                //_response = result.ToString();
            }

            if (userPreferences.EnablePush)
            {
                //var pushNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.Push, command.Request.UserId);
                //await _repository.AddAsync(pushNotification);

                result = await _sender.PushAsync(notification_msg);
                if (result.Contains("/messages/"))
                    notification_msg.MarkAsSent();
                else
                    notification_msg.Status = NotificationStatus.Failed;

                //await _repository.UpdateStatusAsync(pushNotification.Id, pushNotification.Status);
                //_response = result.ToString();
            }

            if (userPreferences.EnableInApp)
            {
                //var inAppNotification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, NotificationType.InApp, command.Request.UserId);
                //await _repository.AddAsync(inAppNotification);

                result = await _sender.InAppAsync(notification_msg);
                if (result == "success")
                    notification_msg.MarkAsSent();
                else
                    notification_msg.Status = NotificationStatus.Failed;


                //await _repository.UpdateStatusAsync(inAppNotification.Id, inAppNotification.Status);
                //_response = result.ToString();
            }

            await _repository.UpdateStatusAsync(notification_msg.Id, notification_msg.Status);

            return result;
        }

        private async Task<string> SendNotificationByType(NotificationType type, SendNotificationCommand command)
        {
            var result = string.Empty;


            var notification = new Notifications(command.Request.RecipientContact, command.Request.Subject, command.Request.Message, type, command.Request.UserId);

            if (type != NotificationType.Email)
            {
                await _repository.AddAsync(notification);
            }

            switch (type)
            {
                
                case NotificationType.Email:
                    notification = new Notifications(command.Request.RecipientContact, $"{command.Request.Subject}-{command.Request.DisplayName}", command.Request.Message, NotificationType.Email, command.Request.UserId);
                    await _repository.AddAsync(notification);

                    result = await _sender.SendEmailAsync(notification);
                    if (result == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.SMS:
                    result = await _sender.SendSMSAsync(notification);
                    if (result == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.Push:
                    result = await _sender.PushAsync(notification);
                    if (result.Contains("/messages/"))
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;

                case NotificationType.InApp:
                    result = await _sender.InAppAsync(notification);
                    if (result == "success")
                        notification.MarkAsSent();
                    else
                        notification.Status = NotificationStatus.Failed;
                    break;
            }

            await _repository.UpdateStatusAsync(notification.Id, notification.Status);
            return result;
        }
    }

}

