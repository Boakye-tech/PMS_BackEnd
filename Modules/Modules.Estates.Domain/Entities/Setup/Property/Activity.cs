using System;
namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class Activity : AuditableEntity
	{
        [Key]
        [Required]
        public int ActivityId { get; private set; }

        [Required]
        [StringLength(50)]
        public string? ActivityName { get; private set; }

        [StringLength(50)]
        public string? ActivityDescription { get; private set; }

        public Activity()
		{
		}

        public Activity(int activityId, string activityName, string activityDescription)
        {
            ActivityId = activityId;
            ActivityName = activityName;
            ActivityDescription = activityDescription;
        }

        public static Activity Create(int activityId, string activityName, string activityDescription)
        {
            if (string.IsNullOrWhiteSpace(activityName) || activityId < 0)
            {
                throw new ArgumentException("Invalid Activity Data.");
            }

            if (activityId < 0)
                throw new ArgumentException("Activity Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(activityName) || activityName.Length > 50)
                throw new ArgumentException("Activity Name must not be null or exceed 50 characters.");

            return new Activity(activityId, activityName, activityDescription);
        }



    }
}

