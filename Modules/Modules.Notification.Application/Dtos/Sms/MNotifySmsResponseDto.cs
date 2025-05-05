// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

