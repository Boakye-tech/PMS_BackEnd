// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/DebtorGroupsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 4:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Application.Dtos.Setup
{
	public record DebtorGroupsReadDto(int DebtorTypesId, int DebtorGroupsId, string GroupName, string? Description);
    public record DebtorGroupsCreateDto(int DebtorTypesId, string GroupName, string? Description, string CreatedBy);
    public record DebtorGroupsUpdateDto(int DebtorTypesId, int DebtorGroupsId, string GroupName, string? Description, string ModifiedBy);
    public record DebtorGroupsDeleteDto(int DebtorGroupsId);






}

