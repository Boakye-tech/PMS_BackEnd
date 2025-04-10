using System;
using System.ComponentModel;

namespace Modules.Estates.Application.Enums
{
	public enum CustomerTypeEnum
	{
        [Description("COMPANY")]
        COMPANY = 1,

        [Description("INDIVIDUAL")]
        INDIVIDUAL = 2,

        [Description("JOINT-OWNERSHIP")]
        JOINT_OWNERSHIP = 3,

        [Description("MULTI-OWNERSHIP")]
        MULTI_OWNERSHIP = 4,

        [Description("PROSPECTIVE")]
        PROSPECTIVE = 5
    }
}

