using System;
using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace Modules.Notification.Infrastructure.Services
{
	public class EmailSender : IEmailSender
	{
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                UseDefaultCredentials = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSSL
            };

            string displayName = subject.Split("-")[1];
            string emailSubject = subject.Split("-")[0];

            return client.SendMailAsync(new MailMessage(new MailAddress(_userName, displayName).ToString(), email, emailSubject, htmlMessage) { IsBodyHtml = true });

        }
    }
}

