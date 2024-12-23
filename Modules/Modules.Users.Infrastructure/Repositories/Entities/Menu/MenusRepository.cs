using System;
using Modules.Users.Domain.Entities.Menu;
using Modules.Users.Domain.Interfaces.Entities.Menu;

namespace Modules.Users.Infrastructure.Repositories.Entities.Menu
{
	public class MenusRepository : Repository<Menus>, IMenusRepository
    {
		public MenusRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

