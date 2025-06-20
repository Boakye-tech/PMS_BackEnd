// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Activity.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class Activity : AuditableEntity
    {
        [Key]
        [Required]
        public int ActivityId { get; private set; }

        [Required]
        [StringLength(50)]
        public string ActivityName { get; private set; }

        [StringLength(50)]
        public string? ActivityDescription { get; private set; }

        // Navigation property for ActivityType
        public virtual ICollection<ActivityType> ActivityTypes { get; private set; }

        public Activity(int activityId, string activityName, string? activityDescription)
        {
            ActivityId = activityId;
            ActivityName = activityName;
            ActivityDescription = activityDescription;
            ActivityTypes = new List<ActivityType>();
        }

        public static Activity Create(int activityId, string activityName, string? activityDescription)
        {
            Validate(activityId, activityName, activityDescription);
            return new Activity(activityId, activityName, activityDescription);
        }

        public void Update(int activityId, string activityName, string? activityDescription)
        {
            Validate(activityId, activityName, activityDescription);

            ActivityId = activityId;
            ActivityName = activityName;
            ActivityDescription = activityDescription;
        }

        private static void Validate(int activityId, string activityName, string? activityDescription)
        {
            if (activityId < 0)
                throw new ArgumentException("Activity Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(activityName))
                throw new ArgumentException("Activity Name cannot be empty or exceed 50 characters.");

            if (activityDescription != null && activityDescription.Length > 50)
                throw new ArgumentException("Activity Description cannot exceed 50 characters.");
        }
    }
}

