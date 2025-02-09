using System;
namespace Modules.Users.Infrastructure.Repositories
{
	public class StaffAccountsRepository : Repository<StaffAccounts>, IStaffAccountsRepository
    {
		public StaffAccountsRepository(UserDbContext dbContext) : base(dbContext)
        {
		}
	}
}

