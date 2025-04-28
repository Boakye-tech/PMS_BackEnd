// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Infrastructure
{
	public class NotificationDbContext : ModuleDbContext
    {
        protected override string Schema => "ntf";

        public NotificationDbContext(DbContextOptions<NotificationDbContext> options) : base(options)
        {
		}

        public DbSet<Notifications> Notifications { get; set; }
    }
}

