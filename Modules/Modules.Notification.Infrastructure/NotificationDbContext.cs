// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/NotificationDbContext.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/02/2025 1:59 PM
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

        //27th May '25
        public DbSet<NotificationPreferences> NotificationPreferences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //set custom schema
            modelBuilder.HasDefaultSchema("ntf");

            modelBuilder.Entity<NotificationPreferences>()
                .HasIndex(np => np.UserId)
                .IsUnique(true);
        }

    }
}

