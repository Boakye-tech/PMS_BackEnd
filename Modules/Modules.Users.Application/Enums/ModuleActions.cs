using System;
using System.ComponentModel;

namespace Modules.Users.Application.Enums
{
	public enum ModuleActions
	{
        [Description("CREATE")]
        CREATE = 1,

        [Description("READ")]
        READ = 2,

        [Description("UPDATE")]
        UPDATE = 3,

        [Description("DELETE")]
        DELETE = 4,

        [Description("APPROVE")]
        APPROVE = 5,

        [Description("VERIFY")]
        VERIFY = 6,

        [Description("REJECT")]
        REJECT = 7,

        [Description("DISAPPROVE")]
        DISAPPROVE = 8,

        [Description("ACTIVATE")]
        ACTIVATE = 9,

        [Description("DEACTIVATE")]
        DEACTIVATE = 10,
    }

    public static class ClaimsModuleActionsEnumDescription
    {
        public static ModuleActions CheckClaimsModuleActions(int input)
        {
            if (Enum.IsDefined(typeof(ModuleActions), input))
            {
                return (ModuleActions)input;
            }
            else
            {
                throw new ArgumentException("Invalid input for module actions.");
            }
        }

        public static List<ModuleActionsDto> ToModuleActionsDtoList()
        {
            return Enum.GetValues(typeof(ModuleActions))
                .Cast<ModuleActions>()
                .Select(action =>
                {
                    var description = action.GetEnumDescription();
                    return new ModuleActionsDto((int)action, action.ToString());
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

