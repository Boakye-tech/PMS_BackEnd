// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/UseCases/SendEmailNotificationCommand.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 06/06/2025 3:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Notification.Application.UseCases
{
	public class SendEmailNotificationCommand : IRequest<string>
	{
		public SendNotificationRequestDto Request { get; }

		public SendEmailNotificationCommand(SendNotificationRequestDto request) => Request = request;
    }
}

