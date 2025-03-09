﻿using System;
using System.ComponentModel;

namespace Modules.Users.Application.Enums
{
	public enum RegistrationStatus
    {
		Pending = 0,
        Verified = 1,
        Approved = 2,
        Activated = 3,
        Rejected = 4,
        Disapproved = 5,
        Deactivated = 6,
    }


    public static class RegistrationStatusEnumDescription
    {
        public static RegistrationStatus RegistrationStatusEnum(int input)
        {
            if (Enum.IsDefined(typeof(RegistrationStatus), input))
            {
                return (RegistrationStatus)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for menu actions.");
            }
        }

        //public static List<MenuActionsDto> ToMenuActionsDtoList()
        //{
        //    return Enum.GetValues(typeof(UserAccountType))
        //        .Cast<UserAccountType>()
        //        .Select(action =>
        //        {
        //            var description = action.GetEnumDescription();
        //            return new MenuActionsDto((int)action, action.ToString(), description);
        //        })
        //        .ToList();
        //}

        //public static string GetEnumDescription(this Enum enumValue)
        //{
        //    var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
        //    var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)
        //                                         .FirstOrDefault() as DescriptionAttribute;

        //    return descriptionAttribute?.Description ?? enumValue.ToString();
        //}
    }


}

