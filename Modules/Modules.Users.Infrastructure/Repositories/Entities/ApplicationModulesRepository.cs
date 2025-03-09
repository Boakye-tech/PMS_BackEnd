using System;
namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class ApplicationModulesRepository : Repository<ApplicationModules>, IApplicationModulesRepository
    {
		public ApplicationModulesRepository(UserDbContext dbContext) : base(dbContext)
        {
		}
	}
}

