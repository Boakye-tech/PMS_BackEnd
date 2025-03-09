using System;
namespace Modules.Users.Application.Dtos.Entities
{
    public record ChannelReadDto(int ChannelId, string ChannelName);
    public record ChannelCreateDto(int ChannelId, string ChannelName, string CreatedBy);
    public record ChannelUpdateDto(int ChannelId, string ChannelName, string ModifiedBy);
    public record ChannelDeleteDto(int ChannelId);

}

