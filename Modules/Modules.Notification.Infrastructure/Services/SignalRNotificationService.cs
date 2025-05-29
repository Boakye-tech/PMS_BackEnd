// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/SignalRNotificationService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/05/2025 3:05 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Infrastructure.Services
{

    public class SignalRNotificationService : ISignalRNotificationService
    {
        private readonly IHubContext<NotificationHub> _hubContext;
        private readonly ILogger<SignalRNotificationService> _logger;
        private readonly INotificationRepository _repository;

        public SignalRNotificationService(IHubContext<NotificationHub> hubContext, ILogger<SignalRNotificationService> logger, INotificationRepository repository)
        {
            _hubContext = hubContext;
            _logger = logger;
            _repository = repository;
        }

        public async Task SendNotificationAsync(Notifications notification)
        {
            try
            {
                if (notification.Type == NotificationType.InApp)
                {
                    if (notification.UserId == "broadcast")
                    {
                        // Send to all connected clients
                        await _hubContext.Clients.All.SendAsync("ReceiveBroadcastNotification", notification);
                        _logger.LogInformation($"Broadcast notification sent: {notification.Subject}");
                    }
                    else
                    {
                        // Send to specific user
                        await _hubContext.Clients.Group(notification.UserId!).SendAsync("ReceiveNotification", notification);
                        _logger.LogInformation($"Notification sent to user {notification.UserId}: {notification.Subject}");
                    }
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error sending notification via SignalR");
                throw;
            }
        }

        public async Task SendNotificationToGroupAsync(string groupName, Notifications notification)
        {
            try
            {
                if (notification.Type == NotificationType.InApp)
                {
                    await _hubContext.Clients.Group(groupName).SendAsync("ReceiveNotification", notification);
                    _logger.LogInformation($"Group notification sent to {groupName}: {notification.Subject}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error sending notification to group {groupName} via SignalR");
                throw;
            }
        }

        public async Task SendNotificationToUserAsync(string userId, Notifications notification)
        {
            try
            {
                var notification_msg = new Notifications(notification.RecipientContact!, notification.Subject!, notification.Message!, notification.Type, notification.UserId!);
                await _repository.AddAsync(notification_msg);

                if (notification.Type == NotificationType.InApp)
                {
                    await _hubContext.Clients.Group(userId).SendAsync("ReceiveNotification", notification);
                    _logger.LogInformation($"User notification sent to {userId}: {notification.Subject}");
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error sending notification to user {userId} via SignalR");
                throw;
            }
        }
    }
}