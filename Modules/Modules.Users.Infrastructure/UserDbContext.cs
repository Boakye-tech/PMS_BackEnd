using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Modules.Users.Infrastructure
{
	public class UserDbContext : IdentityDbContext<ApplicationIdentityUser>
	{
		public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
		}


        public DbSet<ApplicationIdentityUser> UserDetails { get; set; }
        public DbSet<IdentityRole> roles { get; set; }
        public DbSet<IdentityUserRole<string>> userRoles { get; set; }

        public DbSet<Department> Department { get; set; } 
        public DbSet<DepartmentUnit> DepartmentUnit { get; set; }
        public DbSet<TokenStore> TokenStore { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

