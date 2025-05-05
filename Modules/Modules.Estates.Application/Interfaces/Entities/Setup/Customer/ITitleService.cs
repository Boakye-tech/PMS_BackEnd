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

public interface ITitleService
{
    Task<TitleReadDto> AddTitleAsync(TitleCreateDto values);
    Task<TitleReadDto> UpdateTitleAsync(TitleUpdateDto values);
    Task<IEnumerable<TitleReadDto>> GetTitleAsync();
    Task<TitleReadDto> GetTitleAsync(int value);
    Task<TitleReadDto> GetTitleAsync(string value);

    Task<string> DeleteTitleAsync(int value);
}

