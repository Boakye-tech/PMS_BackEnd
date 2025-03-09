using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public record BecsmsResponseDto
	{
        public bool success { get; set; }
        public int code { get; set; }
        public BecsmsResponseDataDto? data { get; set; }
        public string? message { get; set; }

    }
}

