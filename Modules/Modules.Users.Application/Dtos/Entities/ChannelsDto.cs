// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Entities
{
    public record ChannelReadDto(int ChannelId, string ChannelName);
    public record ChannelCreateDto(int ChannelId, string ChannelName, string CreatedBy);
    public record ChannelUpdateDto(int ChannelId, string ChannelName, string ModifiedBy);
    public record ChannelDeleteDto(int ChannelId);

}

