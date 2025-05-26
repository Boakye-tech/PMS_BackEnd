// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.EntityFrameworkCore;
using Modules.Notification.Domain.DTO;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Modules.Notification.Infrastructure.Repositories
{
	public class NotificationRepository : INotificationRepository
    {
		private readonly NotificationDbContext _dbContext;

		public NotificationRepository(NotificationDbContext dbContext)
		{
            _dbContext = dbContext;
		}

        public async Task AddAsync(Notifications notification_msg)
        {
            _dbContext.Notifications.Add(notification_msg);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Notifications>> GetPendingNotificationsAsync()
        {
            return await _dbContext.Notifications.Where(n => n.Status == NotificationStatus.Pending).ToListAsync();
        }

        public UserNotificationsReadDto GetUserNotifications(string userId, int pageNumber, int pageSize, bool? isRead, bool? isArchive)
        {
            var queryable = _dbContext.Notifications.Where(n => n.UserId == userId);

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
                TotalRecords : totalRecords,
                PageNumber : pageNumber,
                PageSize : pageSize,
                NotificationDetails: notifications
            );
        }

        public async Task UpdateIsArchive(Guid notificationId)
        {
            var notification_msg = await _dbContext.Notifications.FindAsync(notificationId);
            if (notification_msg != null)
            {
                notification_msg.IsArchive = true;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateIsRead(Guid notificationId)
        {
            var notification_msg = await _dbContext.Notifications.FindAsync(notificationId);
            if (notification_msg != null)
            {
                notification_msg.IsRead = true;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateStatusAsync(Guid notificationId, NotificationStatus status)
        {
            var notification_msg = await _dbContext.Notifications.FindAsync(notificationId);
            if (notification_msg != null)
            {
                notification_msg.Status = status;
                await _dbContext.SaveChangesAsync();
            }
        }


    }
}

