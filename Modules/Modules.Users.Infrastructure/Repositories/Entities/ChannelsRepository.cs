using System;
namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class ChannelsRepository : Repository<Channels>, IChannelsRepository
    {
		public ChannelsRepository(UserDbContext dbContext) : base(dbContext)
        {
		}
	}
}

