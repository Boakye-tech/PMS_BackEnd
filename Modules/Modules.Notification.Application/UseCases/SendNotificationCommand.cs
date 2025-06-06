// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendNotificationCommand.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 2:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Application.UseCases
{
    public class SendNotificationCommand : IRequest<string>
    {
        public SendNotificationRequest Request { get; }

        public SendNotificationCommand(SendNotificationRequest request) => Request = request;
    }

}

