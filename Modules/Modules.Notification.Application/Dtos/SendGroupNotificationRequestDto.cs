// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/SendGroupNotificationRequestDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/04/2025 6:08 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Notification.Application.Dtos
{
    public record SendGroupNotificationRequestDto(
        string GroupName,
        string Subject,
        string Message,
        List<GroupRecipient> Recipients
    );

    public record GroupRecipient(
        string UserId,
        string RecipientContact
    );
}