// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/INotificationRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Notification.Domain.DTO;

namespace Modules.Notification.Domain.Interfaces
{
	public interface INotificationRepository
	{
        Task AddAsync(Notifications notification_msg);
        Task<IEnumerable<Notifications>> GetPendingNotificationsAsync();
        Task UpdateStatusAsync(Guid notificationId, NotificationStatus status);

        Task UpdateIsRead(Guid notificationId);
        Task UpdateIsArchive(Guid notificationId);

        UserNotificationsReadDto GetUserNotifications(string userId, int pageNumber, int pageSize, bool? isRead, bool? isArchive);


    }
}

