using System;

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

