using System;
using System.ComponentModel;

namespace Modules.Estates.Application.Enums
{
	public enum ResidentTypeEnum
	{
        [Description("EXPATRIATE")]
        EXPATRIATE = 1,

        [Description("NON-RESIDENT")]
        NON_RESIDENT = 2,

        [Description("RESIDENT")]
        RESIDENT = 3
    }
}

