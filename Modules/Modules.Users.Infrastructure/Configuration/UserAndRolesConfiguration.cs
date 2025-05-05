// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Modules.Users.Infrastructure.Configuration
{
	public static class UserAndRolesConfiguration
	{
        public static async Task SeedUserAndRoles(IServiceProvider _serviceProvider)
        {
            using var scope = _serviceProvider.CreateScope();
            var dbContext = scope.ServiceProvider.GetRequiredService<UserDbContext>();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<ApplicationIdentityUser>>();
            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<ApplicationIdentityRole>>();

            //check if db exist
            if (!await dbContext.Database.CanConnectAsync())
            {
                // Delete db if exists
                //await dbContext.Database.EnsureDeletedAsync();

                //apply latest migration
                await dbContext.Database.MigrateAsync();
            }

            //add roles if administrator does not exist
            if (!roleManager.RoleExistsAsync("Administrator").Result)
            {
                await roleManager.CreateAsync(new ApplicationIdentityRole
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    ApprovedBy = "sys",
                    ApprovedOn = DateTime.UtcNow,
                    CreatedBy = "sys",
                    CreatedOn = DateTime.UtcNow,
                    Status = 1
                });

                await roleManager.CreateAsync(new ApplicationIdentityRole
                {
                    Name = "MISAdministrator",
                    NormalizedName = "MISADMINISTRATOR",
                    ApprovedBy = "sys",
                    ApprovedOn = DateTime.UtcNow,
                    CreatedBy = "sys",
                    CreatedOn = DateTime.UtcNow,
                    Status = 1
                });
            }

            var _email = "boakye@yopmail.com";
            var misadmin_email = "dschandorf@hotmail.com";

            if (userManager.FindByEmailAsync(_email).Result == null)
            {
                //seed initial admin
                var _user = new ApplicationIdentityUser
                {
                    Id = "03383fea-6da6-41f5-8389-09d8a3b3aadb",
                    IdentificationNumber = "0000",
                    FirstName = "System",
                    MiddleName = "",
                    LastName = "Administrator",
                    DepartmentId = 1,
                    UnitId = 1,
                    ChannelId = 301,
                    Status = 9,
                    CreatedBy = "sys",
                    CreatedDate = DateTime.UtcNow,
                    UserName = _email,
                    NormalizedUserName = _email.ToUpper(),
                    Email = _email,
                    NormalizedEmail = _email.ToUpper(),
                    PhoneNumber = "0221234567",
                    EmailConfirmed = true,
                    FirebaseId = string.Empty,
                    RegistrationDate = DateTime.UtcNow,
                    IsFirstTime = false,
                    UserType = 0
                };


                //seed initial mis admin
                var _misUser = new ApplicationIdentityUser
                {
                    Id = "8fe36d96-7724-4364-b7c0-c570308636d6",
                    IdentificationNumber = "EMP001",
                    FirstName = "Daniel",
                    MiddleName ="",
                    LastName = "Schandorf",
                    DepartmentId = 401,
                    UnitId = 210,
                    ChannelId = 301,
                    Status = 9,
                    CreatedBy = "sys",
                    CreatedDate = DateTime.UtcNow,
                    UserName = misadmin_email,
                    NormalizedUserName = misadmin_email.ToUpper(),
                    Email = misadmin_email,
                    NormalizedEmail = misadmin_email.ToUpper(),
                    PhoneNumber = "0244745065",
                    EmailConfirmed = true,
                    FirebaseId = string.Empty,
                    RegistrationDate = DateTime.UtcNow,
                    IsFirstTime = false,
                    UserType = 3
                };

                IdentityResult identityResult = userManager.CreateAsync(_user, "SwordFish@2001").Result;
                if (identityResult.Succeeded)
                    await userManager.AddToRoleAsync(_user, "Administrator");

                identityResult = userManager.CreateAsync(_misUser, "SwordFish@2001").Result;
                if (identityResult.Succeeded)
                    await userManager.AddToRoleAsync(_misUser, "MISAdministrator");

            }


        }
    }
}

