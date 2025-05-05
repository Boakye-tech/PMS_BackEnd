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

public interface IApartmentTypeService
{
    Task<ApartmentTypeReadDto> AddApartmentTypeAsync(ApartmentTypeCreateDto values);
    Task<ApartmentTypeReadDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values);
    Task<IEnumerable<ApartmentTypeReadDto>> GetApartmentTypeAsync();
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(int value);
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(string value);
}

