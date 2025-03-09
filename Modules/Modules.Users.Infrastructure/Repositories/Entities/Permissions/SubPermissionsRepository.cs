using System;
namespace Modules.Users.Infrastructure.Repositories.Entities.Permissions
{
	public class SubPermissionsRepository: Repository<SubPermissions>, ISubPermissionsRepository
    {
		public SubPermissionsRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

