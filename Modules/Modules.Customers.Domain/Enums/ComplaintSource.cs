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

namespace Modules.Customers.Domain.Enums
{
	public enum ComplaintSource
	{
        [Description("Customer")]
        CUSTOMER = 1,

        [Description("Staff")]
        STAFF = 2,
    }

    public static class ComplaintSourceDescription
    {
        public static ComplaintSource ComplaintSource(int input)
        {
            if (Enum.IsDefined(typeof(ComplaintSource), input))
            {
                return (ComplaintSource)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for complaint source enum.");
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

