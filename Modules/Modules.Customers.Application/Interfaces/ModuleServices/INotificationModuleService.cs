// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Interfaces/ModuleServices/INotificationModuleService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 11:08 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Customers.Application.Interfaces.ModuleServices
{
	public interface INotificationModuleService
	{
        Task<bool> SendNotificationDetailsAsync(SendNotificationRequestDto payload);

        //Task<TResponse?> SendGetAsync<TResponse>(string endpoint);
        //Task<List<ComplaintStaffDto>?> GetComplaintStaffAsync<TResponse, TQuery>(TQuery query);

        Task<List<ComplaintStaffDto>?> GetComplaintStaffAsync(string query);

    }


}

