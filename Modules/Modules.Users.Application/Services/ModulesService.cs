// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Users.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Users.Application/Services/ModulesServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025
// * Modified Date: 08/07/2025
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Common.Infrastructure.Authentication;

namespace Modules.Users.Application.Services
{
	public class ModulesService : IModulesService
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ModulesService> _logger;
        private readonly IConfiguration _config;
        private readonly IUserContextService _userContextService;


        public ModulesService(HttpClient httpClient, ILogger<ModulesService> logger, IConfiguration config, IUserContextService userContextService)
		{
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
            _userContextService = userContextService;
        }

        public async Task<bool> SendDepartmentDetailsAsync(DepartmentCreateDto payload)
        {
            return await SendDataAsync("Finance/CreateDepartment", payload, "POST");
        }

        public async Task<bool> SendDepartmentUnitDetailsAsync(DepartmentUnitCreateDto payload)
        {
            return await SendDataAsync("Finance/CreateDepartmentUnit", payload, "POST");
        }

        public async Task<bool> SendModifiedDepartmentDetailsAsync(DepartmentUpdateDto payload)
        {
            return await SendDataAsync("Finance/UpdateDepartment", payload, "POST");
        }

        public async Task<bool> SendModifiedDepartmentUnitDetailsAsync(DepartmentUnitUpdateDto payload)
        {
            return await SendDataAsync("Finance/UpdateDepartmentUnit", payload, "POST");
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

            var email_payload = new { recipientContact = user.Email, displayName = "Notifications", subject = "Account Activation", message = sb.ToString(), type = 0, userId = user.Id };

            return await SendDataAsync("Notification/SendNotification", email_payload, "POST");
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

