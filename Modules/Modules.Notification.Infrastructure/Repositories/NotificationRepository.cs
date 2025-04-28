// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

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
            //throw new NotImplementedException();

            _dbContext.Notifications.Add(notification_msg);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Notifications>> GetPendingNotificationsAsync()
        {
            //throw new NotImplementedException();
            return await _dbContext.Notifications.Where(n => n.Status == NotificationStatus.Pending).ToListAsync();
        }

        public async Task UpdateStatusAsync(Guid notificationId, NotificationStatus status)
        {
            //throw new NotImplementedException();
            var notification_msg = await _dbContext.Notifications.FindAsync(notificationId);
            if (notification_msg != null)
            {
                notification_msg.Status = status;
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}

