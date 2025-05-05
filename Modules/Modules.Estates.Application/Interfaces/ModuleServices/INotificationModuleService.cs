// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ModuleServices/INotificationModuleService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 05/05/2025 2:24 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.Events.Complaints;

namespace Modules.Estates.Application.Interfaces.ModuleServices
{
	public interface INotificationModuleService
	{
        Task<bool> SendEmailNotificationAsync(ComplaintStatusChangedEvent payload);
        Task<bool> SendPushNotificationAsync(ComplaintStatusChangedEvent payload);
        Task<bool> SendSmsNotificationAsync(ComplaintStatusChangedEvent payload);

    }
}

