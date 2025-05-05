// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ComplaintStatusEnum
	{
        [Description("SUBMITTED")]
        SUBMITTED = 1,

        [Description("ACKNOWLEDGED")]
        ACKNOWLEDGED = 2,

        [Description("DISPATCHED")]
        DISPATCHED = 3,

        [Description("REVIEWED")]
        REVIEWED = 4,

        [Description("ASSIGNED")]
        ASSIGNED = 5,

        [Description("IN PROGRESS")]
        INPROGRESS = 6,

        [Description("RESOLVED")]
        RESOLVED = 7,

        [Description("REOPEN")]
        REOPEN = 8,

        [Description("CLOSED")]
        CLOSED = 9,

        [Description("CANCELLED")]
        CANCELLED = 10
    }

    public static class ComplaintStatusEnumDescription
    {
        public static ComplaintStatusEnum ComplaintStatus(int input)
        {
            if (Enum.IsDefined(typeof(ComplaintStatusEnum), input))
            {
                return (ComplaintStatusEnum)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for complaint status enum.");
            }
        }

        public static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                                 .FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute?.Description ?? enumValue.ToString();
        }
    }

}

