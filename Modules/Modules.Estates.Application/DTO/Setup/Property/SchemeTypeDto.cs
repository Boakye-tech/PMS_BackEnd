// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/SchemeTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/06/2025 12:21 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.DTO.Setup.Property
{
    public record SchemeTypeReadDto(int SchemeTypeId, string SchemeTypeName);
    public record SchemeTypeCreateDto(string SchemeTypeName, string CreatedBy);
    public record SchemeTypeUpdateDto(int SchemeTypeId, string SchemeTypeName, string ModifiedBy);
    public record SchemeTypeDeleteDto(int SchemeTypeId);

}

