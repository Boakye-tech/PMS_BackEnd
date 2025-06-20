// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Application/Dtos/NotificationPreferencesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 4:22 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Notification.Application.Dtos
{
    public record NotificationPreferencesReadDto
    {
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

    }

    public record NotificationPreferencesCreateDto
    {
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
    }



    public record NotificationPreferencesUpdateDto
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
        public string? UpdatedBy { get; set; }
    }
}

