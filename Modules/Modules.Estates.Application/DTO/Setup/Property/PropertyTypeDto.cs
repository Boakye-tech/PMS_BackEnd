// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/PropertyTypeDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 5:53 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.DTO.Setup.Property
{
	public record PropertyTypeReadDto(int PropertyTypeId, string? PropertyTypeInitial, string? PropertyTypeName);
    public record PropertyTypeCreateDto(string? PropertyTypeInitial, string? PropertyTypeName, string CreatedBy);
    public record PropertyTypeUpdateDto(int PropertyTypeId, string? PropertyTypeInitial, string? PropertyTypeName, string ModifiedBy);
    public record PropertyTypeDeleteDto(int PropertyTypeId);
}

