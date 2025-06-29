// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Enums/EntryTypeEnum.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:01 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel;

namespace Modules.Customers.Domain.Enums
{
    public enum EntryTypeEnum
    {
        [Description("DEBIT")]
        DR = 1,

        [Description("CREDIT")]
        CR = 2,

    }
}

