using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public record SendSmsRequestDto
	{
        public string? message_content { get; set; }
        public string? mobileNumber { get; set; }
    }
}

