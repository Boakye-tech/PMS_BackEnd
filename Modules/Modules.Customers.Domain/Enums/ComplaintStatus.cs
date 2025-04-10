using System;
using System.ComponentModel;

namespace Modules.Customers.Domain.Enums
{
	public enum ComplaintStatus
	{
        [Description("SUBMITTED")]
        SUBMITTED = 1,

        [Description("REVIEWED")]
        REVIEWED = 2,

        [Description("ASSIGNED")]
        ASSIGNED = 3,

        [Description("RESOLVED")]
        RESOLVED = 4,

        [Description("CANCELLED")]
        CANCELLED = 5
    }
}

