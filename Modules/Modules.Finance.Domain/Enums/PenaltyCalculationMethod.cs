// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Enums/PenaltyCalculationMethod.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 2:20 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Domain.Enums
{
	public enum PenaltyCalculationMethod
	{
        Percentage = 1,
        FlatRate = 2,
        DailyRate = 3,
        MonthlyRate = 4,
        YearlyRate = 5
    }
}

