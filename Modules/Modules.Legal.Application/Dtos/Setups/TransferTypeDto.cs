// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Dtos/Setups/TransferTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Application.Dtos.Setups
{
    public record TransferTypeRedDto(int transferTypeId, string transferType);
    public record TransferTypeCreateDto(string transferType, string createdBy);
    public record TransferTypeUpdateDto(int transferTypeId, string transferType, string modifiedBy);
    public record TransferTypeDeleteDto(int transferTypeId);

}


