// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/ActivityType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class ActivityType : AuditableEntity
    {
        [Required]
        public int ActivityId { get; private set; }

        [Key]
        [Required]
        public int ActivityTypeId { get; private set; }

        [Required]
        [StringLength(50)]
        public string ActivityTypeName { get; private set; }

        [StringLength(250)]
        public string? ActivityTypeDescription { get; private set; }

        // Navigation property for Activity
        public virtual Activity? Activity { get; private set; }


        public ActivityType(int activityId, int activityTypeId, string activityTypeName, string? activityTypeDescription)
        {
            ActivityId = activityId;
            ActivityTypeId = activityTypeId;
            ActivityTypeName = activityTypeName;
            ActivityTypeDescription = activityTypeDescription;
        }

        public static ActivityType Create(int activityId, int activityTypeId, string activityTypeName, string? activityTypeDescription)
        {
            Validate(activityId, activityTypeId, activityTypeName, activityTypeDescription);
            return new ActivityType(activityId, activityTypeId, activityTypeName, activityTypeDescription);
        }

        public void Update(int activityId, int activityTypeId, string activityTypeName, string? activityTypeDescription)
        {
            Validate(activityId, activityTypeId, activityTypeName, activityTypeDescription);

            ActivityId = activityId;
            ActivityTypeId = activityTypeId;
            ActivityTypeName = activityTypeName;
            ActivityTypeDescription = activityTypeDescription;
        }

        private static void Validate(int activityId, int activityTypeId, string activityTypeName, string? activityTypeDescription)
        {
            if (activityId <= 0)
                throw new ArgumentException("Activity Id must be greater than zero.");

            if (activityTypeId < 0)
                throw new ArgumentException("Activity Type Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(activityTypeName) || activityTypeName.Length > 50)
                throw new ArgumentException("Activity Type Name cannot be empty or exceed 50 characters.");

            if (activityTypeDescription != null && activityTypeDescription.Length > 250)
                throw new ArgumentException("Activity Type Description cannot exceed 250 characters.");
        }
    }
}

