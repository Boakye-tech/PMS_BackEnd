// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Hubs/NotificationHub.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/05/2025 2:54 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;


namespace Modules.Notification.Presentation.Hubs
{
    public class NotificationHub : Hub
    {
        private readonly ILogger<NotificationHub> _logger;

        public NotificationHub(ILogger<NotificationHub> logger)
        {
            _logger = logger;
        }

        public override async Task OnConnectedAsync()
        {
            var userId = Context.User?.FindFirst("sub")?.Value;
            if (!string.IsNullOrEmpty(userId))
            {
                await Groups.AddToGroupAsync(Context.ConnectionId, userId);
                _logger.LogInformation($"User {userId} connected to notification hub");
            }
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var userId = Context.User?.FindFirst("sub")?.Value;
            if (!string.IsNullOrEmpty(userId))
            {
                await Groups.RemoveFromGroupAsync(Context.ConnectionId, userId);
                _logger.LogInformation($"User {userId} disconnected from notification hub");
            }
            await base.OnDisconnectedAsync(exception);
        }

        public async Task SendNotification(Notifications notification)
        {
            if (notification.Type == NotificationType.InApp)
            {
                await Clients.Group(notification.UserId!).SendAsync("ReceiveNotification", notification);
                _logger.LogInformation($"InApp notification sent to user {notification.UserId}");
            }
        }
    }
}

