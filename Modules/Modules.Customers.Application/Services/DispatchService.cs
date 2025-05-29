// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Services/DispatchService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/05/2025 3:09 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Common.Infrastructure.Authentication;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Modules.Customers.Application.Services
{
	public class DispatchService : IDispatchService
    {
        private readonly HttpClient? _httpClient;
        private readonly ILogger<DispatchService>? _logger;
        private readonly IConfiguration? _config;
        private readonly IUserContextService? _userContextService;


        public DispatchService(HttpClient httpClient, ILogger<DispatchService> logger, IConfiguration config, IUserContextService userContextService)
        {
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
            _userContextService = userContextService;
        }

        public async Task<bool> SendDataAsync<T>(string endpoint, T payload, string httpMethod)
        {
            var baseurl = _config!.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var Url = $"{baseurl}{endpoint}";
            var token = _userContextService!.GetAccessToken();

            try
            {
                string jsonPayload = JsonSerializer.Serialize(payload);
                using var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                _httpClient!.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                HttpResponseMessage response = httpMethod switch
                {
                    "POST" => await _httpClient.PostAsync(Url, httpContent),
                    "PUT" => await _httpClient.PutAsync(Url, httpContent),
                    _ => null!
                };

                if (response == null)
                {
                    _logger!.LogWarning("Unsupported HTTP method: {HttpMethod}", httpMethod);
                    return false;
                }

                using (response)
                {
                    if (!response.IsSuccessStatusCode)
                    {
                        _logger!.LogWarning("Failed to send data to module. Endpoint: {Endpoint}, Status Code: {StatusCode}", Url, response.StatusCode);
                    }

                    return response.IsSuccessStatusCode;
                }
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Error occurred while sending data to moodule: {Endpoint}", endpoint);
                return false;
            }
        }


    }
}

