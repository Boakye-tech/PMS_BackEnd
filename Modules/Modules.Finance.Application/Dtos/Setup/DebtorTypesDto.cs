// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/DebtorTypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:29 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Application.Dtos.Setup
{
	public record DebtorTypesReadDto(int RentalTypesId, int DebtorTypesId, int DebtorType, string Description);
    public record DebtorTypesCreateDto(int RentalTypesId, int DebtorType, string Description, string CreatedBy);
    public record DebtorTypesUpdateDto(int RentalTypesId, int DebtorTypesId, int DebtorType, string Description, string ModifiedBy);
    public record DebtorTypesDeleteDto(int DebtorTypesId);
}

