using System;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Estates.Application.DTO.Management.ModuleServices;
using Modules.Estates.Application.Interfaces.ModuleServices;

namespace Modules.Estates.Application.UseCases.ModuleServices
{
	public class ModuleCommunicationServices : IModuleCommunicationServices
	{
        private readonly HttpClient _httpClient;
        private readonly ILogger<ModuleCommunicationServices> _logger;
        private readonly IConfiguration _config;

        public ModuleCommunicationServices(HttpClient httpClient, ILogger<ModuleCommunicationServices> logger, IConfiguration config)
		{
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
        }

        public async Task<bool> SendCustomerDetailsAsync(OnlineCustomerDetailsDto payload)
        {
            //throw new NotImplementedException();
            return await SendDataAsync("OnlineCustomer/AddCustomerDetails", payload);
            
        }

        public async Task<bool> SendIdentificationTypeAsync(IdentificationTypeDto payload)
        {
            //throw new NotImplementedException();
            return await SendDataAsync("Administration/CreateIdentificationType", payload);

        }

        public async Task<bool> SendPropertyDetailsAsync(OnlinePropertyDetailsDto payload)
        {
            //throw new NotImplementedException();
            return await SendDataAsync("OnlineCustomer/AddPropertyDetails", payload);
        }


        private async Task<bool> SendDataAsync<T>(string endpoint, T payload)
        {
            var baseurl = _config.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var Url = $"{baseurl}{endpoint}";

            try
            {
                string jsonPayload = JsonSerializer.Serialize(payload);
                using var httpContent = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
                using var response = await _httpClient.PostAsync(Url, httpContent);

                if (!response.IsSuccessStatusCode)
                {
                    _logger.LogWarning("Failed to send data to User Module. Endpoint: {Endpoint}, Status Code: {StatusCode}", endpoint, response.StatusCode);
                }

                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sending data to User Module: {Endpoint}", endpoint);
                return false;
            }
        }




    }
}

