using System;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Domain.Entities.Menu;
using Modules.Users.Infrastructure.Configuration;

namespace Modules.Users.Infrastructure
{
	public class UserDbContext : IdentityDbContext<ApplicationIdentityUser, ApplicationIdentityRole, string, IdentityUserClaim<string>, ApplicationIdentityUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
	{
		public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
		}


        public DbSet<ApplicationIdentityUser> UserDetails { get; set; }
        public DbSet<ApplicationIdentityRole> roles { get; set; }
        public DbSet<ApplicationIdentityUserRole> userRoles { get; set; }

        public DbSet<Department> Department { get; set; } 
        public DbSet<DepartmentUnit> DepartmentUnit { get; set; }
        public DbSet<TokenStore> TokenStore { get; set; }

        //menus
        public DbSet<Menus> Menus { get; set; }
        public DbSet<SubMenus> SubMenus { get; set; }
        public DbSet<MenuActions> MenuActions { get; set; }
        public DbSet<RoleMenuActions> RoleMenuActions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Department>()
                .HasIndex(d => d.DepartmentName)
                .IsUnique(true);

            builder.Entity<DepartmentUnit>()
                .HasIndex(du => du.UnitName)
                .IsUnique(true);

            builder.Entity<TokenStore>()
                .HasIndex(ts => ts.Token)
                .IsUnique();

            builder.Entity<Menus>()
                .HasIndex(m => m.MenuName)
                .IsUnique(true);

            builder.Entity<SubMenus>()
                .HasIndex(sm => sm.SubMenuName)
                .IsUnique(true);

            builder.Entity<RoleMenuActions>()
               .HasIndex(rma => new { rma.RoleId, rma.MenuId, rma.ActionId })
               .IsUnique(true);

            builder.ApplyConfiguration(new MenuActionConfiguration());

        }
    }
}

