using System;
namespace Modules.Notification.Application.Dtos.Sms
{
	public class MNotifySmsResponseDto
	{
        public string? status { get; set; }
        public string? code { get; set; }
        public string? message { get; set; }
        public MNotifySmsResponseSummaryDto? summary { get; set; }
    }
}

