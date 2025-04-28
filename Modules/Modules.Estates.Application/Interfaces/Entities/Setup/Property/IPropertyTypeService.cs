// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IPropertyTypeService
{
    Task<PropertyTypeReadDto> AddPropertyTypeAsync(PropertyTypeCreateDto values);
    Task<PropertyTypeReadDto> UpdatePropertyTypeAsync(PropertyTypeUpdateDto values);
    Task<IEnumerable<PropertyTypeReadDto>> GetPropertyTypeAsync();
    Task<PropertyTypeReadDto> GetPropertyTypeAsync(int value);
    Task<PropertyTypeReadDto> GetPropertyTypeAsync(string value);
}

