// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Enums/EntryTypeEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/06/2025 1:49 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel;

namespace Modules.Finance.Domain.Enums
{
	public enum EntryTypeEnum
	{
        [Description("DEBIT")]
        DR = 1,

        [Description("CREDIT")]
        CR = 2,

    }
}

