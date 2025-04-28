// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Infrastructure.Repositories.Entities.Menu
{
	public class MenusRepository : Repository<Menus>, IMenusRepository
    {
		public MenusRepository(UserDbContext dbContext) : base(dbContext)
		{
		}
	}
}

