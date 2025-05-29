// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Entities/NotificationPreferences.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 12:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Domain.Entities
{
    public class NotificationPreferences
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(36)]
        public string? UserId { get; set; }

        [Required]
        public bool EnableEmail { get; set; }

        [Required]
        public bool EnableSms { get; set; }

        [Required]
        public bool EnablePush { get; set; }

        [Required]
        public bool EnableInApp { get; set; }

        [StringLength(36)]
        public string? CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(36)]
        public string? UpdatedBy { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}

