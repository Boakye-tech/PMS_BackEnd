using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Infrastructure.Configuration
{
	//public class MenuActionConfiguration : IEntityTypeConfiguration<MenuActions>
	//{
		
 //       public void Configure(EntityTypeBuilder<MenuActions> builder)
 //       {
 //           //throw new NotImplementedException();
 //           builder.HasIndex(ma => ma.ActionName).IsUnique(true);

 //           builder.HasData(
 //               new MenuActions(1, "No Access", string.Empty),
 //               new MenuActions(2, "Create", string.Empty),
 //               new MenuActions(3, "Read", string.Empty),
 //               new MenuActions(4, "Update", string.Empty),
 //               new MenuActions(5, "Delete", string.Empty),
 //               new MenuActions(6, "Approve", string.Empty),
 //               new MenuActions(7, "Access", string.Empty)
 //               );
 //       }
 //   }
}

