// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.Dtos
{

    public record SendNotificationRequest(string RecipientContact, string DisplayName, string Subject ,string Message, NotificationType Type, string UserId);

    public record SendNotificationRequestDto(string RecipientContact, string DisplayName, string Subject, string Message, NotificationType Type, string UserId); 

}

