using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public record MNotifySmsResponseSummaryDto
	{
        public string? _id { get; set; }
        public string? type { get; set; }
        public int total_sent { get; set; }
        public int contacts { get; set; }
        public int total_rejected { get; set; }
        public string[]? numbers_sent { get; set; }
        public int credit_used { get; set; }
        public int credit_left { get; set; }
    }
}

