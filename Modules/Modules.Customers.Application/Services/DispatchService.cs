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
            var token = _userContextService!.GetAccessToken();
            var Url = $"{baseurl}{endpoint}";

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
                    return default;
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
                return default;
            }
        }

        public async Task<TResponse?> SendGetAsync<TResponse>(string endpoint)
        {
            var baseUrl = _config!.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var token = _userContextService!.GetAccessToken();
            var url = $"{baseUrl}{endpoint}";

            try
            {
                _httpClient!.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    _logger!.LogWarning("GET request failed. URL: {Url}, Status Code: {StatusCode}", url, response.StatusCode);
                    return default!;
                }

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Error during GET request to: {Endpoint}", endpoint);
                return default;
            }
        }

        public async Task<TResponse?> SendGetWithQueryAsync<TResponse>(string endpoint, string queryParams)
        {
            var baseUrl = _config!.GetSection("ModuleUrl").GetSection("BaseUrl").Value;
            var token = _userContextService!.GetAccessToken();
            //var url = BuildUrlWithQueryParams($"{baseUrl}{endpoint}", queryParams);

            var url = $"{baseUrl}{endpoint}{queryParams}";

            try
            {
                _httpClient!.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

                var response = await _httpClient.GetAsync(url);
                if (!response.IsSuccessStatusCode)
                {
                    _logger!.LogWarning("GET with query failed. URL: {Url}, Status Code: {StatusCode}", url, response.StatusCode);
                    return default!;
                }

                var content = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }
            catch (Exception ex)
            {
                _logger!.LogError(ex, "Error during GET request with query to: {Endpoint}", endpoint);
                return default!;
            }
        }


        private static string BuildUrlWithQueryParams<T>(string baseUrl, T queryParams)
        {
            if (queryParams == null)
                return baseUrl;

            var props = typeof(T).GetProperties()
                .Where(p => p.GetValue(queryParams) != null)
                .Select(p => $"{Uri.EscapeDataString(p.Name)}={Uri.EscapeDataString(p.GetValue(queryParams)!.ToString()!)}");

            var query = string.Join("&", props);
            return string.IsNullOrWhiteSpace(query) ? baseUrl : $"{baseUrl}?{query}";
        }


    }
}

