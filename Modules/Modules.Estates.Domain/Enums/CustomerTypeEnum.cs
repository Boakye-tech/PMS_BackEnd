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

namespace Modules.Estates.Domain.Enums
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

