// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/ISignalRNotificationService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/05/2025 2:47 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Notification.Domain.Interfaces
{
    public interface ISignalRNotificationService
    {
        Task SendNotificationAsync(Notifications notification);
        Task SendNotificationToGroupAsync(string groupName, Notifications notification);
        Task SendNotificationToUserAsync(string userId, Notifications notification);
    }
}

