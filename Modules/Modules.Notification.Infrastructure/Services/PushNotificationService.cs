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

