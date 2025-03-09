using System;
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
        public string? ActivityTypeName { get; private set; }

        [StringLength(50)]
        public string? ActivityTypeDescription { get; private set; }

        public ActivityType()
		{
		}

        public ActivityType(int activityId, int activityTypeId, string activityTypeName, string activityTypeDescription)
        {
            ActivityId = activityId;
            ActivityTypeId = activityTypeId;
            ActivityTypeName = activityTypeName;
            ActivityTypeDescription = activityTypeDescription;
        }

        public static ActivityType  Create(int activityId, int activityTypeId, string activityTypeName, string activityTypeDescription)
        {
            if (string.IsNullOrWhiteSpace(activityTypeName) || activityTypeId < 0 || activityId < 0)
            {
                throw new ArgumentException("Invalid Activity Type Data.");
            }

            if (activityId < 0)
                throw new ArgumentException("Activity Id must be greater than zero.");

            if (activityTypeId < 0)
                throw new ArgumentException("Activity Type Id must be greater than zero.");


            if (string.IsNullOrWhiteSpace(activityTypeName) || activityTypeName.Length > 50)
                throw new ArgumentException("Activity Type Name must not be null or exceed 50 characters.");

            return new ActivityType(activityId, activityTypeId, activityTypeName, activityTypeDescription);
        }

	}





}

