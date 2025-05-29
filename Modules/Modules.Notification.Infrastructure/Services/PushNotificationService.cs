// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Services/PushNotificationService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 02/04/2025 7:05 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using FirebaseAdmin.Messaging;

namespace Modules.Notification.Infrastructure.Services
{
	public class PushNotificationService : IPushSender
	{
		public PushNotificationService()
		{
		}

        public Task<string> PushAsync(Notifications notification)
        {
            throw new NotImplementedException();
        }

        public async Task<string> PushMessageAsync(PushNotificationDto pushRequest)
        {
            try
            {
                var message = new Message()
                {
                    Notification = new FirebaseAdmin.Messaging.Notification
                    {
                        Title = pushRequest.Title,
                        Body = pushRequest.Body,
                    },

                    Token = pushRequest.DeviceToken
                };

                var messaging = FirebaseMessaging.DefaultInstance;
                var result = await messaging.SendAsync(message);

                return result;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Task<string> Send(Notifications notification)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SendAsync(Notifications notification)
        {
            throw new NotImplementedException();
        }
    }
}

