using System;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class DepartmentUnitRepository : Repository<DepartmentUnit>, IDepartmentUnitRepository
    {
		public DepartmentUnitRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

