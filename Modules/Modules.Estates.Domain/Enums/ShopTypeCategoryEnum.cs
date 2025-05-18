// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Enums/ShopTypeCategoryEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 3:07 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel;

namespace Modules.Estates.Domain.Enums
{
	public enum ShopTypeCategoryEnum
	{
        [Description("SERVICED")]
        SERVICED = 1,

        [Description("NON-SERVICED")]
        NONSERVICED = 2,
    }
}

