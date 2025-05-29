// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/Sms/MNotifySmsResponseSummaryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 6:08 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

