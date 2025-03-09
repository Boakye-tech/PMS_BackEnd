using System;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Modules.Users.Application.Dtos.Administration;
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

        public DbSet<Channels> Channels { get; set; }
        public DbSet<Department> Department { get; set; } 
        public DbSet<DepartmentUnit> DepartmentUnit { get; set; }
        public DbSet<TokenStore> TokenStore { get; set; }

        //menus
        public DbSet<Menus> Menus { get; set; }
        public DbSet<SubMenus> SubMenus { get; set; }
        public DbSet<SubMenuItems> SubMenuItems { get; set; }

        public DbSet<AccessPermissions> Permissions { get; set; }
        public DbSet<SubPermissions> SubPermissions { get; set; }
        public DbSet<SubPermissionsItems> SubPermissionsItems { get; set; }

        public DbSet<StaffAccounts> StaffAccounts { get; set; }

        public DbSet<ApplicationModules> ApplicationModules { get; set; }
        public DbSet<ApplicationModulesPermissions> ApplicationModulesPermissions { get; set; }

        public DbSet<IdentificationType> IdentificationType { get; set; }

        //public DbSet<Actions> MenuActions { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "dbo");
            builder.Entity<ApplicationIdentityRole>().ToTable("Roles", "dbo");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "dbo");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "dbo");
            builder.Entity<ApplicationIdentityUserRole>().ToTable("UserRoles", "dbo");
            builder.Entity<ApplicationIdentityUser>().ToTable("Users", "dbo");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "dbo");

            builder.Entity<Channels>()
                .HasIndex(c => c.ChannelName)
                .IsUnique(true);

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
           
            builder.Entity<SubMenuItems>()
                .HasIndex(smi => smi.SubMenuItemName)
                .IsUnique(true);

            builder.Entity<ApplicationModules>()
                .HasIndex(am => new { am.ModuleId, am.ModuleName })
                .IsUnique(true);

            builder.Entity<IdentificationType>()
                .HasKey(e => e.IdentificationTypeId);

            builder.Entity<IdentificationType>()
                .Property(e => e.IdentificationTypeId)
                .ValueGeneratedNever();

            builder.Entity<IdentificationType>()
                .HasIndex(e => new { e.IdentificationTypeId, e.IdentificationTypes })
                .IsUnique(true);

            //builder.Entity<Actions>()
            //    .HasIndex(a => a.ActionName)
            //    .IsUnique(true);


            builder.ApplyConfiguration(new ChannelConfiguration());
            builder.ApplyConfiguration(new DepartmentsConfiguration());
            builder.ApplyConfiguration(new DepartmentsUnitsConfiguration());


        }
    }
}

