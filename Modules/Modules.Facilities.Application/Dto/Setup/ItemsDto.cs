// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/ItemsDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record ItemsReadDto(
        int itemCategoryId,
        string? itemCategoryName,
        string? itemCode,
        string? itemName
    );

    public record ItemsCreateDto(
        int itemCategoryId,
        string? itemCode,
        string? itemName,
        string createdBy
    );

    public record ItemsUpdateDto(
        int itemCategoryId,
        string? itemCode,
        string? itemName,
        string modifiedBy
    );

    public record ItemsDeleteDto(string itemCode);
}