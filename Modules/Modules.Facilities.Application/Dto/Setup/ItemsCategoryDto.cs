// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/ItemsCategoryDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record ItemsCategoryReadDto(
        int itemCategoryId,
        string? itemCategoryName
    );

    public record ItemsCategoryCreateDto(
        string? itemCategoryName,
        string createdBy
    );

    public record ItemsCategoryUpdateDto(
        int itemCategoryId,
        string? itemCategoryName,
        string modifiedBy
    );

    public record ItemsCategoryDeleteDto(int itemCategoryId);


    public record ItemReadDto(string? ItemCode,string? ItemName);

    public record ItemCategoryAndItemsReadDto(ItemsCategoryReadDto itemCategory, List<ItemReadDto> items);

    //public record ItemCategoryAndItemsReadDto
    //{
    //    public ItemsCategoryReadDto? itemCategory { get; init; }
    //    public List<ItemReadDto>? items { get; init; }
    //}
}