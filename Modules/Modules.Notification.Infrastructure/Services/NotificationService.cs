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
using Newtonsoft.Json.Linq;

namespace Modules.Notification.Infrastructure.Services
{
	public class NotificationService : INotificationSender
    {
        private readonly IEmailSender _emailSender;
        private readonly ISmsSender _smsSender;
        private readonly IPushSender _pushSender;
        private readonly ISignalRNotificationService _signalRNotificationService;

        public NotificationService(IEmailSender emailSender, ISmsSender smsSender, IPushSender pushSender, ISignalRNotificationService signalRNotificationService)
        {
            _emailSender = emailSender;
            _smsSender = smsSender;
            _pushSender = pushSender;
            _signalRNotificationService = signalRNotificationService;
        }

        public async Task<string> InAppAsync(Notifications values)
        {
            try
            {
                if (values.Type != NotificationType.InApp)
                {
                    return "Invalid notification type.";
                }

                await _signalRNotificationService.SendNotificationToUserAsync(values.RecipientContact!, values);
                return "success";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public async Task<string> PushAsync(Notifications values)
        {
            try
            {
                if (values.Type != NotificationType.Push)
                {
                    return "Invalid notification type.";
                }

                var response = await _pushSender.PushMessageAsync(new PushNotificationDto(Title: values.Subject!, Body: values.Message!, DeviceToken: values.RecipientContact!));
                return response;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        
        public async Task<string> SendEmailAsync(Notifications values)
        {
            try
            {
                if (values.Type != NotificationType.Email)
                {
                    return "Invalid notification type.";
                }

                await _emailSender.SendEmailAsync(values.RecipientContact!, values.Subject!, values.Message!.ToString());
                return "success";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }

        public async Task<string> SendSMSAsync(Notifications values)
        {
            try
            {
                if (values.Type != NotificationType.SMS)
                {
                    return "Invalid notification type.";
                }

                var response = await _smsSender.SendMessageAsync(new SendSmsRequestDto { mobileNumber = values.RecipientContact, message_content = values.Message });
                return response;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}

