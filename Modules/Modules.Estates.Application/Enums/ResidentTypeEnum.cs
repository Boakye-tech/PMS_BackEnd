using System;
using System.ComponentModel;

namespace Modules.Estates.Application.Enums
{
	public enum ResidentTypeEnum
	{
        EXPATRIATE = 1,

        [Description("NON-RESIDENT")]
        NON_RESIDENT = 2,

        RESIDENT = 3
    }
}

