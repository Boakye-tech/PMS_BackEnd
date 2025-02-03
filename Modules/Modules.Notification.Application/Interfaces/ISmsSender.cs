using System;
using Modules.Notification.Application.Dtos.Sms;

namespace Modules.Notification.Application.Interfaces
{
	public interface ISmsSender
	{
        string SendMessage(SendSmsRequestDto smsRequest);
        Task<string> SendMessageAsync(SendSmsRequestDto smsRequest);
    }
}

