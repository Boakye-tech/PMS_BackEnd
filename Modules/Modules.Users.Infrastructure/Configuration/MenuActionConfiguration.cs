﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Infrastructure.Configuration
{
    //public class MenuActionConfiguration : IEntityTypeConfiguration<Actions>
    //{

    //    public void Configure(EntityTypeBuilder<Actions> builder)
    //    {
    //        //throw new NotImplementedException();
    //        builder.HasIndex(ma => ma.ActionName).IsUnique(true);

    //        builder.HasData(
    //            new Actions(1, "CREATE", string.Empty),
    //            new Actions(2, "READ", string.Empty),
    //            new Actions(3, "UPDATE", string.Empty),
    //            new Actions(4, "DELETE", string.Empty),
    //            new Actions(5, "APPROVE", string.Empty),
    //            new Actions(6, "VERIFY", string.Empty),
    //            new Actions(7, "REJECT", string.Empty),
    //            new Actions(8, "DISAPPROVE", string.Empty),
    //            new Actions(9, "ACTIVATE", string.Empty),
    //            new Actions(10, "DEACTIVATE", string.Empty)
    //            );
    //    }
    //}
}


