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
	public record MNotifySmsRequestDto
	{
        //public string? key { get; set; }
        public string[]? recipient { get; set; }
        public string? sender { get; set; }
        public string? message { get; set; }
        public bool is_schedule { get; set; }
        public string? schedule_date { get; set; }

    }
}

