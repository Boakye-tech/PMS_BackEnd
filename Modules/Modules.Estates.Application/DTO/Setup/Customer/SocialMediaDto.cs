// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Customer;

public record SocialMediaReadDto(int SocialMediaId, string SocialMediaPlatform);
public record SocialMediaCreateDto(int SocialMediaId, string SocialMediaPlatform, string CreatedBy);
public record SocialMediaUpdateDto(int SocialMediaId, string SocialMediaPlatform, string ModifiedBy);
public record SocialMediaDeleteDto(int SocialMediaId);
