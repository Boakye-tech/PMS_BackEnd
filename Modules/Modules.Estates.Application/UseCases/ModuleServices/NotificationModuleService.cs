// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/ModuleServices/NotificationModuleService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/05/2025 2:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Estates.Domain.Events.Complaints;

namespace Modules.Estates.Application.UseCases.ModuleServices
{
	public class NotificationModuleService: INotificationModuleService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ModuleCommunicationServices> _logger;
        private readonly IConfiguration _config;
        private readonly IUserContextService _userContextService;

        public NotificationModuleService(HttpClient httpClient, ILogger<ModuleCommunicationServices> logger, IConfiguration config, IUserContextService userContextService)
        {
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
            _userContextService = userContextService;
        }

        public Task<bool> SendEmailNotificationAsync(ComplaintStatusChangedEvent payload)
        {
            throw new NotImplementedException();

            //var email_payload = new { userId = user.Email, displayName = "Notifications", subject = "OTP VERIFICATION", message = sb.ToString(), type = 0 };
            //var sms_payload = new { userId = user.PhoneNumber, displayName = string.Empty, subject = string.Empty, message = $"Kindly use OTP {token}  for account verification. 'NEVER SHARE THIS OTP WITH ANYONE'", type = 1 };

        }

        public Task<bool> SendPushNotificationAsync(ComplaintStatusChangedEvent payload)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendSmsNotificationAsync(ComplaintStatusChangedEvent payload)
        {
            throw new NotImplementedException();
        }


        private async Task<bool> SendDataAsync<T>(string endpoint, T payload, string httpMethod)
        {
            var baseurl = _config.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var Url = $"{baseurl}{endpoint}";
            var token = _userContextService.GetAccessToken();


            try
            {
                string jsonPayload = JsonSerializer.Serialize(payload);
                using var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = httpMethod switch
                {
                    "POST" => await _httpClient.PostAsync(Url, httpContent),
                    "PUT" => await _httpClient.PutAsync(Url, httpContent),
                    _ => null!
                };

                if (response == null)
                {
                    _logger.LogWarning("Unsupported HTTP method: {HttpMethod}", httpMethod);
                    return false;
                }

                using (response)
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        _logger.LogWarning("Failed to send data to module. Endpoint: {Endpoint}, Status Code: {StatusCode}", Url, response.StatusCode);
                    }

                    return response.IsSuccessStatusCode;
                }

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sending data to moodule: {Endpoint}", endpoint);
                return false;
            }
        }

    }
}

