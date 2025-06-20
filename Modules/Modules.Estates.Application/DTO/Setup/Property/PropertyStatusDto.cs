// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PropertyStatusDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/05/2025 8:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record PropertyStatusReadDto(int PropertyStatusId, string PropertyStatusName);
    public record PropertyStatusCreateDto(string PropertyStatusName, string CreatedBy);
    public record PropertyStatusUpdateDto(int PropertyStatusId, string PropertyStatusName, string ModifiedBy);
    public record PropertyStatusDeleteDto(int PropertyStatusId, string DeletedBy);
}

