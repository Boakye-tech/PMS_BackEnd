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
	public record BecsmsResponseDataDto
	{
        public string? key { get; set; }
        public string? to { get; set; }
        public string? msg { get; set; }
        public string? sender_id { get; set; }
        public string? campaign_id { get; set; }

    }
}

