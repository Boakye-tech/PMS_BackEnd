// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

