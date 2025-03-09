using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public record BecsmsResponseDataDto
	{
        public string? key { get; set; }
        public string? to { get; set; }
        public string? msg { get; set; }
        public string? sender_id { get; set; }
        public string? campaign_id { get; set; }

    }
}

