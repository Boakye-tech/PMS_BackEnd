// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/DTO/NotificationsReadDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/05/2025 4:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Notification.Domain.DTO
{
    public record NotificationsReadDto(Guid notificationId, string subject, string message, DateTime createdAt, bool isRead);

    public record UserNotificationsReadDto(int TotalRecords, int PageNumber, int PageSize, List<NotificationsReadDto> NotificationDetails);
}

