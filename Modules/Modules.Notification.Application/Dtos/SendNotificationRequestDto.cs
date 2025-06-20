// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/SendNotificationRequestDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/04/2025 6:08 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.Dtos
{

    public record SendNotificationRequest(string RecipientContact, string DisplayName, string Subject ,string Message, NotificationType Type, string UserId);

    public record SendNotificationRequestDto(string RecipientContact, string DisplayName, string Subject, string Message, NotificationType Type, string UserId); 

}

