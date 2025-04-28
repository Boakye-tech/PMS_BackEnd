// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Identity.UI.Services;

namespace Modules.Notification.Infrastructure.Services
{
	public class NotificationService : INotificationSender
    {
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly IPushSender _pushSender;

        public NotificationService(IEmailSender emailSender, ISmsSender smsSender, IPushSender pushSender)
        {
            _emailSender = emailSender;
            _smsSender = smsSender;
            _pushSender = pushSender;
        }

        public async Task<string> PushAsync(Notifications values)
        {
            if(values.Type != NotificationType.Push)
            {
                return "Invalid notification type.";
            }

            var response = await _pushSender.PushMessageAsync(new Application.Dtos.PushNotificationDto(Title: values.Subject!, Body: values.Message!, DeviceToken: values.UserId!));
            return response;
        }

        public async Task<string> Send(Notifications values)
        {
            if (values.Type == NotificationType.Email)
            {
                await _emailSender.SendEmailAsync(values.UserId!, values.Subject!, values.Message!.ToString());
                return true.ToString();

            }

            if (values.Type == NotificationType.SMS)
            {
                var response = _smsSender.SendMessage(new SendSmsRequestDto { mobileNumber = values.UserId, message_content = values.Message });
                return response;
            }

            return false.ToString();
        }

        public async Task<bool> SendAsync(Notifications values)
        {
            if (values.Type == NotificationType.Email)
            {
                await _emailSender.SendEmailAsync(values.UserId!, values.Subject!, values.Message!.ToString());
                return true;

            }

            if(values.Type == NotificationType.SMS)
            {
                var response = await _smsSender.SendMessageAsync(new SendSmsRequestDto { mobileNumber = values.UserId, message_content = values.Message});
                return true;
            }

            return false;
        }
    }
}

