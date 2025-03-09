using System;
using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ResidentTypeEnum
	{
        EXPATRIATE = 1,

        [Description("NON-RESIDENT")]
        NON_RESIDENT = 2,

        RESIDENT = 3
    }
}

