// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Notification.Infrastructure.Services
{
	public class SmsNotificationService : INotificationSender
    {
        private readonly ISmsSender _smsSender;

        public SmsNotificationService(ISmsSender smsSender) => _smsSender = smsSender;

        public Task<string> PushAsync(Notifications notification)
        {
            throw new NotImplementedException();
        }

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

