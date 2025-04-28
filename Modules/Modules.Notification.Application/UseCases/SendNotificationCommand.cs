// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.UseCases
{
    public class SendNotificationCommand : IRequest<Guid>
    {
        public SendNotificationRequest Request { get; }

        public SendNotificationCommand(SendNotificationRequest request) => Request = request;
    }

}

