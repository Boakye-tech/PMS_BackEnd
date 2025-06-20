// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/NotificationQueryParametersDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 26/05/2025 6:08 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Notification.Application.Dtos
{
    public record NotificationQueryParametersDto
    {
        [Required]
        public required string UserId { get; set; }

        public int PageNumber { get; set; } = 1;

        public int PageSize { get; set; } = 10;

        public bool? IsRead { get; set; }

        public bool? IsArchive { get; set; } = false;
    }

    public record NotificationIdDto
    {
        public Guid notificationId { get; set; }

        public bool ArchiveStatus { get; set; }
    }

}

