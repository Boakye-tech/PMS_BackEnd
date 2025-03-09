using System;


namespace Modules.Users.Infrastructure.Repositories.Entities.Permissions
{
	public class PermissionsRepository: Repository<AccessPermissions>, IPermissionsRepository
	{
		public PermissionsRepository(UserDbContext dbContext) : base(dbContext)
        {
		}
	}
}

