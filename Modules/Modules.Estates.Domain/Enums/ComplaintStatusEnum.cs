using System;
using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ComplaintStatusEnum
	{
        [Description("SUBMITTED")]
        SUBMITTED = 1,

        [Description("REVIEWED")]
        REVIEWED = 2,

        [Description("ASSIGNED")]
        ASSIGNED = 3,

        [Description("PENDING")]
        PENDING = 4,

        [Description("RESOLVED")]
        RESOLVED = 5,

        [Description("CANCELLED")]
        CANCELLED = 6

    }
}

