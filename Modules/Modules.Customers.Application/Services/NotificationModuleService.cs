// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/Services/NotificationModuleService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/05/2025 3:06 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Services
{
	public class NotificationModuleService : INotificationModuleService
    {
        private readonly IDispatchService _dispatchService;

        public NotificationModuleService(IDispatchService dispatchService)
        {
            _dispatchService = dispatchService;
        }

        public async Task<List<ComplaintStaffDto>?> GetComplaintStaffAsync(string query)
        {
            //throw new NotImplementedException();

            var result = await _dispatchService.SendGetWithQueryAsync<List<ComplaintStaffDto>?>("Administration/StaffNotification","?roleFilter=" + query);
            return result;
        }

        public async Task<bool> SendNotificationDetailsAsync(SendNotificationRequestDto payload)
        {
            return await _dispatchService.SendDataAsync("Notification/SendNotification", payload, "POST");

        }
    }
}

