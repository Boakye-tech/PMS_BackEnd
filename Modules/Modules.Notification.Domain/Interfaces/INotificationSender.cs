// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/INotificationSender.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Notification.Domain.Interfaces
{
	public interface INotificationSender
	{
        Task<string> SendSMSAsync(Notifications values);
        Task<string> SendEmailAsync(Notifications values);
        Task<string> PushAsync(Notifications values);
        Task<string> InAppAsync(Notifications values);
    }
}

