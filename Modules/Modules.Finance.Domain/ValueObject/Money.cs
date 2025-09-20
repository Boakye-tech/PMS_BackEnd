// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/ValueObject/Money.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 8:28 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.ValueObject
{
    public record Money(double Value)
    {
        public static Money Zero => new(0);
    };
}

