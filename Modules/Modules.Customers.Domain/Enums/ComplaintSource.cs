using System;
using System.ComponentModel;

namespace Modules.Customers.Domain.Enums
{
	public enum ComplaintSource
	{
        [Description("CUSTOMER")]
        CUSTOMER = 1,

        [Description("STAFF")]
        STAFF = 2,
    }
}

