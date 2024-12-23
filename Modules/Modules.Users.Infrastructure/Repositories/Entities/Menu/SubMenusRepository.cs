using System;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Domain.Entities.Menu;
using Modules.Users.Domain.Interfaces.Entities.Menu;

namespace Modules.Users.Infrastructure.Repositories.Entities.Menu
{
    public class SubMenusRepository : Repository<SubMenus>, ISubMenusRepository
    {
		public SubMenusRepository(UserDbContext dbContext) : base(dbContext)

        {
		}
	}
}

