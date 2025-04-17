using System;
using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ComplaintSourceEnum
	{
        [Description("CUSTOMER")]
        CUSTOMER = 1,

        [Description("STAFF")]
        STAFF = 2,
    }
}

