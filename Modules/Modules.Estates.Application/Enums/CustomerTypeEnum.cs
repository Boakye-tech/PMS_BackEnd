using System;
using System.ComponentModel;

namespace Modules.Estates.Application.Enums
{
	public enum CustomerTypeEnum
	{
        COMPANY = 1,

        INDIVIDUAL = 2,

        [Description("NON-RESIDENT")]
        JOINT_OWNERSHIP = 3,

        [Description("NON-RESIDENT")]
        MULTI_OWNERSHIP = 4,

        PROSPECTIVE = 5
    }
}

