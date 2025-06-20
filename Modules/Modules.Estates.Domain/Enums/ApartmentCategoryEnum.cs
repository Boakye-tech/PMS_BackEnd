// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/ApartmentCategoryEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 3:01 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ApartmentCategoryEnum
	{
        [Description("AFFORDABLE")]
        AFFORDABLE = 1,

        [Description("LUXURY")]
        LUXURY = 2,

        [Description("MID-RANGE")]
        MIDRANGE = 3,
    }

    public static class ApartmentCategoryEnumDescription
    {
        public static string GetApartmentCategoryEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                                 .FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute?.Description ?? enumValue.ToString();
        }
    }
}

