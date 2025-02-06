using System;
namespace Modules.Users.Infrastructure.Repositories.Entities.Permissions
{
	public class SubPermissionsItemsRepository: Repository<SubPermissionsItems>, ISubPermissionsItemsRepository
	{
		public SubPermissionsItemsRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

