using System;
namespace Modules.Users.Infrastructure.Repositories
{
	public class UsersRolesRepository : Repository<ApplicationIdentityUserRole>, IUsersRolesRepository
    {
		public UsersRolesRepository(UserDbContext	dbContext) : base(dbContext)
		{
		}
	}
}

