﻿using System;
using System.ComponentModel;
using Modules.Users.Application.Dtos.Entities.Menu;

namespace Modules.Users.Application.Enums
{
	public enum ClaimsMenuActions
	{
        [Description("No Access")]
        NoAccess = 1,

        [Description("Create")]
        Create = 2,

        [Description("Read")]
        Read = 3,

        [Description("Update")]
        Update = 4,

        [Description("Delete")]
        Delete = 5,

        [Description("Approve")]
        Approve = 6,

        [Description("Access")]
        Access = 7, 

    }


    public static class ClaimsMenuActionsEnumDescription
    {
        public static ClaimsMenuActions CheckClaimsMenuActions(int input)
        {
            if (Enum.IsDefined(typeof(ClaimsMenuActions), input))
            {
                return (ClaimsMenuActions)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for menu actions.");
            }
        }

        public static List<MenuActionsDto> ToMenuActionsDtoList()
        {
            return Enum.GetValues(typeof(ClaimsMenuActions))
                .Cast<ClaimsMenuActions>()
                .Select(action =>
                {
                    var description = action.GetEnumDescription();
                    return new MenuActionsDto((int)action, action.ToString(), description);
                })
                .ToList();
        }

        private static string GetEnumDescription(this Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var descriptionAttribute = fieldInfo?.GetCustomAttributes(typeof(DescriptionAttribute), false)
                                                 .FirstOrDefault() as DescriptionAttribute;

            return descriptionAttribute?.Description ?? enumValue.ToString();
        }



    }
}

