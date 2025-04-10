using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Modules.Users.Application.Services
{
	public class NotificationServices : INotificationServices
    {
        private readonly HttpClient _httpClient;

        public NotificationServices(HttpClient httpClient)
		{
            _httpClient = httpClient;
        }

        public async Task<bool> SendTemporaryPasswordEmailNotification(ApplicationIdentityUser user, string temp_password)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Dear {user!.FirstName} {user.LastName},<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Your account has been activated<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Kindly use this temporary pass <b>{temp_password}</b> to login.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"If you didn’t make this request, kindly ignore this email or contact our support team immediately.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Thank you for your attention.<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"Kind regards,<br>");
            sb.AppendLine("<br>");
            sb.AppendLine($"TDC MIS Team<br>");
            sb.AppendLine($"TDC Ghana Ltd.<br>");
            sb.AppendLine($"0302211211<br>");

            var email_payload = new { userId = user.Email, displayName = "Notifications", subject = "Account Activation", message = sb.ToString(), type = 0 };

            string json_emailpayload = JsonSerializer.Serialize(email_payload);
            var email_httpContent = new StringContent(json_emailpayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _httpClient.PostAsync("https://mindsprings-002-site1.ltempurl.com/api/v1/Notification/SendNotification", email_httpContent);
            var result = response.IsSuccessStatusCode;

            return result;
        }
    }
}

