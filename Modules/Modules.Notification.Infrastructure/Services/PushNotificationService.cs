using System;
using Azure.Core;
using FirebaseAdmin.Messaging;
using Modules.Notification.Application.Dtos;
using Modules.Notification.Application.Interfaces;

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
            //throw new NotImplementedException();

            var message = new Message()
            {
                Notification = new FirebaseAdmin.Messaging.Notification
                {
                    Title = pushRequest.Title,
                    Body = pushRequest.Body,
                },

                //Data = new Dictionary<string, string>()
                //{
                //    ["FirstName"] = "John",
                //    ["LastName"] = "Doe"
                //},

                Token = pushRequest.DeviceToken
            };

            var messaging = FirebaseMessaging.DefaultInstance;
            var result = await messaging.SendAsync(message);

            return result;
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

