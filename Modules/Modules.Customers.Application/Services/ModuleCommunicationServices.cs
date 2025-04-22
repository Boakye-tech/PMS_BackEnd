using System;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Common.Infrastructure.Authentication;

namespace Modules.Customers.Application.Services
{
	public class CustomerModuleCommunicationServices : ICustomerModuleCommunicationServices
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<CustomerModuleCommunicationServices> _logger;
        private readonly IConfiguration _config;
        private readonly IUserContextService _userContextService;

        public CustomerModuleCommunicationServices(HttpClient httpClient, ILogger<CustomerModuleCommunicationServices> logger, IConfiguration config, IUserContextService userContextService)
        {
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
            _userContextService = userContextService;
        }

        public async Task<bool> SendSubmittedComplaintDetailsAsync(ComplaintCreateDto payload)
        {
            return await SendDataAsync("Customer/SubmitComplaint", payload);
        }


        private async Task<bool> SendDataAsync<T>(string endpoint, T payload)
        {
            var baseurl = _config.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var Url = $"{baseurl}{endpoint}";
            var token = _userContextService.GetAccessToken();

            try
            {
                string jsonPayload = JsonSerializer.Serialize(payload);
                using var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                using var response = await _httpClient.PostAsync(Url, httpContent);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Failed to send data to module. Endpoint: {Endpoint}, Status Code: {StatusCode}", endpoint, response.StatusCode);
                    return response.IsSuccessStatusCode;
                }

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sending data to moodule: {Endpoint}", endpoint);
                return false;
            }
        }

    }
}

