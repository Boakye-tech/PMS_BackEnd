// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Interfaces/INotificationRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/05/2025 8:49 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.Interfaces
{
    public interface INotificationRepository
    {
        Task AddAsync(Notifications notification_msg);
        Task<IEnumerable<Notifications>> GetPendingNotificationsAsync();
        Task UpdateStatusAsync(Guid notificationId, NotificationStatus status);

        Task UpdateIsRead(Guid notificationId);
        Task UpdateIsArchive(NotificationIdDto values);

        Task<UserNotificationsReadDto> GetUserNotifications(string userId, int pageNumber, int pageSize, bool? isRead, bool? isArchive);

        //27th May '25
        Task<NotificationPreferencesReadDto?> GetUserPreferencesAsync(string userid);
        Task CreatePreferencesAsync(NotificationPreferencesCreateDto notification_preferences);
        Task UpdatePreferencesAsync(NotificationPreferencesUpdateDto notification_preferences);
    }
}

