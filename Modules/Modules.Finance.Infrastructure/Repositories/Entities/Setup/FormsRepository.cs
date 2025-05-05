// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Infrastructure.Repositories.Entities.Setup
{
	public class FormsRepository : Repository<Forms>, IFormsRepository
    {
		public FormsRepository(FinanceDbContext dbContext) : base(dbContext)
		{
		}
	}
}

