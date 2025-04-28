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

public interface INationalityService
{
    Task<NationalityReadDto> AddNationalityAsync(NationalityCreateDto values);
    Task<NationalityReadDto> UpdateNationalityAsync(NationalityUpdateDto values);
    Task<IEnumerable<NationalityReadDto>> GetNationalityAsync();
    Task<NationalityReadDto> GetNationalityAsync(int value);
    Task<NationalityReadDto> GetNationalityAsync(string value);

    Task<string> DeleteNationalityAsync(int value);
}

