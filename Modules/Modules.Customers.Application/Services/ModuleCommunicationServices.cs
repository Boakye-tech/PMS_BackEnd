// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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
            return await SendDataAsync("Customer/SubmitComplaint", payload, "POST");
        }

        public async Task<bool> SendModifiedComplaintDetailsAsync(ComplaintUpdateDto payload)
        {
            return await SendDataAsync("Customer/ModifyComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintCancelledAsync(ComplaintCancellationDto payload)
        {
            return await SendDataAsync("Customer/CancelComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintClosedAsync(ComplaintClosedDto payload)
        {
            return await SendDataAsync("Customer/CloseComplaint", payload, "PUT");
        }

        public async Task<bool> SendComplaintReopenAsync(ComplaintReopenedDto payload)
        {
            return await SendDataAsync("Customer/ReopenComplaint", payload, "PUT");
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

