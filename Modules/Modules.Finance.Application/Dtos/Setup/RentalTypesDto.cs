// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/RentalTypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:23 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Finance.Application.Dtos.Setup
{
	public record RentalTypesReadDto(int RentalTypesId, string RentalType);
    public record RentalTypesCreateDto(int RentalTypesId, string RentalType, string CreatedBy);
    public record RentalTypesUpdateDto(int RentalTypesId, string RentalType, string ModifiedBy);
    public record RentalTypesDeleteDto(int RentalTypesId);




    public record RentalAndDebtorTypesDto(RentalTypesReadDto RentalTypes, List<DebtorTypeReadDto> DebtorTypes);
    public record DebtorTypeReadDto(int DebtorType, string Description, List<DebtorGroupReadDto> GroupNumbers);
    public record DebtorGroupReadDto(string GroupName, string? Description);
}

