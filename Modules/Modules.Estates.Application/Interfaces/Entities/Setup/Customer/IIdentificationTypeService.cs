// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Customer;

public interface IIdentificationTypeService
{
    Task<IdentificationTypeReadDto> AddIdentificationTypeAsync(IdentificationTypeCreateDto values);
    Task<IdentificationTypeReadDto> UpdateIdentificationTypeAsync(IdentificationTypeUpdateDto values);
    Task<IEnumerable<IdentificationTypeReadDto>> GetIdentificationTypeAsync();
    Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(int value);
    Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(string value);

    Task<string> DeleteIdentificationTypeAsync(int value);
}

