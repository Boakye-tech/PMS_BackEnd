// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/NotificationsReadDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 2:51 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Notification.Application.Dtos
{
    public record NotificationsReadDto(Guid notificationId, string subject, string message, DateTime createdAt, bool isRead);

    public record UserNotificationsReadDto(int TotalRecords, int PageNumber, int PageSize, List<NotificationsReadDto> NotificationDetails);
}

