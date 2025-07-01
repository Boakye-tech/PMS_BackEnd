// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Interfaces/Setup/ICategoryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 9:52 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Facilities.Application.Interfaces.Setup
{
	public interface ICategoryService
	{
        Task<ReturnResponsesDto> CreateCategoryAsync(CategoryCreateDto values);
        Task<ReturnResponsesDto> UpdateCategoryAsync(CategoryUpdateDto values);
        Task<IEnumerable<CategoryReadDto>> GetCategoryAsync();
        Task<ReturnResponsesDto> DeleteCategoryAsync(int categoryId);

    }
}

