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
	public enum ComplaintSourceEnum
	{
        [Description("CUSTOMER")]
        CUSTOMER = 1,

        [Description("STAFF")]
        STAFF = 2,
    }
}

