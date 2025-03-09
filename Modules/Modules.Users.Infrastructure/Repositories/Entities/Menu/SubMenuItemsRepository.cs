using System;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Domain.Entities.Menu;
using Modules.Users.Domain.Interfaces.Entities.Menu;

namespace Modules.Users.Infrastructure.Repositories.Entities.Menu
{
    public class SubMenuItemsRepository : Repository<SubMenuItems>, ISubMenuItemsRepository
    {
		public SubMenuItemsRepository(UserDbContext dbContext) : base(dbContext)

        {
		}
	}
}

