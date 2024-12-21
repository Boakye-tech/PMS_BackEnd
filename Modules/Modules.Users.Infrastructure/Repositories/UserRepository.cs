using System;
namespace Modules.Users.Infrastructure.Repositories
{
	public class UserRepository : Repository<ApplicationIdentityUser>, IUserRepository
    {
		public UserRepository(UserDbContext	dbContext) : base(dbContext)
		{
		}
	}
}

