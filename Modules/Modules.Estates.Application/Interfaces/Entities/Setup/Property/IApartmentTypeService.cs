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
    Task<ReturnResponsesDto> CreateApartmentTypeAsync(ApartmentTypeCreateDto values);
    Task<ReturnResponsesDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values);
    Task<ReturnResponsesDto> DeleteApartmentType(int apartmentTypeId);
    Task<IEnumerable<ApartmentTypesReadDto>> GetApartmentTypeAsync();
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(int value);
    Task<ApartmentTypeReadDto> GetApartmentTypeAsync(string value);
}

