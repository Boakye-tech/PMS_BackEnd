using System;
using System.ComponentModel;

namespace Modules.Estates.Application.Enums
{
	public enum DebtorStatusEnum
    {
        [Description("APPROVED")]
        APPROVED = 0,

        [Description("PENDING")]
        PENDING = 1,

        [Description("STOP DEBIT")]
        STOP_DEBIT = 90,
    }
}

