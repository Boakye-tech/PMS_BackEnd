using System;
using System.ComponentModel;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Enums
{
	public enum UserAccountType
	{
		Customer = 1,
		Partners = 2,
		Staff = 3
	}

    public static class UserAccountTypeEnumDescription
    {
        public static UserAccountType UserType(int input)
        {
            if (Enum.IsDefined(typeof(UserAccountType), input))
            {
                return (UserAccountType)input;
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

