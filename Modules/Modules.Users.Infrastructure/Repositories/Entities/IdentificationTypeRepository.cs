using System;
namespace Modules.Users.Infrastructure.Repositories.Entities
{
    public class IdentificationTypeRepository : Repository<IdentificationType>, IIdentificationTypeRepository
    {
        public IdentificationTypeRepository(UserDbContext dbContext) : base(dbContext)
        {
        }
    }
}

