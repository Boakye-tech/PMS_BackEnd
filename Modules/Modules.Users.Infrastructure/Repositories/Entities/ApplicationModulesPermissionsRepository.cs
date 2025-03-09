using System;
namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class ApplicationModulesPermissionsRepository : Repository<ApplicationModulesPermissions>, IApplicationModulesPermissionsRepository
    {
		public ApplicationModulesPermissionsRepository(UserDbContext dbContext) : base(dbContext)
        {
		}
	}
}

