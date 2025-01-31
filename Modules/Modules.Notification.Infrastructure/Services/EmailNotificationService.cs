using System;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace Modules.Notification.Infrastructure.Services
{
	public class EmailNotificationService : INotificationSender
    {
        private readonly IEmailSender _emailSender;

        public EmailNotificationService(IEmailSender emailSender)
		{
            _emailSender = emailSender;
		}

        public async Task<bool> SendAsync(Notifications values)
        {
            //throw new NotImplementedException();
            if (values.Type != NotificationType.Email)
                return false;

            await _emailSender.SendEmailAsync(values.UserId!, values.Subject!, values.Message!.ToString());
            return true;
        }
    }
}

