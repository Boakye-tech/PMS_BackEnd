using System;
using System.ComponentModel;

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
                throw new ArgumentException("Invalid input for payment methods.");
            }
        }





    }
}

