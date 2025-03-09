using System;
namespace Modules.Users.Infrastructure.Repositories
{
	public class RolesRepository : Repository<ApplicationIdentityRole>, IRolesRepository
    {
		public RolesRepository(UserDbContext	dbContext) : base(dbContext)
		{
		}
	}
}

