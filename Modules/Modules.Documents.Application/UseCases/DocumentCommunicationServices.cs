// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Application/UseCases/ModuleCommunicationServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 09/09/2025 11:18 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Net.Http.Headers;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Modules.Common.Infrastructure.Authentication;
using Modules.Documents.Application.Dtos.ModuleCommunication;

namespace Modules.Documents.Application.UseCases
{
	public class DocumentCommunicationServices : IDocumentCommunicationServices
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<DocumentCommunicationServices> _logger;
        private readonly IConfiguration _config;
        private readonly IUserContextService _userContextService;


        public DocumentCommunicationServices(HttpClient httpClient, ILogger<DocumentCommunicationServices> logger, IConfiguration config, IUserContextService userContextService)
        {
            _httpClient = httpClient;
            _logger = logger;
            _config = config;
            _userContextService = userContextService;
        }

        public async Task<List<BlockNumberReadDto>> GetBlockNumberList()
        {
            var result = await SendGetAsync<List<BlockNumberReadDto>>("Property/GetBlockNumber");
            return result!;
        }

        public async Task<List<LocalityReadDto>> GetLocalityList()
        {
            var result = await SendGetAsync<List<LocalityReadDto>>("Property/GetLocalities");
            return result!;
        }

        public async Task<List<NationalityReadDto>> GetNationalityList()
        {
            var result = await SendGetAsync<List<NationalityReadDto>>("Customer/GetNationality");
            return result!;
        }

        public async Task<List<PlotDimensionReadDto>> GetPlotDimensionList()
        {
            var result = await SendGetAsync<List<PlotDimensionReadDto>>("Property/GetPlotDimensions");
            return result!;
        }

        public async Task<List<ProductAwarenessSourcesReadDto>> GetProductAwarenessSourceList()
        {
            var result = await SendGetAsync<List<ProductAwarenessSourcesReadDto>>("Customer/GetProductAwarenessSources");
            return result!;
        }

        public async Task<List<PropertyHeightReadDto>> GetPropertyHeightList()
        {
            var result = await SendGetAsync<List<PropertyHeightReadDto>>("Property/GetPropertyHeight");
            return result!;
        }

        public async Task<List<ResidentTypeReadDto>> GetResidentTypeList()
        {
            var result = await SendGetAsync<List<ResidentTypeReadDto>>("Customer/GetResidentTypes");
            return result!;
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


    }
}

