// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ModuleServices/IDispatchService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/05/2025 3:16 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Interfaces.ModuleServices
{
	public interface IDispatchService
	{
        Task<bool> SendDataAsync<T>(string endpoint, T payload, string httpMethod);

        Task<TResponse?> SendGetAsync<TResponse>(string endpoint);
        Task<TResponse?> SendGetWithQueryAsync<TResponse>(string endpoint, string queryParams);
    }
}

