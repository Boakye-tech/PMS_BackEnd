// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/CategoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 9:47 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
	public record CategoryReadDto(int categoryId, string categoryName);

    public record CategoryCreateDto(string categoryName, string createdBy);
    public record CategoryUpdateDto(int categoryId, string categoryName, string modifiedBy);
    public record CategoryDeleteDto(int categoryId);
}

