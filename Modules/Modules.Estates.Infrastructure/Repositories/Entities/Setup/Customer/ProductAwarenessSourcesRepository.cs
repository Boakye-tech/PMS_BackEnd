// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:35 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Infrastructure.Repositories.Entities.Setup.Customer;

public class ProductAwarenessSourcesRepository : Repository<ProductAwarenessSources>, IProductAwarenessSourcesRepository
{
    public ProductAwarenessSourcesRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
