// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/NotificationRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 2:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.Extensions.Logging;
using Modules.Notification.Domain.Exceptions;

namespace Modules.Notification.Application.UseCases
{
    public class NotificationRepository : INotificationRepository
    {
        private readonly ILogger<NotificationRepository> _logger;
        private readonly IRepository<Notifications> _dbContext;
        private readonly IRepository<NotificationPreferences> _dbRepo;

        public NotificationRepository(ILogger<NotificationRepository> logger,IRepository<Notifications> dbContext, IRepository<NotificationPreferences> dbRepo)
        {
            _logger = logger;
            _dbContext = dbContext;
            _dbRepo = dbRepo;
        }

        public async Task AddAsync(Notifications notification_msg)
        {
            try
            {
                await _dbContext.Insert(notification_msg);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create new user notification.");
                throw new NotificationException("Failed to create new user notification.", ex);
            }
        }

        public async Task CreatePreferencesAsync(NotificationPreferencesCreateDto notification_preferences)
        {
            try
            {
                var notification_preferences_msg = new NotificationPreferences
                {
                    Id = 0,
                    UserId = notification_preferences.UserId,
                    EnableEmail = notification_preferences.EnableEmail,
                    EnableInApp = notification_preferences.EnableInApp,
                    EnablePush = notification_preferences.EnablePush,
                    EnableSms = notification_preferences.EnableSms,
                    CreatedBy = notification_preferences.CreatedBy,
                    CreatedAt = DateTime.UtcNow
                };
                await _dbRepo.Insert(notification_preferences_msg);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to create new user notification preferences.");
                throw new NotificationException("Failed to create new user notification preferences.", ex);
            }
        }

        public async Task<IEnumerable<Notifications>> GetPendingNotificationsAsync()
        {
            return await _dbContext.GetAll(n => n.Status == NotificationStatus.Pending);
        }

        public async Task<UserNotificationsReadDto> GetUserNotifications(string userId, int pageNumber, int pageSize, bool? isRead, bool? isArchive)
        {
            var queryable = (await _dbContext.GetAll(n => n.UserId == userId)).AsQueryable();

            if (isRead.HasValue)
                queryable = queryable.Where(n => n.IsRead == isRead.Value);

            if (isArchive.HasValue)
                queryable = queryable.Where(n => n.IsArchive == isArchive.Value);

            var totalRecords = queryable.Count();

            var notifications = queryable.OrderByDescending(n => n.CreatedAt)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .Select(n => new NotificationsReadDto
                (
                    n.Id,
                    n.Subject!,
                    n.Message!,
                    n.CreatedAt,
                    n.IsRead
                )).ToList();

            return new UserNotificationsReadDto
            (
                TotalRecords: totalRecords,
                PageNumber: pageNumber,
                PageSize: pageSize,
                NotificationDetails: notifications
            );
        }

        public async Task<NotificationPreferencesReadDto?> GetUserPreferencesAsync(string userid)
        {
            var response = await _dbRepo.Get(np => np.UserId == userid);
            if (response is null)
                return null!;


            return new NotificationPreferencesReadDto
            {
                Id = response!.Id,
                UserId = response.UserId,
                EnableEmail = response.EnableEmail,
                EnableSms = response.EnableSms,
                EnablePush = response.EnablePush,
                EnableInApp = response.EnableInApp,
            };
        }

        public async Task UpdateIsArchive(NotificationIdDto values)
        {
            try
            {
                var notification_msg = await _dbContext.Get(n => n.Id == values.notificationId);
                if (notification_msg != null)
                {
                    notification_msg.IsArchive = values.ArchiveStatus;
                    await _dbContext.Update(notification_msg);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to archive notifications.");
                throw new NotificationException("Failed to archive notifications.", ex);
            }
        }

        public async Task UpdateIsRead(Guid notificationId)
        {
            try
            {
                var notification_msg = await _dbContext.Get(n => n.Id == notificationId);
                if (notification_msg != null)
                {
                    notification_msg.IsRead = true;
                    await _dbContext.Update(notification_msg);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed change read status.");
                throw new NotificationException("Failed change read status.", ex);
            }
        }

        public async Task UpdatePreferencesAsync(NotificationPreferencesUpdateDto notification_preferences)
        {
            try
            {
                var notification_preferences_msg = new NotificationPreferences
                {
                    Id = notification_preferences.Id,
                    UserId = notification_preferences.UserId,
                    EnableEmail = notification_preferences.EnableEmail,
                    EnableInApp = notification_preferences.EnableInApp,
                    EnablePush = notification_preferences.EnablePush,
                    EnableSms = notification_preferences.EnableSms,
                    UpdatedBy = notification_preferences.UpdatedBy,
                    UpdatedAt = DateTime.UtcNow
                };
                await _dbRepo.Update(notification_preferences_msg);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed to update user notification preferences.");
                throw new NotificationException("Failed to update user notification preferences.", ex);
            }
        }

        public async Task UpdateStatusAsync(Guid notificationId, NotificationStatus status)
        {
            try
            {
                var notification_msg = await _dbContext.Get(n => n.Id == notificationId);
                if (notification_msg != null)
                {
                    notification_msg.Status = status;
                    await _dbContext.Update(notification_msg);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Failed notification status update.");
                throw new NotificationException("Failed notification status update.", ex);
            }
        }


    }
}

