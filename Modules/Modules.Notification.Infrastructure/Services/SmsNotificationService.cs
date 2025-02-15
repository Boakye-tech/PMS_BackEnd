using Microsoft.AspNetCore.Identity.UI.Services;
using Modules.Notification.Application.Dtos.Sms;
using Modules.Notification.Application.Interfaces;

namespace Modules.Notification.Infrastructure.Services
{
	public class SmsNotificationService : INotificationSender
    {
        private readonly ISmsSender _smsSender;

        public SmsNotificationService(ISmsSender smsSender) => _smsSender = smsSender;

        public Task<string> Send(Notifications values)
        {
            //throw new NotImplementedException();
            if (values.Type != NotificationType.SMS)
                return Task.FromResult(false.ToString());

            SendSmsRequestDto request = new SendSmsRequestDto { mobileNumber = values.UserId, message_content = values.Message };

            var response = _smsSender.SendMessage(request);
            return Task.FromResult(response);
        }

        public async Task<bool> SendAsync(Notifications values)
        {
            //throw new NotImplementedException();
            if (values.Type != NotificationType.SMS)
                return false;

            SendSmsRequestDto request = new SendSmsRequestDto { mobileNumber = values.UserId, message_content = values.Message };

            var response = await _smsSender.SendMessageAsync(request);
            return true;
        }
    }
}

