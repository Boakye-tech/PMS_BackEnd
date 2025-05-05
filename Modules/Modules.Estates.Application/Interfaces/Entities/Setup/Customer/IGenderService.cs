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

public interface IGenderService
{
    Task<GenderReadDto> AddGenderAsync(GenderCreateDto values);
    Task<GenderReadDto> UpdateGenderAsync(GenderUpdateDto values);
    Task<IEnumerable<GenderReadDto>> GetGenderAsync();
    Task<GenderReadDto> GetGenderAsync(int value);
    Task<GenderReadDto> GetGenderAsync(string value);

    Task<string> DeleteGenderAsync(int value);
}

