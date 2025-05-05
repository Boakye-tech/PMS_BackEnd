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

public interface ISocialMediaService
{
    Task<SocialMediaReadDto> AddSocialMediaAsync(SocialMediaCreateDto values);
    Task<SocialMediaReadDto> UpdateSocialMediaAsync(SocialMediaUpdateDto values);
    Task<IEnumerable<SocialMediaReadDto>> GetSocialMediaAsync();
    Task<SocialMediaReadDto> GetSocialMediaAsync(int value);
    Task<SocialMediaReadDto> GetSocialMediaAsync(string value);

    Task<string> DeleteSocialMediaAsync(int value);
}

