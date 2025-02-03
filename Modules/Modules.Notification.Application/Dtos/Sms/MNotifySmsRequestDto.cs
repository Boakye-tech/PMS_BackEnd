using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public record MNotifySmsRequestDto
	{
        public string? key { get; set; }
        public string[]? recipient { get; set; }
        public string? sender { get; set; }
        public string? message { get; set; }
        public bool is_schedule { get; set; }
        public string? schedule_date { get; set; }

    }
}

