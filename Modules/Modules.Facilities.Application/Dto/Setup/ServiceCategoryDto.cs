// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/ServiceCategoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record ServiceCategoryReadDto(
        int serviceCategoryId,
        int categoryId,
        string? categoryName,
        int serviceId,
        string? serviceName
    );

    public record ServiceCategoryCreateDto(
        int categoryId,
        int serviceId,
        string createdBy
    );

    public record ServiceCategoryUpdateDto(
        int serviceCategoryId,
        int categoryId,
        int serviceId,
        string modifiedBy
    );

    public record ServiceCategoryDeleteDto(int serviceCategoryId);
}