// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IPropertyTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/07/2025 6:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property
{
	public interface IPropertyTypeService
	{
        Task<List<PropertyTypeReadDto>> GetPropertyTypesAsync();
        Task<ReturnResponsesDto> CreatePropertyTypeAsync(PropertyTypeCreateDto values);
        Task<ReturnResponsesDto> UpdatePropertyTypeAsync(PropertyTypeUpdateDto values);
        Task<ReturnResponsesDto> DeletePropertyType(int propertyTypeId);

    }
}

