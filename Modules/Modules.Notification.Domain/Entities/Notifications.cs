// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Entities/Notifications.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Domain.Entities
{
    public class Notifications
    {
        public Guid Id { get; private set; }

        [Required]
        [StringLength(200)]
        public string? RecipientContact { get; private set; }  // Can be email, phone number, or Firebase ID

        [Required]
        [StringLength(100)]
        public string? Subject { get;  set; }

        [Required]
        public string? Message { get; private set; }

        public NotificationType Type { get; private set; }
        public NotificationStatus Status { get; set; }

        [Required]
        [StringLength(36)]
        public string? UserId { get; private set; }  // System user ID of the recipient

        public DateTime CreatedAt { get; private set; }
        public bool IsRead { get; set; }
        public DateTime? ReadAt { get; set; }
        public bool IsArchive { get; set; }


        private Notifications() { }

        public Notifications(string recipientContact, string subject, string message, NotificationType type, string userId)
        {
            Id = Guid.NewGuid();
            RecipientContact = recipientContact;
            Subject = subject;
            Message = message;
            Type = type;
            UserId = userId;
            Status = NotificationStatus.Pending;
            CreatedAt = DateTime.UtcNow;
            IsRead = false;
            IsArchive = false;
        }

        public void MarkAsSent() => Status = NotificationStatus.Sent;
    }

}

