using Microsoft.AspNetCore.Identity.UI.Services;
using Modules.Notification.Application.Interfaces;
using Modules.Notification.Application.Dtos.Sms;

namespace Modules.Notification.Infrastructure.Services
{
	public class NotificationService : INotificationSender
    {
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;

        public NotificationService(IEmailSender emailSender, ISmsSender smsSender)
        {
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        public async Task<string> Send(Notifications values)
        {
            //throw new NotImplementedException();

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
            //throw new NotImplementedException();
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

