// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/LeaseTypeAndPeriodDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/05/2025 5:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record LeaseTypeAndPeriodReadDto(int LeaseTypePeriodId, string LeaseType, int LeasePeriod);
    public record LeaseTypeAndPeriodCreateDto(string LeaseType, int LeasePeriod, string CreatedBy);
    public record LeaseTypeAndPeriodUpdateDto(int LeaseTypePeriodId, string LeaseType, int LeasePeriod, string ModifiedBy);
    public record LeaseTypeAndPeriodDeleteDto(int LeaseTypePeriodId, string DeletedBy);

}

