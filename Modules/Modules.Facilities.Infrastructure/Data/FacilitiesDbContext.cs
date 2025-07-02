// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Infrastructure/Data/FacilitiesDbContext.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 11:38 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Infrastructure.Data
{
	public class FacilitiesDbContext : ModuleDbContext
    {
        protected override string Schema => "fac";

        public FacilitiesDbContext(DbContextOptions<FacilitiesDbContext> options) : base(options)
        {
		}

        public DbSet<Category> Category { get; set; }
        public DbSet<Cleaners> Cleaners { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<ItemsCategory> ItemsCategory { get; set; }
        public DbSet<ServiceCategory> ServiceCategory { get; set; }
        public DbSet<ServiceProviders> ServiceProviders  { get; set; }
        public DbSet<Services> Services  { get; set; }
        public DbSet<Stock> Stock  { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }

    }
}

