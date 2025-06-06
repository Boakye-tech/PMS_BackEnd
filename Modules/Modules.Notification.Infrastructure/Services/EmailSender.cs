// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/EmailSender.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 7:09 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

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
            //return result;
        }
    }
}

