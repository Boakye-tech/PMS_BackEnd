using System;
using Modules.Users.Domain.Interfaces.Entities;

namespace Modules.Users.Infrastructure.Repositories.Entities
{
	public class TokenStoreRepository : Repository<TokenStore>, ITokenStoreRepository
	{
		public TokenStoreRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

