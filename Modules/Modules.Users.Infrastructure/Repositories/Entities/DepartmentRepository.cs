using System;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
		public DepartmentRepository(UserDbContext dbContext) :	base(dbContext)
		{
		}
	}
}

