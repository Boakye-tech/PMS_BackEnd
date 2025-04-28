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
    public enum ResidentTypeEnum
    {
        EXPATRIATE = 1,

        [Description("NON-RESIDENT")]
        NON_RESIDENT = 2,

        RESIDENT = 3
    }
}

